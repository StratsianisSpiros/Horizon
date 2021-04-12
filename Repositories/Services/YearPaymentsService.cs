using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Services
{
    public class YearPaymentsService
    {
        //This method intents to assign payments of one year to be accessed at view
        public static Payment[] YearPaymentsByMonth(IEnumerable<Payment> filteredPayments)
        {
            var payments = new Payment[13];

            for (int i = 0; i < payments.Length; i++)
            {
                payments[i] = new Payment() { PaymentId = 0 };
            }

            foreach (var payment in filteredPayments)
            {
                payments[payment.Month] = payment;
            }

            return payments;
        }
    }
}
