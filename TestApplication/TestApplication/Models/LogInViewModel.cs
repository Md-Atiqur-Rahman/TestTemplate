using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class LogInViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string HashPassword { get; set; }
    }
}
