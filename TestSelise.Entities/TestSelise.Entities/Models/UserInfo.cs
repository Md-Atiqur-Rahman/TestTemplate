using System;
using System.Collections.Generic;

#nullable disable

namespace TestSelise.Entities.Models
{
    public partial class UserInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PasswordSalt { get; set; }
        public string HashPassword { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
