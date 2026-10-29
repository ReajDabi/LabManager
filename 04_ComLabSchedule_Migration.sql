-- Creates the ComLabSchedules table to track room availability in an existing LabManagerDb.
-- Includes initial seed data for testing the Student Dashboard ComLab Schedules view.

USE LabManagerDb;

CREATE TABLE IF NOT EXISTS ComLabSchedules (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    ComLabName VARCHAR(50) NOT NULL,
    SubjectCode VARCHAR(50) NOT NULL,
    InstructorName VARCHAR(100) NOT NULL,
    DayOfWeek VARCHAR(20) NOT NULL,
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL
);

-- Insert initial seed data for the ComLab Schedules grid
INSERT INTO ComLabSchedules (ComLabName, SubjectCode, InstructorName, DayOfWeek, StartTime, EndTime)
VALUES 
('CLV1', 'IT3 - Networking 1', 'Prof. Sin', 'Monday', '08:00:00', '11:00:00'),
('CLV1', 'IT311 - Web Systems', 'Prof. Shian', 'Wednesday', '13:00:00', '16:00:00'),
('CLV2', 'IT111 - Programming', 'Prof. Limbar', 'Tuesday', '09:00:00', '12:00:00'),
('ICT',  'IT411 - Capstone', 'Prof. Diong', 'Thursday', '15:00:00', '18:00:00'),
('Engineering', 'ENG101 - CAD', 'Prof. Bene', 'Friday', '10:00:00', '13:00:00');