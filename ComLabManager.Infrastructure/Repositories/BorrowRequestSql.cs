namespace ComLabManager.Infrastructure.Repositories
{
    // Shared WHERE fragments for BorrowRequests, written against the alias "br".
    // Keep in sync with BorrowRequest.IsActiveLoan / DueAt in Core.
    internal static class BorrowRequestSql
    {
        // An item that is still out with the student (whole-room bookings are not loans)
        public const string ActiveLoanCondition =
            "br.EquipmentId IS NOT NULL AND br.Status IN ('Approved', 'In Use')";

        // An active loan past its end time; an end time at or before the start time runs overnight into the next day
        public const string OverdueCondition =
            ActiveLoanCondition + " AND TIMESTAMP(br.RequestedDate, br.EndTime) + INTERVAL (br.EndTime <= br.StartTime) DAY < NOW()";
    }
}
