using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public string Content { get; set; }
        public string Response { get; set; }
        public DateTime? RequestDate { get; set; }
        public string Username { get; set; }
        public bool AskRequest { get; set; }

    }
}
