using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.DTO
{
    public class ReportDTO
    {
        public int TotalProductSell { get; set; }
        public int TotalOrder { get; set; }
        public double TotalMoney { get; set; }
        public ProductDTO NewestProduct { get; set; } = null;
    }
}
