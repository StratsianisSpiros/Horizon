using Entities.Models;
using System.Collections.Generic;

namespace Entities.StatisticsViewModels
{
    public class YearPaymentsViewModel
    {
        public List<decimal> YearTotalPayments { get; set; }
        public List<decimal> YearOverTimePayments { get; set; }
        public List<decimal> YearNormalPayments { get; set; }
        public string[] MonthNames { get; set; }
    }
}
