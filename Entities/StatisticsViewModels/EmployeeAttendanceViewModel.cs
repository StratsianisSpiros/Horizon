
namespace Entities.StatisticsViewModels
{
    public class EmployeeAttendanceViewModel
    {
        public int WorkDays { get; set; }
        public  int AbsentDays { get; set; }
        public int Holidays { get; set; }
        public int[] Months { get; set; }
        public string Month { get; set; }
    }
}
