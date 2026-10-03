CREATE DATABASE IF NOT EXISTS LabManagerDb;
USE LabManagerDb;

-- Temporarily disable foreign key checks to allow clean table dropping
SET FOREIGN_KEY_CHECKS = 0;

DROP TABLE IF EXISTS BorrowRequests;
DROP TABLE IF EXISTS ComLabSchedules;
DROP TABLE IF EXISTS SparePartRequests;
DROP TABLE IF EXISTS PreventiveMaintenance;
DROP TABLE IF EXISTS MaintenanceParts;
DROP TABLE IF EXISTS MaintenanceLogs;
DROP TABLE IF EXISTS Equipment;
DROP TABLE IF EXISTS Users;

-- 1. USERS (Added First/Last Name for Admin details)
CREATE TABLE Users (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Role VARCHAR(30) NOT NULL,
    FirstName VARCHAR(50) NULL, 
    LastName VARCHAR(50) NULL,  
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- 2. EQUIPMENT (Added UsageCount, kept AssetTag)
CREATE TABLE Equipment (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    AssetTag VARCHAR(50) NOT NULL UNIQUE, 
    Name VARCHAR(100) NOT NULL,           
    Category VARCHAR(50) NOT NULL,        
    Status VARCHAR(50) NOT NULL,          -- Active, Under Repair, Decommissioned, High Usage
    StationNumber VARCHAR(20) NULL,       
    UsageCount INT DEFAULT 0,             -- Tracks how many times a PC/Item is borrowed
    DateAcquired DATE NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- 3. MAINTENANCE LOGS (Removed Financial/Repair Cost)
CREATE TABLE MaintenanceLogs (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    EquipmentId INT NOT NULL,
    ReportedById INT NOT NULL,
    IssueDescription TEXT NOT NULL,
    Status VARCHAR(50) NOT NULL,          
    DateReported DATETIME DEFAULT CURRENT_TIMESTAMP,
    DateResolved DATETIME NULL,
    FOREIGN KEY (EquipmentId) REFERENCES Equipment(Id) ON DELETE CASCADE,
    FOREIGN KEY (ReportedById) REFERENCES Users(Id) ON DELETE RESTRICT
);

-- 4. PREVENTIVE MAINTENANCE (Updated for ComLab scope & String Frequencies)
CREATE TABLE PreventiveMaintenance (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    TargetLocation VARCHAR(50) NOT NULL,  -- CLV1, CLV2, CLV3, Engineering, ICT
    EquipmentId INT NULL,                 -- NULL means the PM is for the whole room
    TaskName VARCHAR(100) NOT NULL,       
    Frequency VARCHAR(50) NOT NULL,       -- Annually, Monthly, Quarterly, etc.
    LastCompleted DATE NULL,
    NextDueDate DATE NOT NULL,
    AssignedTo INT NULL,                  
    FOREIGN KEY (EquipmentId) REFERENCES Equipment(Id) ON DELETE CASCADE,
    FOREIGN KEY (AssignedTo) REFERENCES Users(Id) ON DELETE SET NULL
);

-- 5. SPARE PART REQUESTS (New Admin Approval Workflow)
CREATE TABLE SparePartRequests (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    TechId INT NOT NULL,
    RequestedPartId INT NOT NULL,
    Quantity INT NOT NULL DEFAULT 1,
    Reason TEXT NOT NULL,
    Status VARCHAR(30) DEFAULT 'Pending', -- Pending, Approved, Denied
    RequestDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (TechId) REFERENCES Users(Id) ON DELETE CASCADE,
    FOREIGN KEY (RequestedPartId) REFERENCES Equipment(Id) ON DELETE CASCADE
);

-- 6. COMLAB SCHEDULES (New feature for Student viewing)
CREATE TABLE ComLabSchedules (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    ComLabName VARCHAR(50) NOT NULL,      -- CLV1, CLV2, CLV3, Engineering, ICT
    SubjectCode VARCHAR(50) NOT NULL,
    InstructorName VARCHAR(100) NOT NULL,
    DayOfWeek VARCHAR(15) NOT NULL,       
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL
);

-- 7. BORROW REQUESTS (New feature for Students)
CREATE TABLE BorrowRequests (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    StudentId INT NOT NULL,
    EquipmentId INT NULL,                 -- NULL if borrowing a whole ComLab room
    TargetLocation VARCHAR(50) NULL,      -- CLV1, CLV2, etc.
    Purpose TEXT NOT NULL,
    RequestedDate DATE NOT NULL,
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL,
    Status VARCHAR(30) DEFAULT 'Pending', -- Pending, Approved, Denied, Returned
    FOREIGN KEY (StudentId) REFERENCES Users(Id) ON DELETE CASCADE,
    FOREIGN KEY (EquipmentId) REFERENCES Equipment(Id) ON DELETE CASCADE
);

-- Re-enable foreign key checks
SET FOREIGN_KEY_CHECKS = 1;

-- Seed your test accounts again so you can log in
INSERT INTO Users (Username, PasswordHash, Role, FirstName, LastName) VALUES 
('admin_reaj', 'dummy_hash', 'Admin', 'Reajzedrik', 'Dabi'),
('tech_chrishian', 'dummy_hash', 'Technician', 'Chrishian', 'Degaom'),
('student_test', 'dummy_hash', 'Student', 'Test', 'Student');