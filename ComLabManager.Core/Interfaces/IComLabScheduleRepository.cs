using ComLabManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComLabManager.Core.Interfaces
{
    public interface IComLabScheduleRepository
    {
        IEnumerable<ComLabSchedule> GetAllSchedules();
    }
}
