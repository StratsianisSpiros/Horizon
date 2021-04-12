using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace Repositories.Data
{
    public class IdentityRoleData
    {
        private List<IdentityRole> Roles = new List<IdentityRole>
        {
            new IdentityRole { Id = "1", Name = "Admin"},
            new IdentityRole { Id = "2", Name = "Employee"}
        };

        internal static List<IdentityRole> GetData() => new IdentityRoleData().Roles;
    }
}
