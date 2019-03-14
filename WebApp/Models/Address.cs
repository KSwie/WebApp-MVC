using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class Address
    {
        public Address()
        {
            Users = new HashSet<Users>();
        }

        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
