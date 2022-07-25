using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eletronic.Models;
using Microsoft.EntityFrameworkCore;

namespace Eletronic.GUI
{
    public partial class ReportGUI : Form
    {
        Electronic_Shop_SystemContext context = new Electronic_Shop_SystemContext();
        public ReportGUI()
        {
            InitializeComponent();
            bind();
        }

        public void bind()
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime toDate = dateTimePicker2.Value;

            Product pro = getNewestProduct();

            if (pro.Image != null)
            {
                pictureBox4.Image = Image.FromStream(new MemoryStream(pro.Image));
            }

            textBox1.Text = pro.Name;

            label1.Text = calToTalProductSell(startDate, toDate) + "";
            label2.Text = calTotalOrder(startDate, toDate) + "";
            label3.Text = "$" + calTotalMoney(startDate, toDate) ;
        }

        public int calToTalProductSell(DateTime fromDate, DateTime toDate)
        {
            int total = 0;

            List<Order> listOrder = context.Orders
                .Include(s => s.OrderDetails)
                .Where(s => s.OrderDate > fromDate && s.OrderDate < toDate).ToList();

            foreach (Order order in listOrder)
            {
                total += order.OrderDetails.Count;
            }

            return total;
        }

        public double calTotalMoney(DateTime fromDate, DateTime toDate)
        {
            double total = 0;

            List<OrderDetail> listOrderDetails = context.OrderDetails
                .Include(s => s.Order)
                .Include(s => s.Product)
                .Where(s => s.Order.OrderDate > fromDate && s.Order.OrderDate < toDate).ToList();

            foreach (OrderDetail orderDetail in listOrderDetails)
            {
                total += orderDetail.Product.SellPrice - orderDetail.Product.Price;
            }

            return total;
        }

        public int calTotalOrder(DateTime fromDate, DateTime toDate)
        {
            int total = 0;

            List<Order> listOrder = context.Orders
                .Include(s => s.OrderDetails)
                .Where(s => s.OrderDate > fromDate && s.OrderDate < toDate && s.DeliverDate != null).ToList();

            total = listOrder.Count;

            return total;
        }

        public Product getNewestProduct()
        {
            Product product = context.Products.OrderBy(s => s.ProductId).Last();
            return product;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            bind();
        }
    }
}
