using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int AddressId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Address Address { get; set; }
    }
}
