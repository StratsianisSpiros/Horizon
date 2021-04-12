using Entities.Models;

namespace Strategy.Interfaces
{
    internal interface IPayment
    {
        Payment MakePayment(EmployeeUser user, int month, int year);
    }
}
