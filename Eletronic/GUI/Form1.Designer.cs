
namespace DataAccess
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new System.Windows.Forms.Panel();
            panelOrder = new System.Windows.Forms.Panel();
            btnAllOrder = new System.Windows.Forms.Button();
            btnOrder = new System.Windows.Forms.Button();
            panelShop = new System.Windows.Forms.Panel();
            btnCategory = new System.Windows.Forms.Button();
            btnAddProduct = new System.Windows.Forms.Button();
            btnShop = new System.Windows.Forms.Button();
            panelCart = new System.Windows.Forms.Panel();
            btnCheckout = new System.Windows.Forms.Button();
            btnCartNav = new System.Windows.Forms.Button();
            panelMark = new System.Windows.Forms.Panel();
            btnReport = new System.Windows.Forms.Button();
            btnManager = new System.Windows.Forms.Button();
            btnLogin = new System.Windows.Forms.Button();
            btnHome = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnQuit = new System.Windows.Forms.Button();
            btnHide = new System.Windows.Forms.Button();
            panelMain = new System.Windows.Forms.Panel();
            btnCart = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panelOrder.SuspendLayout();
            panelShop.SuspendLayout();
            panelCart.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(panelOrder);
            panel1.Controls.Add(panelShop);
            panel1.Controls.Add(panelCart);
            panel1.Controls.Add(panelMark);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(btnManager);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnHome);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(160, 548);
            panel1.TabIndex = 0;
            // 
            // panelOrder
            // 
            panelOrder.Controls.Add(btnAllOrder);
            panelOrder.Controls.Add(btnOrder);
            panelOrder.Location = new System.Drawing.Point(8, 373);
            panelOrder.Name = "panelOrder";
            panelOrder.Size = new System.Drawing.Size(152, 93);
            panelOrder.TabIndex = 5;
            // 
            // btnAllOrder
            // 
            btnAllOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnAllOrder.FlatAppearance.BorderSize = 0;
            btnAllOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAllOrder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAllOrder.ForeColor = System.Drawing.Color.White;
            btnAllOrder.Image = (System.Drawing.Image)resources.GetObject("btnAllOrder.Image");
            btnAllOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAllOrder.Location = new System.Drawing.Point(22, 54);
            btnAllOrder.Name = "btnAllOrder";
            btnAllOrder.Size = new System.Drawing.Size(130, 33);
            btnAllOrder.TabIndex = 0;
            btnAllOrder.Text = "      All Order";
            btnAllOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAllOrder.UseVisualStyleBackColor = true;
            btnAllOrder.Click += btnAllOrder_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOrder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOrder.ForeColor = System.Drawing.Color.White;
            btnOrder.Image = (System.Drawing.Image)resources.GetObject("btnOrder.Image");
            btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnOrder.Location = new System.Drawing.Point(0, 0);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new System.Drawing.Size(152, 54);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "      Order";
            btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // panelShop
            // 
            panelShop.Controls.Add(btnCategory);
            panelShop.Controls.Add(btnAddProduct);
            panelShop.Controls.Add(btnShop);
            panelShop.Location = new System.Drawing.Point(8, 153);
            panelShop.Name = "panelShop";
            panelShop.Size = new System.Drawing.Size(152, 124);
            panelShop.TabIndex = 5;
            // 
            // btnCategory
            // 
            btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCategory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCategory.ForeColor = System.Drawing.Color.White;
            btnCategory.Image = (System.Drawing.Image)resources.GetObject("btnCategory.Image");
            btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCategory.Location = new System.Drawing.Point(22, 87);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new System.Drawing.Size(130, 33);
            btnCategory.TabIndex = 0;
            btnCategory.Text = "      Category";
            btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAddProduct.ForeColor = System.Drawing.Color.White;
            btnAddProduct.Image = (System.Drawing.Image)resources.GetObject("btnAddProduct.Image");
            btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAddProduct.Location = new System.Drawing.Point(22, 54);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new System.Drawing.Size(130, 33);
            btnAddProduct.TabIndex = 0;
            btnAddProduct.Text = "      Product";
            btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnShop
            // 
            btnShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnShop.FlatAppearance.BorderSize = 0;
            btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnShop.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnShop.ForeColor = System.Drawing.Color.White;
            btnShop.Image = (System.Drawing.Image)resources.GetObject("btnShop.Image");
            btnShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnShop.Location = new System.Drawing.Point(0, 0);
            btnShop.Name = "btnShop";
            btnShop.Size = new System.Drawing.Size(152, 54);
            btnShop.TabIndex = 0;
            btnShop.Text = "      Shop";
            btnShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnShop.UseVisualStyleBackColor = true;
            btnShop.Click += btnShop_Click;
            // 
            // panelCart
            // 
            panelCart.Controls.Add(btnCheckout);
            panelCart.Controls.Add(btnCartNav);
            panelCart.Location = new System.Drawing.Point(8, 279);
            panelCart.Name = "panelCart";
            panelCart.Size = new System.Drawing.Size(152, 92);
            panelCart.TabIndex = 4;
            // 
            // btnCheckout
            // 
            btnCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCheckout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCheckout.ForeColor = System.Drawing.Color.White;
            btnCheckout.Image = (System.Drawing.Image)resources.GetObject("btnCheckout.Image");
            btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCheckout.Location = new System.Drawing.Point(22, 54);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new System.Drawing.Size(130, 33);
            btnCheckout.TabIndex = 0;
            btnCheckout.Text = "      Checkout";
            btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnCartNav
            // 
            btnCartNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnCartNav.FlatAppearance.BorderSize = 0;
            btnCartNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCartNav.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCartNav.ForeColor = System.Drawing.Color.White;
            btnCartNav.Image = (System.Drawing.Image)resources.GetObject("btnCartNav.Image");
            btnCartNav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCartNav.Location = new System.Drawing.Point(0, 0);
            btnCartNav.Name = "btnCartNav";
            btnCartNav.Size = new System.Drawing.Size(152, 54);
            btnCartNav.TabIndex = 0;
            btnCartNav.Text = "      Cart";
            btnCartNav.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCartNav.UseVisualStyleBackColor = true;
            btnCartNav.Click += btnCart_Click;
            // 
            // panelMark
            // 
            panelMark.BackColor = System.Drawing.Color.FromArgb(178, 8, 55);
            panelMark.Location = new System.Drawing.Point(0, 97);
            panelMark.Name = "panelMark";
            panelMark.Size = new System.Drawing.Size(8, 54);
            panelMark.TabIndex = 3;
            // 
            // btnReport
            // 
            btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReport.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnReport.ForeColor = System.Drawing.Color.White;
            btnReport.Image = (System.Drawing.Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnReport.Location = new System.Drawing.Point(8, 491);
            btnReport.Name = "btnReport";
            btnReport.Size = new System.Drawing.Size(152, 54);
            btnReport.TabIndex = 0;
            btnReport.Text = "      Report";
            btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnManager
            // 
            btnManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnManager.FlatAppearance.BorderSize = 0;
            btnManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnManager.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnManager.ForeColor = System.Drawing.Color.White;
            btnManager.Image = (System.Drawing.Image)resources.GetObject("btnManager.Image");
            btnManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnManager.Location = new System.Drawing.Point(8, 466);
            btnManager.Name = "btnManager";
            btnManager.Size = new System.Drawing.Size(152, 54);
            btnManager.TabIndex = 0;
            btnManager.Text = "      Manager";
            btnManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnManager.UseVisualStyleBackColor = true;
            btnManager.Click += btnManager_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Image = (System.Drawing.Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogin.Location = new System.Drawing.Point(8, 0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(152, 54);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "      Login";
            btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnHome
            // 
            btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnHome.ForeColor = System.Drawing.Color.White;
            btnHome.Image = (System.Drawing.Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHome.Location = new System.Drawing.Point(8, 97);
            btnHome.Name = "btnHome";
            btnHome.Size = new System.Drawing.Size(152, 54);
            btnHome.TabIndex = 0;
            btnHome.Text = "      Home";
            btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(178, 8, 55);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(160, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(800, 10);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(178, 8, 55);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new System.Drawing.Point(222, -1);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(116, 146);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(13, 123);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 16);
            label2.TabIndex = 2;
            label2.Text = "Store";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(11, 103);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 19);
            label1.TabIndex = 1;
            label1.Text = "Electronic";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(15, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(70, 70);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnQuit
            // 
            btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnQuit.FlatAppearance.BorderSize = 0;
            btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnQuit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnQuit.ForeColor = System.Drawing.Color.White;
            btnQuit.Image = (System.Drawing.Image)resources.GetObject("btnQuit.Image");
            btnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnQuit.Location = new System.Drawing.Point(913, 16);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new System.Drawing.Size(35, 36);
            btnQuit.TabIndex = 0;
            btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnHide
            // 
            btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHide.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnHide.ForeColor = System.Drawing.Color.White;
            btnHide.Image = (System.Drawing.Image)resources.GetObject("btnHide.Image");
            btnHide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHide.Location = new System.Drawing.Point(872, 16);
            btnHide.Name = "btnHide";
            btnHide.Size = new System.Drawing.Size(35, 36);
            btnHide.TabIndex = 0;
            btnHide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // panelMain
            // 
            panelMain.Location = new System.Drawing.Point(160, 151);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(800, 397);
            panelMain.TabIndex = 3;
            // 
            // btnCart
            // 
            btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCart.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCart.ForeColor = System.Drawing.Color.Gray;
            btnCart.Image = (System.Drawing.Image)resources.GetObject("btnCart.Image");
            btnCart.Location = new System.Drawing.Point(853, 97);
            btnCart.Name = "btnCart";
            btnCart.Size = new System.Drawing.Size(95, 36);
            btnCart.TabIndex = 4;
            btnCart.Text = "0";
            btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += btnCart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(344, 17);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(411, 22);
            label3.TabIndex = 5;
            label3.Text = "SE1609 - Group 13 - Electronic Store - Project";
            label3.Click += label3_Click;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.Gray;
            panel4.Location = new System.Drawing.Point(160, 149);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(800, 2);
            panel4.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(960, 548);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(btnCart);
            Controls.Add(panelMain);
            Controls.Add(panel3);
            Controls.Add(btnHide);
            Controls.Add(btnQuit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panelOrder.ResumeLayout(false);
            panelShop.ResumeLayout(false);
            panelCart.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMark;
        private System.Windows.Forms.Button btnCartNav;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Panel panelShop;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Button btnAllOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnReport;
    }
}

