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

        public IEnumerable<ComLabSchedule> GetAllSchedules()
        {
            using (IDbConnection db = new MySqlConnection(_connectionString))
            {
                string sql = @"SELECT * FROM ComLabSchedules 
                               ORDER BY FIELD(DayOfWeek, 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'), StartTime";

                return db.Query<ComLabSchedule>(sql).ToList();
            }
        }
    }
}