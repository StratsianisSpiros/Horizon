using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class AdminIndexViewModel : BaseViewModel
    {
        public List<EmployeeUser> Employees { get; set; }
    }
}
