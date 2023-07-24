using System;
using System.Collections.Generic;

#nullable disable

namespace Eletronic.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double Total { get; set; }
        public int StaffId { get; set; }
        public DateTime? DeliverDate { get; set; }

        public virtual User Staff { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
