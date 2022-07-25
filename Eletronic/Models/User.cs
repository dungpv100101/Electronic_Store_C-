using System;
using System.Collections.Generic;

#nullable disable

namespace Eletronic.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int IsManager { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public int IsStaff { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
