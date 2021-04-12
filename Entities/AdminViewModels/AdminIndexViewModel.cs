using Entities.UtilityModels;
using Entities.Models;
using Entities.ViewModels;
using System.Collections.Generic;

namespace Entities.AdminViewModels
{
    public class AdminIndexViewModel : BaseViewModel
    {
        public List<EmployeeUser> Employees { get; set; }

        public List<StatusColor> StatusColors = StatusColor.GetStatusColors();
    }
}
