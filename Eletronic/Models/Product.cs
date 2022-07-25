using System;
using System.Collections.Generic;

#nullable disable

namespace Eletronic.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Useguide { get; set; }
        public string ProduceCountry { get; set; }
        public double Price { get; set; }
        public double SellPrice { get; set; }
        public int Quantity { get; set; }
        public byte[] Image { get; set; }

        public virtual ProductType ProductType { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
