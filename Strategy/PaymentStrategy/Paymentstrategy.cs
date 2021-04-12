using Entities.Models;
using Entities.UtilityModels;
using Strategy.Interfaces;

namespace Strategy.PaymentStrategy
{
    //This class contains the methods to set an initialize payment strategy
    public class PaymentStrategy
    {
        private IPayment _payment;

        /// <summary>
        /// Sets payment strategy of <see cref="PaymentStrategy"/> option given the user payment method
        /// </summary>
        /// <param name="payMethod"></param>
        public void SetPaymentStrategy(PayMethod payMethod)
        {
            switch (payMethod)
            {
                case PayMethod.Hour: _payment = new HourPayment();
                    break;
                case PayMethod.Day: _payment = new DayPayment();
                    break;
                case PayMethod.Month: _payment = new MonthPayment();
                    break;
                case PayMethod.Year: _payment = new YearPayment();
                    break;
                default: _payment = new DayPayment();
                    break;
            }
        }

        /// <summary>
        /// Calculates a payment for an <see cref="EmployeeUser"/> given the user object, month and year
        /// </summary>
        /// <param name="user"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns><see cref="Payment"/></returns>
        public Payment MakePayment(EmployeeUser user, int month, int year)
        {
            return _payment.MakePayment(user, month, year);
        }
    }
}
