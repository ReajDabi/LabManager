CREATE DATABASE IF NOT EXISTS LabManagerDb;
USE LabManagerDb;

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
    Status VARCHAR(50) NOT NULL,          
    StationNumber VARCHAR(20) NULL,       
    UsageCount INT DEFAULT 0,             
    DateAcquired DATE NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE MaintenanceLogs (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    EquipmentId INT NOT NULL,
    ReportedById INT NOT NULL,
    IssueDescription TEXT NOT NULL,
    Status VARCHAR(50) NOT NULL,          
    DateReported DATETIME DEFAULT CURRENT_TIMESTAMP,
    DateResolved DATETIME NULL,
    AssignedTechnicianId INT NULL,        
    FOREIGN KEY (EquipmentId) REFERENCES Equipment(Id) ON DELETE CASCADE,
    FOREIGN KEY (ReportedById) REFERENCES Users(Id) ON DELETE RESTRICT,
    FOREIGN KEY (AssignedTechnicianId) REFERENCES Users(Id) ON DELETE SET NULL
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
    Status VARCHAR(30) DEFAULT 'Pending', 
    RequestDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (TechId) REFERENCES Users(Id) ON DELETE CASCADE,
    FOREIGN KEY (RequestedPartId) REFERENCES Equipment(Id) ON DELETE CASCADE
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
    Status VARCHAR(30) DEFAULT 'Pending', 
    FOREIGN KEY (StudentId) REFERENCES Users(Id) ON DELETE CASCADE,
    FOREIGN KEY (EquipmentId) REFERENCES Equipment(Id) ON DELETE CASCADE
);

CREATE TABLE SpareParts (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL UNIQUE,
    Category VARCHAR(50) NULL,
    Quantity INT NOT NULL DEFAULT 0,
    RestockLevel INT NOT NULL DEFAULT 5 
);

CREATE TABLE MaintenanceParts (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    LogId INT NOT NULL,
    SparePartId INT NOT NULL,
    Quantity INT NOT NULL DEFAULT 1,
    FOREIGN KEY (LogId) REFERENCES MaintenanceLogs(Id) ON DELETE CASCADE,
    FOREIGN KEY (SparePartId) REFERENCES SpareParts(Id) ON DELETE RESTRICT
);

SET FOREIGN_KEY_CHECKS = 1;


INSERT INTO Users (Username, PasswordHash, Role, FirstName, LastName) VALUES 
('admin_reaj', '$2a$11$1ehfe4lt7rMOq7iwX1YGDOor6P/BrzxXLVqmX9x7xn1xdt8Wmqery', 'Admin', 'Reajzedrik', 'Dabi'),
('tech_chrishian', '$2a$11$1ehfe4lt7rMOq7iwX1YGDOor6P/BrzxXLVqmX9x7xn1xdt8Wmqery', 'Technician', 'Chrishian', 'Degaom'),
('student_test', '$2a$11$1ehfe4lt7rMOq7iwX1YGDOor6P/BrzxXLVqmX9x7xn1xdt8Wmqery', 'Student', 'Test', 'Student');

INSERT INTO Equipment (AssetTag, Name, Category, Status, StationNumber, DateAcquired) VALUES
('UM-SYS-001', 'Dell OptiPlex 7010', 'System Unit', 'Active', 'CLV1-01', '2023-06-15'),
('UM-SYS-002', 'Dell OptiPlex 7010', 'System Unit', 'Active', 'CLV1-02', '2023-06-15'),
('UM-MON-001', 'Acer 24" Monitor', 'Monitor', 'Active', 'CLV1-01', '2023-06-15'),
('UM-PER-001', 'Logitech K120 Keyboard', 'Peripheral', 'Active', 'CLV1-01', '2024-01-10'),
('UM-NET-001', 'TP-Link 24-Port Switch', 'Networking', 'Active', NULL, '2022-09-01');

INSERT INTO SpareParts (Name, Category, Quantity, RestockLevel) VALUES
('8GB DDR4 RAM', 'Memory', 10, 5),
('500W Power Supply', 'Power', 5, 5),
('256GB SATA SSD', 'Storage', 8, 5),
('CMOS Battery CR2032', 'Power', 20, 10),
('HDMI Cable', 'Cable', 0, 5);