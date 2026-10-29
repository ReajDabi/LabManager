using System;

namespace ComLabManager.Core.Models
{
    // The single rule for how often a preventive maintenance task repeats
    public static class PmFrequency
    {
        public static readonly string[] All = { "Weekly", "Monthly", "Quarterly", "Biannually", "Annually" };

        // The next due date is always counted from a given day (today, or the day the task was last done)
        public static DateTime NextDueDate(DateTime from, string frequency)
        {
            DateTime day = from.Date;

            return frequency switch
            {
                "Weekly" => day.AddDays(7),
                "Monthly" => day.AddMonths(1),
                "Quarterly" => day.AddMonths(3),
                "Biannually" => day.AddMonths(6),
                "Annually" => day.AddYears(1),
                _ => day.AddMonths(1)
            };
        }
    }
}
