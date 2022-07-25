using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Eletronic.Models;

namespace Eletronic.GUI
{
    public partial class AddProductGUI : Form
    {
        private Electronic_Shop_SystemContext context = new Electronic_Shop_SystemContext();
        public AddProductGUI()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            comboCategory.DataSource = context.ProductTypes.ToList();
            comboCategory.DisplayMember = "ProductTypeName";
            comboCategory.ValueMember = "ProductTypeID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] image = GetImage();

                Product product = new Product()
                {
                    ProductTypeId = (int)comboCategory.SelectedValue,
                    Name = txtProductName.Text,
                    Description = txtDesccription.Text,
                    Useguide = txtGuide.Text,
                    ProduceCountry = txtCountry.Text,
                    Price = double.Parse(txtPrice.Text),
                    SellPrice = double.Parse(txtSellPrice.Text),
                    Image = image
                };

                context.Products.Add(product);
                context.SaveChanges();
            }
            catch
            {

            }

            label1.Text = "*Save product successfully.";
            label1.ForeColor = Color.Green;
        }

        private byte[] GetImage()
        {
            byte[] imgByte;

            using (MemoryStream mStream = new MemoryStream())
            {
                pictureBox1.Image.Save(mStream, pictureBox1.Image.RawFormat);
                imgByte = mStream.ToArray();
            }

            return imgByte;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sFile = openFileDialog1.FileName;
                pictureBox1.Image = System.Drawing.Bitmap.FromFile(sFile);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (object panel in this.Controls)
            {
                if (panel is Panel)
                {
                    foreach (object textBox in ((Panel)panel).Controls)
                    {
                        if (textBox is TextBox)
                        {
                            ((TextBox)textBox).Clear();
                        }
                    }
                }
            }
        }

        private void txtCheckNumber_KeyUp(object sender, KeyEventArgs e)
        {
            if (!double.TryParse(((TextBox)sender).Text, out _))
            {
                ((TextBox)sender).Text = "";
            }
        }

    }
}
