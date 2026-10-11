-- Adds the Maintenance Task Board tables to an existing LabManagerDb without dropping data.
-- Not needed after a fresh run of 01_LabManager_Init_And_Seed.sql, which already includes these.
USE LabManagerDb;

CREATE TABLE IF NOT EXISTS SpareParts (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL UNIQUE,
    Category VARCHAR(50) NULL,
    Quantity INT NOT NULL DEFAULT 0,
    UnitPrice DECIMAL(10,2) NOT NULL DEFAULT 0
);

CREATE TABLE IF NOT EXISTS MaintenanceParts (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    LogId INT NOT NULL,
    SparePartId INT NOT NULL,
    Quantity INT NOT NULL DEFAULT 1,
    FOREIGN KEY (LogId) REFERENCES MaintenanceLogs(Id) ON DELETE CASCADE,
    FOREIGN KEY (SparePartId) REFERENCES SpareParts(Id) ON DELETE RESTRICT
);

INSERT IGNORE INTO Equipment (AssetTag, Name, Category, Status, StationNumber, DateAcquired) VALUES
('UM-SYS-001', 'Dell OptiPlex 7010', 'System Unit', 'Active', 'CLV1-01', '2023-06-15'),
('UM-SYS-002', 'Dell OptiPlex 7010', 'System Unit', 'Active', 'CLV1-02', '2023-06-15'),
('UM-MON-001', 'Acer 24" Monitor', 'Monitor', 'Active', 'CLV1-01', '2023-06-15'),
('UM-PER-001', 'Logitech K120 Keyboard', 'Peripheral', 'Active', 'CLV1-01', '2024-01-10'),
('UM-NET-001', 'TP-Link 24-Port Switch', 'Networking', 'Active', NULL, '2022-09-01');

INSERT IGNORE INTO SpareParts (Name, Category, Quantity, UnitPrice) VALUES
('8GB DDR4 RAM', 'Memory', 10, 1500.00),
('500W Power Supply', 'Power', 5, 2200.00),
('256GB SATA SSD', 'Storage', 8, 1800.00),
('CMOS Battery CR2032', 'Power', 20, 50.00),
('HDMI Cable', 'Cable', 0, 250.00);
