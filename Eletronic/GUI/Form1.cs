using System;
using System.Linq;
using System.Windows.Forms;
using DataAccess.Client;
using DataAccess.GUI;
using DataAccess.Models;
using Eletronic.Client;

namespace DataAccess
{
    public partial class Form1 : Form
    {
        private const int btnHeight = 54;
        private const int btnChildHeight = 33;
        private OrderClient orderClient = new OrderClient();
        private OrderDetailClient orderDetailClient = new OrderDetailClient();
        private AuthClient authClient = new AuthClient();
        public int cartNumer
        {
            get
            {
                return Int32.Parse(btnCart.Text);
            }
            set
            {
                btnCart.Text = value + "";
            }
        }
        public Form1()
        {
            InitializeComponent();

            HomeGUI home = new HomeGUI() { TopLevel = false };
            home.Show();
            panelMain.Controls.Add(home);

            if (!(Setting.user != null && Setting.user.IsManager == 1))
            {
                btnManager.Hide();
            }

            btnReport.Hide();
            MinimizedNav();
            SetPosNav();
        }

        private void MinimizedNav()
        {
            panelShop.Height = btnHeight;
            panelCart.Height = btnHeight;
            panelOrder.Height = btnHeight;
        }

        private void SetPosNav()
        {
            panelShop.Top = btnHome.Bottom;
            panelCart.Top = panelShop.Bottom;
            panelOrder.Top = panelCart.Bottom;
            btnManager.Top = panelOrder.Bottom;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Minimize All Nav
            MinimizedNav();
            SetPosNav();

            panelMark.Height = btnHome.Height;
            panelMark.Top = btnHome.Top;

            HomeGUI home = new HomeGUI() { TopLevel = false };
            home.Show();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(home);
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            MinimizedNav();

            if (Setting.user != null && (Setting.user.IsManager == 1 || Setting.user.IsStaff == 1))
            {
                panelShop.Height = 2 * btnChildHeight + btnShop.Height;
            }

            SetPosNav();

            panelMark.Height = panelShop.Height;
            panelMark.Top = panelShop.Top;

            ShopGUI shop = new ShopGUI() { TopLevel = false };
            shop.Show();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(shop);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            MinimizedNav();

            panelCart.Height = 1 * btnChildHeight + btnCartNav.Height;

            SetPosNav();

            panelMark.Height = panelCart.Height;
            panelMark.Top = panelCart.Top;

            Form f = new CartGUI();
            f.TopLevel = false;
            f.Show();

            panelMain.Controls.Clear();
            panelMain.Controls.Add(f);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MinimizedNav();

            if (Setting.user == null)
            {
                MessageBox.Show("You are not login.", "Error");
                return;
            }

            if (Setting.user != null && (Setting.user.IsManager == 1 || Setting.user.IsStaff == 1))
            {
                panelOrder.Height = 1 * btnChildHeight + btnOrder.Height;
            }

            SetPosNav();

            panelMark.Height = panelOrder.Height;
            panelMark.Top = panelOrder.Top;

            Form f = new OrderGUI(false);
            f.TopLevel = false;
            f.Show();

            panelMain.Controls.Clear();
            panelMain.Controls.Add(f);
        }

        private void btnAllOrder_Click(object sender, EventArgs e)
        {
            Form f = new OrderGUI(true);
            f.TopLevel = false;
            f.Show();

            panelMain.Controls.Clear();
            panelMain.Controls.Add(f);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Setting.user != null)
            {
                Setting.user = null;
                btnLogin.Text = "      Login";
                authClient.Logout();


                MinimizedNav();
                SetPosNav();

                panelMark.Height = panelShop.Height;
                panelMark.Top = panelShop.Top;

                btnReport.Hide();
                btnManager.Hide();
            }
            else
            {
                Form f = new LoginGUI();
                f.StartPosition = FormStartPosition.CenterParent;

                if (f.ShowDialog() == DialogResult.OK)
                {
                    btnLogin.Text = "      " + Setting.user.Name;
                    if (Setting.user.IsManager == 1)
                    {
                        btnManager.Show();
                    }

                    if (Setting.user.IsManager == 1 || Setting.user.IsStaff == 1)
                    {
                        btnReport.Show();
                    }
                }
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (Electronic.Cart.listProductInCart.Count == 0)
            {
                MessageBox.Show("Empty Cart");
                return;
            }

            if (Setting.user == null)
            {
                MessageBox.Show("Please Log In first.");
                return;
            }

            if (MessageBox.Show("Do you want to checkout ?", "Check Out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                User user = Setting.user;

                double totalPrice = Electronic.Cart.getTotalPrice();

                Order order = new Order()
                {
                    OrderDate = DateTime.Now,
                    Name = user.Name,
                    Address = user.Address,
                    Phone = user.Phone,
                    Total = totalPrice,
                    StaffId = user.StaffId
                };

                orderClient.Add(order);

                foreach (Product pro in Electronic.Cart.listProductInCart.Keys)
                {
                    OrderDetail orderDetails = new OrderDetail()
                    {
                        ProductId = pro.ProductId,
                        Quantity = Electronic.Cart.listProductInCart[pro],
                        BuyPrice = pro.SellPrice * Electronic.Cart.listProductInCart[pro],
                        //OrderId = context.Orders.ToList().ElementAt(context.Orders.Count() - 1).OrderId
                        OrderId = orderClient.GetListOrder(null, null).Last().OrderId
                    };

                    orderDetailClient.Add(orderDetails);
                }

                Electronic.Cart.listProductInCart.Clear();
                btnCart_Click(null, null);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Form f = new AddProductGUI() { TopLevel = false };
            f.Show();

            panelMain.Controls.Clear();
            panelMain.Controls.Add(f);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Form f = new AddCategoryGUI();
            f.Show();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            Form f = new UserMangeGUI() { TopLevel = false };
            f.Show();

            panelMain.Controls.Clear();
            panelMain.Controls.Add(f);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Form f = new ReportGUI() { TopLevel = false };
            f.Show();

            panelMain.Controls.Clear();
            panelMain.Controls.Add(f);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
