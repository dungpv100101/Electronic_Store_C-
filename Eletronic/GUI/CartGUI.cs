using Eletronic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eletronic.GUI
{
    public partial class CartGUI : Form
    {
        private const int width = 200;
        private const int height = 242;
        private int pageNumber = 1;
        private int pageSize = 3;
        private double totalPages = 0;

        public CartGUI()
        {
            InitializeComponent();
            bindCartList();
        }

        public void bindCartList(int pageNumber = 1, int pageSize = 3)
        {
            this.Controls.Clear();

            Dictionary<Product, int> dicCartList = Electronic.Cart.listProductInCart;
            
            List<Product> listProduct = dicCartList.Keys.ToList();

            var totalRecords = listProduct.Count;
            totalPages = Math.Ceiling((double)totalRecords / pageSize);

            var skip = (pageNumber - 1) * pageSize;

            listProduct = listProduct.Skip(skip).Take(pageSize).ToList();

            int posX = 30;
            int posY = 50;

            for (int i = 0; i < listProduct.Count; i++)
            {
                Panel panel = initPanelCart(posX + (i * width) + (i * 70), posY, listProduct.ElementAt(i), dicCartList[listProduct.ElementAt(i)]);
                this.Controls.Add(panel);
            }
        }

        public Panel initPanelCart(int posX, int posY, Product product, int quantity)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartGUI));
            Panel panel1 = new System.Windows.Forms.Panel();
            Label labelPrice = new System.Windows.Forms.Label();
            Label labelDescription = new System.Windows.Forms.Label();
            PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();
            Label labelName = new System.Windows.Forms.Label();
            Button button1 = new System.Windows.Forms.Button();
            Button button2 = new System.Windows.Forms.Button();
            Button button3 = new System.Windows.Forms.Button();
            TextBox textBox1 = new System.Windows.Forms.TextBox();
            Button btnPrevious = new System.Windows.Forms.Button();
            Button btnNext = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelPrice);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelDescription);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelName);
            panel1.Location = new System.Drawing.Point(posX, posY);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(197, 289);
            panel1.TabIndex = 8;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            labelPrice.Location = new System.Drawing.Point(8, 253);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(48, 25);
            labelPrice.TabIndex = 5;
            labelPrice.Text = "$" + product.SellPrice * quantity;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelDescription.Location = new System.Drawing.Point(6, 212);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new System.Drawing.Size(177, 17);
            labelDescription.TabIndex = 2;
            labelDescription.Text = product.Description;
            labelDescription.MaximumSize = new Size(190, 0);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(4, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(188, 144);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelName.Location = new System.Drawing.Point(6, 27);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(130, 25);
            labelName.TabIndex = 0;
            labelName.Text = product.Name;
            labelName.MaximumSize = new Size(190, 25);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(165, 5);
            button1.Name = product.ProductId + "";
            button1.Size = new System.Drawing.Size(27, 26);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(106, 256);
            button2.Name = product.ProductId + "";
            button2.Size = new System.Drawing.Size(25, 25);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(160, 254);
            button3.Name = product.ProductId + "";
            button3.Size = new System.Drawing.Size(25, 25);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(133, 256);
            textBox1.Multiline = true;
            textBox1.Name = product.ProductId + "";
            textBox1.Size = new System.Drawing.Size(25, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = quantity + "";
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnPrevious
            // 
            btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrevious.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPrevious.ForeColor = System.Drawing.Color.White;
            btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPrevious.Location = new System.Drawing.Point(355, 358);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new System.Drawing.Size(35, 36);
            btnPrevious.TabIndex = 8;
            btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNext.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNext.ForeColor = System.Drawing.Color.White;
            btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNext.Location = new System.Drawing.Point(410, 358);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(35, 36);
            btnNext.TabIndex = 9;
            btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;

            this.Controls.Add(btnNext);
            this.Controls.Add(btnPrevious);
            return panel1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int productID = Int32.Parse(((Button)sender).Name);
            Electronic.Cart.deleteFromCart(productID);
            ((Form1)(this.Parent.Parent)).cartNumer = Electronic.Cart.listProductInCart.Count;
            bindCartList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Electronic.Cart.addToCart(Int32.Parse(((Button)sender).Name));
            bindCartList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Electronic.Cart.removeFromCart(Int32.Parse(((Button)sender).Name));
            bindCartList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int productID = Int32.Parse(((TextBox)sender).Name);
            Electronic.Cart.setQuantity(productID, Int32.Parse(((TextBox)sender).Text));
            bindCartList();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
                bindCartList(pageNumber, pageSize);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageNumber < totalPages)
            {
                pageNumber++;
                bindCartList(pageNumber, pageSize);
            }
        }
    }
}
