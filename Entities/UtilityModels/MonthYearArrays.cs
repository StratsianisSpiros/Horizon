using System;

namespace Entities.UtilityModels
{
    public class MonthYearArrays
    {
        public static int[] Month = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        public static int[] Year = new int[] { DateTime.Now.Year, DateTime.Now.Year - 1 };
    }
}
