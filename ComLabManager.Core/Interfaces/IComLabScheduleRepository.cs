using System.Collections.Generic;
using ComLabManager.Core.Models;

namespace ComLabManager.Core.Interfaces
{
    public interface IComLabScheduleRepository
    {
        IEnumerable<UnifiedScheduleDto> GetUnifiedComLabSchedules();

       
        IEnumerable<ComLabSchedule> GetAllSchedules();
        void AddSchedule(ComLabSchedule schedule);
        void UpdateSchedule(ComLabSchedule schedule);
        void DeleteSchedule(int id);
    }
}