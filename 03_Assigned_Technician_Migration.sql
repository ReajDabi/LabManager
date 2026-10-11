-- Adds the assigned technician to maintenance tickets in an existing LabManagerDb without dropping data.
-- Run once. Not needed after a fresh run of 01_LabManager_Init_And_Seed.sql, which already includes it.
USE LabManagerDb;

ALTER TABLE MaintenanceLogs
    ADD COLUMN AssignedTechnicianId INT NULL,
    ADD CONSTRAINT FK_MaintenanceLogs_AssignedTechnician
        FOREIGN KEY (AssignedTechnicianId) REFERENCES Users(Id) ON DELETE SET NULL;
