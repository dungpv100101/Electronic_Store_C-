using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Eletronic.Models;

namespace Eletronic.GUI
{
    public partial class AddCategoryGUI : Form
    {
        private Electronic_Shop_SystemContext context = new Electronic_Shop_SystemContext();
        public AddCategoryGUI()
        {
            InitializeComponent();
        }

        private void txtCategoryName_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                label1.Text = "*Category must not empty.";
                label1.ForeColor = Color.Red;
                btnAddCategory.Enabled = false;
            } else if (checkCategoryExist(txtCategoryName.Text))
            {
                label1.Text = "*Category name existing.";
                label1.ForeColor = Color.Red;
                btnAddCategory.Enabled = false;
            } else
            {
                label1.Text = "*You can use this category name.";
                label1.ForeColor = Color.Green;
                btnAddCategory.Enabled = true;
            }
        }

        private bool checkCategoryExist(string categoryName)
        {
            if (context.ProductTypes.Where(s => s.ProductTypeName == categoryName).Count() > 0)
            {
                return true;
            }

            return false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (label1.ForeColor != Color.Red)
            {
                ProductType productType = new ProductType()
                {
                    ProductTypeName = txtCategoryName.Text
                };

                context.ProductTypes.Add(productType);
                context.SaveChanges();
                this.Close();
            }
        }
    }
}
