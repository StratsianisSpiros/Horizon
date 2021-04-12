using Entities.Models;
using Entities.ViewModels;

namespace Entities.AdminViewModels
{
    public class AdminDetailsViewModel : BaseViewModel
    {
        public AdminUser AdminUser { get; set; }
        public Company Company { get; set; }
    }
}
