using Entities.Models;
using System.Collections.Generic;

namespace Entities.ViewModels
{
    public class RequestViewModel : BaseViewModel
    {
        public IEnumerable<Request> Requests { get; set; }
    }
}