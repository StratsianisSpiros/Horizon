using Entities.Models;
using System.Collections.Generic;

namespace Repositories.Data
{
    public class CompanyData
    {
        private List<Company> Companies = new List<Company>
        {
            new Company{ CompanyId = 1, CompanyName = "Sunset Corporation", CompanyAddress = "Patision & Paramithiou",
                CompanyPhone = "7654678909", LogoUrl = "~/CompanyLogo/horizon.jpg"},
        };

        internal static List<Company> GetData() => new CompanyData().Companies;
    }
}
