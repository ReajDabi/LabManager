# LabManager — Project Documentation

Technical reference for developers working on the ComLab Tools & Equipment Management System. For a feature overview, see `README.md`.

## 1. Architecture

The solution (`comlab_tools_and_equipment_management_system.slnx`) has three projects, all targeting .NET 10:

| Project | Folder | Responsibility |
|---|---|---|
| `ComLabManager.Core` | `ComLabManager.Core/` | Models (`Models/`) and repository interfaces (`Interfaces/`). No database or UI code. |
| `ComLabManager.Infrastructure` | `ComLabManager.Infrastructure/` | One Dapper repository per area (`Repositories/`), each implementing a Core interface. |
| `ComLabManager.UI` | `comlab_tools_and_equipment_management_system/` | WinForms app: `MainForm`, page `Views/`, modal forms, and role `NavigationStrategies/`. |

**Startup flow** (`Program.cs`)
1. Reads `DefaultConnection` from `App.config`.
2. Registers every repository in `Microsoft.Extensions.DependencyInjection`, each constructed with the connection string.
3. Shows `LoginForm`. On success, picks an `IRoleNavigationStrategy` from the user's role and calls `MainForm.SetCurrentUser`.

**Navigation.** `MainForm` keeps a `_navigationMap` of sidebar button → (page title, view factory). Clicking a button disposes the current view and loads a new one. Each role's strategy decides which buttons are visible and which page opens first.

**Dashboard routing.** Each dashboard KPI card (`Views/Controls/KpiCard`) maps to an `AppPage` + `ViewFilter` (`Navigation/`). `DashboardView` receives `MainForm.NavigateTo` as an injected delegate. `NavigateTo` opens the page through the normal nav map and, if the page implements `IFilterableView`, calls `ApplyFilter`. Filtered pages show a `FilterBanner` with a **Show all** link. To make another page filterable, implement `IFilterableView` on it; `MainForm` doesn't change.

## 2. Roles

| Capability | Admin | Technician | Student |
|---|---|---|---|
| Dashboard, Equipment Inventory, User Management | ✔ | | |
| Maintenance Tickets | ✔ (assign) | ✔ ("My Tasks") | |
| PM Scheduler | ✔ | ✔ | |
| Spare Parts | ✔ (edit stock) | ✔ (request parts) | |
| Requests | Approve/deny | | Own borrow requests + lab schedule |

Suspension (`Users.IsSuspended`) can only be set on Students. It blocks new borrow requests, and suspended users are left out of assignment lists.

## 3. Status lifecycles

- **Maintenance ticket:** `Open` → `Under Repair` (Start Repair; equipment also becomes `Under Repair`) → `Resolved` (optionally consumes 1 spare part; equipment returns to `Active` once no other repair is open).
- **Borrow request:** `Pending` → `Approved` (equipment becomes `In Use`) → `Returned` (equipment becomes `Available` and its `UsageCount` goes up by 1). A `Pending` request can also become `Denied`.
- **Spare-part request:** `Pending` → `Approved` (stock is deducted) or `Denied`.
- **Preventive maintenance task:** has no status column. The status is computed from `NextDueDate`: Overdue, Due Soon (within 7 days), or Scheduled. **Mark Done** sets `LastCompleted` to today and moves `NextDueDate` forward by the frequency (Weekly, Monthly, Quarterly, Biannually = 6 months, Annually).
- **Equipment:** `Available`, `Active`, `In Use`, `Under Repair`, `Decommissioned`. Equipment with `UsageCount >= Equipment.HighUsageThreshold` (15) is flagged as high usage.

- **Overdue loan:** an equipment loan (`EquipmentId` set, status `Approved` or `In Use`) whose due time has passed. The due time is `RequestedDate + EndTime`, plus one day when `EndTime <= StartTime` (overnight). Whole-room reservations are never overdue. The rule is written once in C# (`BorrowRequest.DueAt` / `IsOverdue`) and once in SQL (`BorrowRequestSql.OverdueCondition`); keep the two in sync. Overdue rows are shown in red with the status "Overdue". While a student has an overdue item, new borrow requests are refused; the block lifts as soon as the item is marked Returned.

Only `Pending` requests can be approved or denied. The repositories enforce this too, so a stale screen can't process a request twice.

## 4. Business rules worth knowing

- **Booking a whole room** is rejected if it overlaps an official class in `ComLabSchedules` or another approved whole-room booking.
- **Borrowing equipment** is rejected if the same item already has an overlapping approved request, or if its status isn't `Available`/`Active`.
- **Spare parts are soft-deleted** (`IsDeleted = 1`) and hidden from every list. Adding a part with a deleted part's name restores that row.
- **Deleting equipment** cascades to its tickets, borrow requests and PM tasks.
- **A user who reported a maintenance ticket can't be deleted** (FK `RESTRICT`); suspend them instead. Admins can't delete their own account.
- **Lab locations** come from one place, `Core/Models/LabLocations.cs`: `Rooms` for bookable rooms and `All` for every location including Storage. Don't hard-code location lists in forms.

## 5. Coding conventions

- **Repositories:** one `using (var connection = new MySqlConnection(_connectionString))` per method, with SQL in `@"..."` strings and Dapper parameters. Multi-step writes use a transaction.
- **Rule violations:** repositories throw `InvalidOperationException` with a user-readable message. Status updates guard on the expected current status and throw when 0 rows change.
- **UI error handling:** wrap repository calls in try/catch and show `"An error occurred while <action>: {ex.Message}"` with the caption `"System Error"`. Show MySQL duplicate-key errors (1062) as a friendly warning.
- **Views:** take their dependencies through the constructor, guarded with `?? throw new ArgumentNullException(...)`. Store the row's model in `DataGridViewRow.Tag` or read it from `DataBoundItem`. Combo options use small private `XxxOption` classes that override `ToString()`.
- **Names:** use the namespace `ComLabManager.*` everywhere.

## 6. Database

- **Schema and seed:** `LabManager_Master_Database_Migration.sql` drops and recreates every table, loads realistic seed data, and creates the `AutoPurgeOldRequests` event. This event deletes Returned/Denied borrow requests and Approved/Denied part requests older than 90 days.
- **Connection string:** `comlab_tools_and_equipment_management_system/App.config` (defaults to `root` with no password on `localhost:3306`).
- **Seed logins:** `admin_reaj`, `tech_chrishian` and `student_test`, password `password123`. Note that `Program.cs` resets these three accounts to `password123` every time the app starts.

## 7. Known limitations

- Users and Equipment are hard-deleted. Keeping their history would need soft-delete columns, i.e. a schema change.
- The seed data contains a borrow request with status `In Use`, which no code path produces. It's treated the same as `Approved` (it can be returned and can go overdue).
