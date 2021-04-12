using System.Collections.Generic;

namespace Entities.StatisticsViewModels
{
    public class CompanyAttendanceViewModel
    {
        public List<int> TotalWorkDays { get; set; }
        public List<int> TotalAbsentDays { get; set; }
        public List<int> TotalHolidays { get; set; }
        public List<string> EmployeeNames { get; set; }
    }
}
