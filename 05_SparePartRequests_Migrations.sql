USE LabManagerDb;

CREATE TABLE SparePartRequests (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    TechId INT NOT NULL,
    RequestPartId INT NOT NULL,
    Quantity INT NOT NULL,
    Reason TEXT NOT NULL,
    Status VARCHAR(20) DEFAULT 'Pending',
    RequestDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (TechId) REFERENCES Users(Id) ON DELETE CASCADE,
    FOREIGN KEY (RequestPartId) REFERENCES SpareParts(Id) ON DELETE CASCADE
);


INSERT INTO SparePartRequests (TechId, RequestPartId, Quantity, Reason, Status)
VALUES (
    (SELECT Id FROM Users WHERE Role = 'Technician' LIMIT 1), 
    (SELECT Id FROM SpareParts LIMIT 1), 
    50, 
    'Restocking for network cabling maintenance', 
    'Pending'
);