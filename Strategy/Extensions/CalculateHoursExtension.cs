using Entities.Models;

namespace Strategy.Extensions
{
    //This extension calculates the working hours of an employee event
    internal static class CalculateHoursExtension
    {
        /// <summary>
        /// Extension method to calculate working hour from an <see cref="EmployeeEvent"/>
        /// </summary>
        /// <param name="employeeEvent"></param>
        /// <returns></returns>
        internal static decimal CalculateWorkHours(this EmployeeEvent employeeEvent)
        {
            double startHour = employeeEvent.Start.Value.Hour != 0 ? employeeEvent.Start.Value.Hour : 24;
            double endHour = employeeEvent.End.Value.Hour != 0 ? employeeEvent.End.Value.Hour : 24;
            double startMinutes = employeeEvent.Start.Value.Minute;
            double endMinutes = employeeEvent.End.Value.Minute;

            return startHour < endHour ? (decimal)(endHour - startHour - startMinutes + endMinutes)
                                 : (decimal)((24 - startHour) + endHour - startMinutes + endMinutes);
        }
    }
}
