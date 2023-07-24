using Eletronic.Client;
using Eletronic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Eletronic.GUI
{
    public partial class ShopGUI : Form
    {
        private const int width = 200;
        private const int height = 242;
        private int pageNumber = 1;
        private int pageSize = 3;
        private double totalPages = 0;
        private string productName = "";

        Electronic_Shop_SystemContext context = new Electronic_Shop_SystemContext();
        public ShopGUI()
        {
            InitializeComponent();
            bindListProduct();

            //List<ProductType> productTypes = context.ProductTypes.ToList();
            List<ProductType> productTypes = new ProductTypeClient().GetListProductType();

            comboCategory.Items.Insert(0, "All");
            foreach (ProductType productType in productTypes)
            {
                comboCategory.Items.Add(productType.ProductTypeName);
            }
            comboCategory.SelectedIndex = 0;
        }

        public async void bindListProduct(int pageNumber = 1, int pageSize = 3, string productName = "", int categoryID = 0)
        {
            panelListProduct.Controls.Clear();

            List<Product> listProduct = new ProductClient().GetListProduct(pageNumber, pageSize, productName, categoryID).Result;

            var totalRecords = listProduct.Count;
            totalPages = Math.Ceiling((double)totalRecords / pageSize);

            var skip = (pageNumber - 1) * pageSize;

            listProduct = listProduct.Skip(skip).Take(pageSize).ToList();

            int posX = 30;
            int posY = 3;

            for (int i = 0; i < listProduct.Count; i++)
            {
                Panel panel = initProductPanel(posX + (i * width) + (i * 70), posY, listProduct.ElementAt(i));
                panelListProduct.Controls.Add(panel);
            }
        }

        public Panel initProductPanel(int posX, int posY, Product product)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopGUI));
            Label labelName = new System.Windows.Forms.Label();
            Label labelPrice = new System.Windows.Forms.Label();
            Button button1 = new System.Windows.Forms.Button();
            Label labelDescription = new System.Windows.Forms.Label();
            PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();
            Panel panel1 = new System.Windows.Forms.Panel();
            Button btnPrevious = new System.Windows.Forms.Button();
            Button btnNext = new System.Windows.Forms.Button();
            TextBox textBox1 = new System.Windows.Forms.TextBox();
            Panel panel2 = new System.Windows.Forms.Panel();
            Button button2 = new System.Windows.Forms.Button();
            Panel panel4 = new System.Windows.Forms.Panel();
            Panel panel5 = new System.Windows.Forms.Panel();
            Panel panel3 = new System.Windows.Forms.Panel();
            ComboBox comboCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            panel1.SuspendLayout();
            this.SuspendLayout();
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
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            labelPrice.Location = new System.Drawing.Point(8, 253);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(48, 25);
            labelPrice.TabIndex = 5;
            labelPrice.Text = "$" + product.SellPrice;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(84, 254);
            button1.Name = product.ProductId + "";
            button1.Size = new System.Drawing.Size(107, 26);
            button1.TabIndex = 4;
            button1.Text = "Add To Cart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

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
            if (product.Image != null)
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(product.Image));
            }
            else
                pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(3, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(188, 144);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            panel1.Controls.Add(labelPrice);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelDescription);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(labelName);
            panel1.Location = new System.Drawing.Point(posX, posY);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(197, 289);
            panel1.TabIndex = 7;
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
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.Control;
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(7, 6);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Product Name";
            textBox1.Size = new System.Drawing.Size(207, 19);
            textBox1.TabIndex = 10;
            textBox1.Text = productName;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.Control;
            panel2.Controls.Add(textBox1);
            panel2.Location = new System.Drawing.Point(564, 3);
            panel2.Name = "panel2";
            panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 7);
            panel2.Size = new System.Drawing.Size(224, 32);
            panel2.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Location = new System.Drawing.Point(530, 5);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(32, 32);
            button2.TabIndex = 11;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.Red;
            panel3.Location = new System.Drawing.Point(564, 36);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(224, 2);
            panel3.TabIndex = 12;
            // 
            // comboCategory
            // 
            comboCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            comboCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboCategory.FormattingEnabled = true;
            comboCategory.Location = new System.Drawing.Point(0, 0);
            comboCategory.Name = "comboCategory";
            comboCategory.Size = new System.Drawing.Size(198, 29);
            comboCategory.TabIndex = 0;
            comboCategory.SelectedIndexChanged += comboCategory_SelectedIndexChanged;
            
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.Red;
            panel4.Location = new System.Drawing.Point(298, 35);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(198, 2);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.SystemColors.Control;
            panel5.Controls.Add(comboCategory);
            panel5.Location = new System.Drawing.Point(298, 3);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(198, 32);
            panel5.TabIndex = 15;
            // 
            // Shop
            // 
            this.Controls.Add(button2);
            this.Controls.Add(btnNext);
            this.Controls.Add(btnPrevious);

            return panel1;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
                bindListProduct(pageNumber, pageSize, textBox1.Text, comboCategory.SelectedIndex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageNumber < totalPages)
            {
                pageNumber++;
                bindListProduct(pageNumber, pageSize, textBox1.Text, comboCategory.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindListProduct(pageNumber, pageSize, productName);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            productName = ((TextBox)sender).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = context.Products.Find(Int32.Parse(((Button)sender).Name));
            Electronic.Cart.addToCart(product);

            ((Form1)(this.Parent.Parent)).cartNumer = Electronic.Cart.listProductInCart.Count;
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            bindListProduct(1, 3, textBox1.Text, comboBox.SelectedIndex);
        }
    }

}
