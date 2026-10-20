-- 1. Turn on the MySQL Event Scheduler (Required for events to run)
SET GLOBAL event_scheduler = ON;

USE LabManagerDb;

-- Clean up the event if you ever need to recreate or modify it
DROP EVENT IF EXISTS AutoPurgeOldRequests;

-- 2. Create the daily automated purge event
DELIMITER $$

CREATE EVENT AutoPurgeOldRequests
ON SCHEDULE EVERY 1 DAY
COMMENT 'Automatically deletes resolved requests older than 90 days'
DO
BEGIN
    -- Purge old Student Borrow Requests
    DELETE FROM BorrowRequests 
    WHERE Status IN ('Approved', 'Denied') 
    AND RequestedDate < NOW() - INTERVAL 90 DAY;

    -- Purge old Technician Spare Part Requests
    DELETE FROM SparePartRequests 
    WHERE Status IN ('Approved', 'Denied') 
    AND RequestDate < NOW() - INTERVAL 90 DAY;
END$$

DELIMITER ;