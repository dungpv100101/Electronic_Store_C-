using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Models;
using System.Text.RegularExpressions;
using DataAccess.Client;

namespace DataAccess.GUI
{
    public partial class RegisterGUI : Form
    {
        private UserClient userClient = new UserClient();   
        public RegisterGUI()
        {
            InitializeComponent();
            this.BringToFront();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string text = checkInput();

            if (text == "")
            {
                User user = new User()
                {
                    Account = txtUserName.Text,
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Password = txtPassword.Text,
                    IsManager = 0,
                    IsStaff = 0
                };

                
                //context.Users.Add(user);

                if (userClient.Add(user))
                {
                    MessageBox.Show("Register successfully. Please log in", "Register", MessageBoxButtons.OK);
                    this.Close();
                }
            } else
            {
                label2.Text = text;
                return;
            }
        }

        private string checkInput()
        {
            if (txtUserName.Text.Length < 1)
            {
                return "Please enter user name";
            }

            if (txtPassword.Text.Length < 1)
            {
                return "Please enter password";
            }

            if (txtRepassword.Text.Length < 1)
            {
                return "Please enter re-password";
            }

            if (txtRepassword.Text != txtPassword.Text)
            {
                return "Password and Re-password not match";
            }

            if (!Regex.IsMatch(txtUserName.Text, "[A-Za-z]"))
            {
                return "User name contains only characters from a-z";
            }

            if (txtPassword.Text.Length < 8)
            {
                return "Pass word must greater 8 character";
            }

            return "";
        }
    }
}
