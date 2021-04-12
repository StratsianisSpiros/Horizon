using Entities.Models;
using System.Collections.Generic;

namespace Entities.ViewModels
{
    public class DashBoardViewModel : BaseViewModel
    {
        public ICollection<Post> Posts { get; set; }
    }
}
