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
using DataAccess.Client;
using DataAccess.DTO;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.GUI
{
    public partial class ReportGUI : Form
    {
        private ReportClient reportClient = new ReportClient();
        public ReportGUI()
        {
            InitializeComponent();
            bind();
        }

        public void bind()
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime toDate = dateTimePicker2.Value;

            ReportDTO reportDTO = reportClient.GetReportData(startDate, toDate);

            ProductDTO pro = reportDTO.NewestProduct;

            if (pro.Image != null)
            {
                try
                {
                    pictureBox4.Image = Image.FromStream(new MemoryStream(pro.Image));
                } catch(Exception ex) { }
            }

            textBox1.Text = pro.Name;

            label1.Text = reportDTO.TotalProductSell + "";
            label2.Text = reportDTO.TotalOrder + "";
            label3.Text = "$" + reportDTO.TotalMoney;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            bind();
        }
    }
}
