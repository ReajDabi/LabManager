CREATE DATABASE IF NOT EXISTS LabManagerDb;
USE LabManagerDb;

-- 1. TURN ON EVENT SCHEDULER FOR AUTO-PURGE
SET GLOBAL event_scheduler = ON;

-- 2. DISABLE FOREIGN KEYS FOR CLEAN DROP
SET FOREIGN_KEY_CHECKS = 0;

DROP TABLE IF EXISTS BorrowRequests;
DROP TABLE IF EXISTS ComLabSchedules;
DROP TABLE IF EXISTS SparePartRequests;
DROP TABLE IF EXISTS PreventiveMaintenance;
DROP TABLE IF EXISTS MaintenanceParts;
DROP TABLE IF EXISTS SpareParts;
DROP TABLE IF EXISTS MaintenanceLogs;
DROP TABLE IF EXISTS Equipment;
DROP TABLE IF EXISTS Users;

-- 3. CREATE TABLES IN DEPENDENCY ORDER

CREATE TABLE Users (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Role VARCHAR(30) NOT NULL,
    FirstName VARCHAR(50) NULL, 
    LastName VARCHAR(50) NULL,  
    IsSuspended TINYINT(1) DEFAULT 0,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Equipment (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    AssetTag VARCHAR(50) NOT NULL UNIQUE, 
    Name VARCHAR(100) NOT NULL,           
    Category VARCHAR(50) NOT NULL,        
    Status VARCHAR(50) NOT NULL,          -- Available, Active, In Use, Under Repair, Decommissioned
    StationNumber VARCHAR(20) NULL,       -- CLV1-01, Engineering, Storage, etc.
    UsageCount INT DEFAULT 0,             
    DateAcquired DATE NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE SpareParts (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL UNIQUE,
    Category VARCHAR(50) NULL,
    Quantity INT NOT NULL DEFAULT 0,
    RestockLevel INT NOT NULL DEFAULT 5 
);

CREATE TABLE MaintenanceLogs (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    EquipmentId INT NOT NULL,
    ReportedById INT NOT NULL,
    IssueDescription TEXT NOT NULL,
    Status VARCHAR(50) NOT NULL,          -- Open, Under Repair, Resolved
    DateReported DATETIME DEFAULT CURRENT_TIMESTAMP,
    DateResolved DATETIME NULL,
    AssignedTechnicianId INT NULL,        
    FOREIGN KEY (EquipmentId) REFERENCES Equipment(Id) ON DELETE CASCADE,
    FOREIGN KEY (ReportedById) REFERENCES Users(Id) ON DELETE RESTRICT,
    FOREIGN KEY (AssignedTechnicianId) REFERENCES Users(Id) ON DELETE SET NULL
);

CREATE TABLE MaintenanceParts (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    LogId INT NOT NULL,
    SparePartId INT NOT NULL,
    Quantity INT NOT NULL DEFAULT 1,
    FOREIGN KEY (LogId) REFERENCES MaintenanceLogs(Id) ON DELETE CASCADE,
    FOREIGN KEY (SparePartId) REFERENCES SpareParts(Id) ON DELETE RESTRICT
);

CREATE TABLE PreventiveMaintenance (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    TargetLocation VARCHAR(50) NOT NULL,  
    EquipmentId INT NULL,                 
    TaskName VARCHAR(100) NOT NULL,       
    Frequency VARCHAR(50) NOT NULL,       
    LastCompleted DATE NULL,
    NextDueDate DATE NOT NULL,
    AssignedTo INT NULL,                  
    FOREIGN KEY (EquipmentId) REFERENCES Equipment(Id) ON DELETE CASCADE,
    FOREIGN KEY (AssignedTo) REFERENCES Users(Id) ON DELETE SET NULL
);

CREATE TABLE SparePartRequests (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    TechId INT NOT NULL,
    RequestedPartId INT NOT NULL,
    Quantity INT NOT NULL DEFAULT 1,
    Reason TEXT NOT NULL,
    Status VARCHAR(30) DEFAULT 'Pending', -- Pending, Approved, Denied
    RequestDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (TechId) REFERENCES Users(Id) ON DELETE CASCADE,
    FOREIGN KEY (RequestedPartId) REFERENCES SpareParts(Id) ON DELETE CASCADE
);

CREATE TABLE ComLabSchedules (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    ComLabName VARCHAR(50) NOT NULL,      
    SubjectCode VARCHAR(50) NOT NULL,
    InstructorName VARCHAR(100) NOT NULL,
    DayOfWeek VARCHAR(15) NOT NULL,       
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL
);

CREATE TABLE BorrowRequests (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    StudentId INT NOT NULL,
    EquipmentId INT NULL,                 
    TargetLocation VARCHAR(50) NULL,      
    Purpose TEXT NOT NULL,
    RequestedDate DATE NOT NULL,
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL,
    Status VARCHAR(30) DEFAULT 'Pending', -- Pending, Approved, Denied, Returned
    FOREIGN KEY (StudentId) REFERENCES Users(Id) ON DELETE CASCADE,
    FOREIGN KEY (EquipmentId) REFERENCES Equipment(Id) ON DELETE CASCADE
);

SET FOREIGN_KEY_CHECKS = 1;

-- 4. INSERT REALISTIC SEED DATA

-- USERS (All use the same valid BCrypt hash you provided for easy testing)
INSERT INTO Users (Username, PasswordHash, Role, FirstName, LastName, IsSuspended) VALUES 
('admin_reaj', '$2a$11$1ehfe4lt7rMOq7iwX1YGDOor6P/BrzxXLVqmX9x7xn1xdt8Wmqery', 'Admin', 'Reajzedrik', 'Dabi', 0),
('admin_sys', '$2a$11$1ehfe4lt7rMOq7iwX1YGDOor6P/BrzxXLVqmX9x7xn1xdt8Wmqery', 'Admin', 'System', 'Director', 0),
('tech_chrishian', '$2a$11$1ehfe4lt7rMOq7iwX1YGDOor6P/BrzxXLVqmX9x7xn1xdt8Wmqery', 'Technician', 'Chrishian', 'Degaom', 0),
('tech_mark', '$2a$11$1ehfe4lt7rMOq7iwX1YGDOor6P/BrzxXLVqmX9x7xn1xdt8Wmqery', 'Technician', 'Mark', 'Villanueva', 0),
('student_test', '$2a$11$1ehfe4lt7rMOq7iwX1YGDOor6P/BrzxXLVqmX9x7xn1xdt8Wmqery', 'Student', 'Test', 'Student', 0),
('student_lion', '$2a$11$1ehfe4lt7rMOq7iwX1YGDOor6P/BrzxXLVqmX9x7xn1xdt8Wmqery', 'Student', 'Lion', 'Nel', 0),
('student_anna', '$2a$11$1ehfe4lt7rMOq7iwX1YGDOor6P/BrzxXLVqmX9x7xn1xdt8Wmqery', 'Student', 'Anna', 'Reyes', 0),
('student_bad', '$2a$11$1ehfe4lt7rMOq7iwX1YGDOor6P/BrzxXLVqmX9x7xn1xdt8Wmqery', 'Student', 'Rule', 'Breaker', 1); -- Suspended Student

-- EQUIPMENT (Mix of Active PCs, Available Tools, High-Usage items, and Broken items)
INSERT INTO Equipment (AssetTag, Name, Category, Status, StationNumber, UsageCount, DateAcquired) VALUES
('UM-SYS-101', 'Dell OptiPlex 7010', 'System Unit', 'Active', 'CLV1-01', 5, '2023-06-15'),
('UM-MON-101', 'Acer 24" Monitor', 'Monitor', 'Active', 'CLV1-01', 5, '2023-06-15'),
('UM-PER-101', 'Logitech K120 Keyboard', 'Peripheral', 'Active', 'CLV1-01', 5, '2024-01-10'),
('UM-SYS-102', 'Dell OptiPlex 7010', 'System Unit', 'Active', 'CLV1-02', 45, '2023-06-15'), -- High Usage
('UM-MON-102', 'Acer 24" Monitor', 'Monitor', 'Under Repair', 'CLV1-02', 12, '2023-06-15'),
('UM-SYS-201', 'Lenovo ThinkCentre M70', 'System Unit', 'Active', 'CLV2-01', 2, '2025-01-20'),
('UM-NET-001', 'Cisco 24-Port Switch', 'Networking', 'Active', 'ICT', 0, '2022-09-01'),
('UM-EQ-001', 'Crimper Tool', 'Tool', 'Available', 'Engineering', 22, '2024-05-11'), -- High Usage Tool
('UM-EQ-002', 'RJ45 Crimper Pro', 'Tool', 'In Use', 'Engineering', 8, '2024-05-11'),
('UM-EQ-003', 'Fluke LAN Tester', 'Tool', 'Available', 'Storage', 3, '2025-02-01'),
('UM-EQ-004', 'Precision Screwdriver Set', 'Tool', 'Available', 'Storage', 1, '2025-03-10');

-- SPARE PARTS
INSERT INTO SpareParts (Name, Category, Quantity, RestockLevel) VALUES
('8GB DDR4 3200MHz RAM', 'Memory', 15, 10),
('500W 80+ Bronze Power Supply', 'Power', 4, 5), -- Below Restock Level
('256GB SATA III SSD', 'Storage', 12, 5),
('CMOS Battery CR2032', 'Power', 45, 15),
('RJ45 Connectors (Pack of 100)', 'Networking', 3, 5),
('Thermal Paste 4g', 'Maintenance', 8, 3),
('Standard HDMI Cable 2m', 'Cable', 2, 10); -- Below Restock Level

-- COMLAB SCHEDULES
INSERT INTO ComLabSchedules (ComLabName, SubjectCode, InstructorName, DayOfWeek, StartTime, EndTime) VALUES 
('CLV1', 'IT3 - Networking 1', 'Prof. Sin', 'Monday', '08:00:00', '11:00:00'),
('CLV1', 'IT311 - Web Systems', 'Prof. Shian', 'Wednesday', '13:00:00', '16:00:00'),
('CLV1', 'IT401 - System Admin', 'Prof. Cruz', 'Friday', '09:00:00', '12:00:00'),
('CLV2', 'IT111 - Programming 1', 'Prof. Limbar', 'Tuesday', '09:00:00', '12:00:00'),
('CLV2', 'IT212 - Data Structures', 'Prof. Limbar', 'Thursday', '13:00:00', '16:00:00'),
('ICT',  'IT411 - Capstone 1', 'Prof. Diong', 'Thursday', '15:00:00', '18:00:00'),
('Engineering', 'ENG101 - CAD', 'Prof. Bene', 'Friday', '10:00:00', '13:00:00');

-- MAINTENANCE LOGS
INSERT INTO MaintenanceLogs (EquipmentId, ReportedById, IssueDescription, Status, DateReported, AssignedTechnicianId) VALUES
(5, 5, 'Monitor has severe screen flickering and dead pixels on the left side.', 'Open', DATE_SUB(NOW(), INTERVAL 1 DAY), NULL),
(4, 1, 'PC randomly shuts down during heavy compile loads. Suspect thermal paste or failing PSU.', 'Under Repair', DATE_SUB(NOW(), INTERVAL 3 DAY), 3),
(2, 6, 'Blue screen of death on startup. RAM reseat did not fix it.', 'Resolved', DATE_SUB(NOW(), INTERVAL 10 DAY), 4);

-- MAINTENANCE PARTS (Parts consumed by the resolved ticket)
INSERT INTO MaintenanceParts (LogId, SparePartId, Quantity) VALUES
(3, 1, 1); -- Used 1 stick of 8GB RAM to fix the BSOD

-- PREVENTIVE MAINTENANCE
INSERT INTO PreventiveMaintenance (TargetLocation, EquipmentId, TaskName, Frequency, LastCompleted, NextDueDate, AssignedTo) VALUES
('CLV1', NULL, 'Deep Clean and Dust Removal for all PCs', 'Quarterly', '2026-07-01', '2026-10-01', 3),
('Engineering', 8, 'Calibrate and inspect Crimper blades', 'Annually', '2025-11-15', '2026-11-15', 4),
('ICT', 7, 'Firmware update and port check on Cisco Switch', 'Biannually', NULL, '2026-12-01', 3);

-- BORROW REQUESTS
INSERT INTO BorrowRequests (StudentId, EquipmentId, TargetLocation, Purpose, RequestedDate, StartTime, EndTime, Status) VALUES
(6, NULL, 'CLV1', 'React Native Bootcamp Setup', DATE_ADD(CURDATE(), INTERVAL 2 DAY), '13:00:00', '17:00:00', 'Approved'),
(7, 10, 'Storage', 'Testing cables for networking project', CURDATE(), '09:00:00', '12:00:00', 'Pending'),
(5, 9, 'Engineering', 'Required tool for ENG101 lab activity', CURDATE(), '10:00:00', '13:00:00', 'In Use'),
(5, NULL, 'ICT', 'Overnight hackathon reservation', DATE_SUB(CURDATE(), INTERVAL 5 DAY), '18:00:00', '06:00:00', 'Returned');

-- SPARE PART REQUESTS
INSERT INTO SparePartRequests (TechId, RequestedPartId, Quantity, Reason, Status, RequestDate) VALUES
(3, 5, 200, 'Need massive restock of RJ45 for the upcoming Networking 1 cabling exam.', 'Pending', CURDATE()),
(4, 2, 2, 'Need replacement PSUs for CLV1 units crashing under load.', 'Approved', DATE_SUB(CURDATE(), INTERVAL 2 DAY));

-- 5. CREATE EVENT SCHEDULER TRIGGER (AUTO PURGE)
DROP EVENT IF EXISTS AutoPurgeOldRequests;

DELIMITER $$
CREATE EVENT AutoPurgeOldRequests
ON SCHEDULE EVERY 1 DAY
COMMENT 'Automatically deletes resolved requests older than 90 days'
DO
BEGIN
    DELETE FROM BorrowRequests 
    WHERE Status IN ('Returned', 'Denied') 
    AND RequestedDate < NOW() - INTERVAL 90 DAY;

    DELETE FROM SparePartRequests 
    WHERE Status IN ('Approved', 'Denied') 
    AND RequestDate < NOW() - INTERVAL 90 DAY;
END$$
DELIMITER ;

ALTER TABLE SpareParts ADD IsDeleted TINYINT(1) DEFAULT 0;
