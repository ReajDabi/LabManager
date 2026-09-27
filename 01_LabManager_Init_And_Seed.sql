
CREATE DATABASE IF NOT EXISTS LabManagerDb;
USE LabManagerDb;

CREATE DATABASE IF NOT EXISTS LabManagerDb;
USE LabManagerDb;


CREATE TABLE Users (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Username VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    Role VARCHAR(30) NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);


CREATE TABLE Equipment (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    AssetTag VARCHAR(50) NOT NULL UNIQUE, 
    Name VARCHAR(100) NOT NULL,           
    Category VARCHAR(50) NOT NULL,        
    Status VARCHAR(50) NOT NULL,          
    StationNumber VARCHAR(20) NULL,       
    DateAcquired DATE NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);


CREATE TABLE MaintenanceLogs (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    EquipmentId INT NOT NULL,
    ReportedById INT NOT NULL,
    IssueDescription TEXT NOT NULL,
    Status VARCHAR(50) NOT NULL,          
    RepairCost DECIMAL(10,2) DEFAULT 0.00, -- Financial tracking
    DateReported DATETIME DEFAULT CURRENT_TIMESTAMP,
    DateResolved DATETIME NULL,
    FOREIGN KEY (EquipmentId) REFERENCES Equipment(Id) ON DELETE CASCADE,
    FOREIGN KEY (ReportedById) REFERENCES Users(Id) ON DELETE RESTRICT
);


CREATE TABLE MaintenanceParts (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    LogId INT NOT NULL,
    SpareEquipmentId INT NOT NULL UNIQUE, -- Unique because a physical spare part can only be used once
    FOREIGN KEY (LogId) REFERENCES MaintenanceLogs(Id) ON DELETE CASCADE,
    FOREIGN KEY (SpareEquipmentId) REFERENCES Equipment(Id) ON DELETE CASCADE
);


CREATE TABLE PreventiveMaintenance (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    EquipmentId INT NOT NULL,
    TaskName VARCHAR(100) NOT NULL,       -- e.g., 'Thermal Paste Replacement'
    FrequencyInDays INT NOT NULL,         -- e.g., 180 for 6 months
    LastCompleted DATE NULL,
    NextDueDate DATE NOT NULL,
    AssignedTo INT NULL,                  -- Which Tech is responsible
    FOREIGN KEY (EquipmentId) REFERENCES Equipment(Id) ON DELETE CASCADE,
    FOREIGN KEY (AssignedTo) REFERENCES Users(Id) ON DELETE SET NULL
);


INSERT INTO Users (Username, PasswordHash, Role) VALUES 
('admin_reaj', '$2a$11$q5MhNJL0Zz/M4z6rJ/R1a.U7.v.Q2/0.1.2.3.4.5.6.7.8.9.0.1.2', 'Admin'),
('tech_chrishian', '$2a$11$q5MhNJL0Zz/M4z6rJ/R1a.U7.v.Q2/0.1.2.3.4.5.6.7.8.9.0.1.2', 'Lab Tech');

INSERT INTO Equipment (AssetTag, Name, Category, Status, StationNumber, DateAcquired) VALUES 
('UM-SYS-001', 'Dell Optiplex 7090', 'System Unit', 'Active', 'PC-01', '2026-01-15'),
('UM-SYS-002', 'Dell Optiplex 7090', 'System Unit', 'Active', 'PC-02', '2026-01-15'),
('UM-MON-001', 'Dell 24 Monitor', 'Monitor', 'Active', 'PC-01', '2026-01-15'),
('UM-SPR-001', 'Kingston 8GB DDR4 RAM', 'Spare Part', 'Spare', NULL, '2026-08-01');

INSERT INTO PreventiveMaintenance (EquipmentId, TaskName, FrequencyInDays, NextDueDate) VALUES 
(1, 'Thermal Paste Replacement', 180, '2026-10-15'),
(2, 'Thermal Paste Replacement', 180, '2026-10-15');




-- Pa run ani sa sql sc

USE LabManagerDb;
SET FOREIGN_KEY_CHECKS = 0;

TRUNCATE TABLE Users;

INSERT INTO Users (Username, PasswordHash, Role) VALUES 
('admin_reaj', 'dummy_hash', 'Admin'),
('tech_chrishian', 'dummy_hash', 'Technician'),
('student_test', 'dummy_hash', 'Student');

SET FOREIGN_KEY_CHECKS = 1;