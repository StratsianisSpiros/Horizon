using Entities.Models;
using System.Collections.Generic;

namespace Repositories.Data
{
    public class AdminUserData
    {
        private Dictionary<AdminUser, string> AdminUsers = new Dictionary<AdminUser, string>
        {
         //// COMPANY 1
            { new AdminUser{ UserName = "admin@hotmail.com", FirstName = "Admin", LastName = "Admin",
                CompanyId = 1, CompanyName = "Sunset Corporation" , IsAdmin = true, Email = "admin@hotmail.com",
                PhoneNumber = "6955840123", SubsciptionStatus = "Free Plan" }, "!23admiN"}
        };

      internal static Dictionary<AdminUser, string> GetData() => new AdminUserData().AdminUsers;
    }
}
