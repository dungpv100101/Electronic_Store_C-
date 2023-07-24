using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class ProductDTO
    {
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
    }
}
