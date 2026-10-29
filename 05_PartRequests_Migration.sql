USE LabManagerDb;

CREATE TABLE IF NOT EXISTS PartRequests (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    TechnicianId INT NOT NULL,
    PartName VARCHAR(100) NOT NULL,
    Quantity INT NOT NULL,
    Reason TEXT NOT NULL,
    RequestedDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    Status VARCHAR(20) DEFAULT 'Pending',
    FOREIGN KEY (TechnicianId) REFERENCES Users(Id) ON DELETE CASCADE
);

-- Insert a test tech request
INSERT INTO PartRequests (TechnicianId, PartName, Quantity, Reason, Status)
VALUES (
    (SELECT Id FROM Users WHERE Role = 'Technician' LIMIT 1),
'RJ45 Connectors', 50, 'Restocking for network cabling maintenance', 'Pending');