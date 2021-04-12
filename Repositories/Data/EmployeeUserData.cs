using Entities.Models;
using Entities.UtilityModels;
using System;
using System.Collections.Generic;

namespace Repositories.Data
{
    public class EmployeeUserData
    {
        private List<EmployeeUser> EmployeeUsers = new List<EmployeeUser>
        {
            //// COMPANY 1
            new EmployeeUser{ UserName = "Steinbeck", CompanyId = 1, CompanyName = "Sunset Corporation" ,
                            FirstName = "John", LastName = "Steinbeck", PayMethod = PayMethod.Hour,
                            Address = "1950 Bryan Avenue", PhoneNumber = "0128963144", HireDate = new DateTime(2018, 04, 12),
                            IsAdmin = false, PayRate = 12m, OverTimeRate = 18, TaxRate = TaxRates.Mid,
                            AvatarUrl = "~/EmployeeAvatars/JohnSteinbeck.png" },

            new EmployeeUser{ UserName = "Orwell", CompanyId = 1, CompanyName = "Sunset Corporation" ,
                            FirstName= "George", LastName = "Orwell", PayMethod = PayMethod.Hour,
                            Address= "4701 Driftwood Road", PhoneNumber = "0123344174", HireDate = new DateTime(2016, 07, 07), 
                            IsAdmin = false, PayRate = 10.5m, OverTimeRate = 14.5m, TaxRate = TaxRates.Mid,
                            AvatarUrl = "~/EmployeeAvatars/GeorgeOrwell.png" },

            new EmployeeUser{ UserName = "Hemingway", CompanyId = 1, CompanyName = "Sunset Corporation" ,
                            FirstName = "Ernest", LastName = "Hemingway", PayMethod = PayMethod.Day, 
                            Address = "3792 Wildwood Street", PhoneNumber = "0127852369", HireDate = new DateTime(2020, 12, 05),
                            IsAdmin = false, PayRate = 50, OverTimeRate = 11, TaxRate = TaxRates.Mid,
                            AvatarUrl = "~/EmployeeAvatars/ErnestHemingway.png" },

            new EmployeeUser{ UserName = "SPlath", CompanyId = 1, CompanyName = "Sunset Corporation" ,
                            FirstName = "Sylvia", LastName = "Plath", PayMethod = PayMethod.Month,
                            Address = "221B Baker Street", PhoneNumber = "0129852147", HireDate = new DateTime(2017, 08 ,09), 
                            IsAdmin = false, PayRate = 1600, OverTimeRate = 10.5m, TaxRate = TaxRates.High,
                            AvatarUrl = "~/EmployeeAvatars/SylviaPlath.png" },

            new EmployeeUser{ UserName = "Beauvoir", CompanyId = 1, CompanyName = "Sunset Corporation" ,
                            FirstName = "Simone", LastName = "Beauvoir", PayMethod = PayMethod.Year, 
                            Address = "39 Balsham Road", PhoneNumber = "0129632147", HireDate = new DateTime(2013, 06, 12), 
                            IsAdmin = false, PayRate = 25000, OverTimeRate = 9, TaxRate = TaxRates.High,
                            AvatarUrl = "~/EmployeeAvatars/SimonedeBeauvoir.png" },
        };

        internal static List<EmployeeUser> GetData() => new EmployeeUserData().EmployeeUsers;
    }
}
