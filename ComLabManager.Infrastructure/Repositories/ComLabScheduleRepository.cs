using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using ComLabManager.Core.Interfaces;
using ComLabManager.Core.Models;

namespace ComLabManager.Infrastructure.Repositories
{
    public class ComLabScheduleRepository : IComLabScheduleRepository
    {
        private readonly string _connectionString;

        public ComLabScheduleRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public IEnumerable<UnifiedScheduleDto> GetUnifiedComLabSchedules()
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = @"
            SELECT 
                ComLabName, 
                SubjectCode AS Subject, 
                InstructorName AS Instructor, 
                DayOfWeek, 
                StartTime, 
                EndTime,
                'Class' AS BookingType
            FROM ComLabSchedules
            
            UNION ALL
            
            SELECT 
                br.TargetLocation AS ComLabName, 
                br.Purpose AS Subject, 
                u.Username AS Instructor, 
                DAYNAME(br.RequestedDate) AS DayOfWeek, 
                br.StartTime, 
                br.EndTime,
                'Reservation' AS BookingType
            FROM BorrowRequests br
            JOIN Users u ON br.StudentId = u.Id
            WHERE br.Status = 'Approved'
            
            ORDER BY FIELD(DayOfWeek, 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'), StartTime;
        ";

                return db.Query<UnifiedScheduleDto>(sql).ToList();
            }
        }
    }
}