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
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.GUI
{
    public partial class OrderGUI : Form
    {
        private OrderClient orderClient = new OrderClient();
        private OrderDetailClient orderDetailClient = new OrderDetailClient();
        private bool isManage;
        public OrderGUI()
        {
            InitializeComponent();
            panelOrderDetails.Controls.Clear();
            panelOrderList.Controls.Clear();
            panelOrderDetails.AutoScroll = true;
            panelOrderList.AutoScroll = true;
            bindOrderListItem();
        }
        public OrderGUI(bool isManage) : this()
        {
            this.isManage = isManage;
            bindOrderListItem(isManage);
        }
        public void bindOrderListItem(bool isManage = false, string userName = "")
        {
            panelOrderList.Controls.Clear();
            List<Order> listOrder;

            if (isManage)
            {
                listOrder = orderClient.GetListOrder(null, userName);
            } else
            {
                listOrder = orderClient.GetListOrder(Setting.user.StaffId, userName);
            }

            int posX = 3;
            int posY = 3;

            for (int i = 0; i < listOrder.Count; i++)
            {
                Panel panel = new Panel();

                if (i % 2 == 0)
                {
                    posX = 3;

                    panel = initOrderItemPanel(posX, posY, listOrder.ElementAt(i));
                } else
                {
                    posX = 208;

                    panel = initOrderItemPanel(posX, posY, listOrder.ElementAt(i));

                    posY += panel.Height + 9;
                }

                panelOrderList.Controls.Add(panel);
            }
        }

        public void bindOrderDetailsItem(int orderID)
        {
            panelOrderDetails.Controls.Clear();
            List<OrderDetail> listOrderDetails = orderDetailClient.GetListOrderDetail(orderID);

            int posX = 4;
            int posY = 4;

            for (int i = 0; i < listOrderDetails.Count; i++)
            {
                Panel panel = initOrderDetailsItemPanel(posX, posY, listOrderDetails.ElementAt(i));

                posY += 2 + panel.Height;

                panelOrderDetails.Controls.Add(panel);
            }
        }

        public Panel initOrderItemPanel(int posX, int posY, Order order)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderGUI));
            Panel panel1 = new System.Windows.Forms.Panel();
            Panel panel2 = new System.Windows.Forms.Panel();
            Label label4 = new System.Windows.Forms.Label();
            Label label3 = new System.Windows.Forms.Label();
            Label label2 = new System.Windows.Forms.Label();
            Label label1 = new System.Windows.Forms.Label();
            Button btnUploadImage = new System.Windows.Forms.Button();

            // 
            // panel1
            // 
            panel1.Controls.Add(btnUploadImage);
            panel1.Controls.Add(panel2);
            panel1.Location = new System.Drawing.Point(posX, posY);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(165, 105);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = order.OrderId + "";
            panel2.Size = new System.Drawing.Size(165, 82);
            panel2.TabIndex = 0;
            panel2.Click += panel2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            label4.Location = new System.Drawing.Point(88, 60);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = order.DeliverDate == null ? "Not Delivered" : "    Delivered";
            label4.ForeColor = order.DeliverDate == null ? Color.Red : Color.Green;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Blue;
            label3.Location = new System.Drawing.Point(4, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(36, 19);
            label3.TabIndex = 2;
            label3.Text = "$" + order.Total;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(3, 24);
            label2.MaximumSize = new System.Drawing.Size(160, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(159, 30);
            label2.TabIndex = 1;
            label2.Text = order.Address;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(4, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 16);
            label1.TabIndex = 0;
            label1.Text = order.Name;
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            btnUploadImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnUploadImage.FlatAppearance.BorderSize = 0;
            btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUploadImage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUploadImage.ForeColor = System.Drawing.Color.White;
            btnUploadImage.Location = new System.Drawing.Point(0, 81);
            btnUploadImage.Name = order.OrderId + "";
            btnUploadImage.Size = new System.Drawing.Size(165, 24);
            btnUploadImage.TabIndex = 27;
            btnUploadImage.Text = Setting.user.IsManager == 1 ? (order.DeliverDate == null ? "Deliver Now" : order.DeliverDate.ToString()) : (order.DeliverDate == null ? "Not Deliver" : order.DeliverDate.ToString());
            btnUploadImage.UseVisualStyleBackColor = false;
            btnUploadImage.Enabled = order.DeliverDate == null && Setting.user.IsManager == 1;
            btnUploadImage.Click += btnDelivered_Click;

            return panel1;
        }

        public Panel initOrderDetailsItemPanel(int posX, int posY, OrderDetail orderDetails)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderGUI));
            Panel panel5 = new System.Windows.Forms.Panel();
            Label label7 = new System.Windows.Forms.Label();
            Label label6 = new System.Windows.Forms.Label();
            Label label5 = new System.Windows.Forms.Label();
            PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.White;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new System.Drawing.Point(posX, posY);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(294, 67);
            panel5.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.Blue;
            label7.Location = new System.Drawing.Point(225, 21);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(43, 23);
            label7.TabIndex = 4;
            label7.Text = "$" + orderDetails.BuyPrice;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(70, 43);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(28, 17);
            label6.TabIndex = 5;
            label6.Text = "x" + orderDetails.Quantity;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(67, 5);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(115, 16);
            label5.TabIndex = 4;
            label5.Text = orderDetails.Product.Name;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            if (orderDetails.Product.Image != null)
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(orderDetails.Product.Image));
            }
            pictureBox1.Location = new System.Drawing.Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(60, 60);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            return panel5;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            bindOrderDetailsItem(Int32.Parse(((Panel)sender).Name));
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delivered this Order", "!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Button button = (Button)sender;

                orderClient.Delivered(Int32.Parse(button.Name));

                bindOrderListItem(isManage);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindOrderListItem(isManage, textBox1.Text);
        }
    }
}
