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
using Eletronic.Client;
using Eletronic.DTO;

namespace DataAccess.GUI
{
    public partial class LoginGUI : Form
    {
        private AuthClient authClient = new AuthClient();
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            User user = null;

            try
            {
                user = authClient.Login(new LoginDTO() { username = userName, password = password });
            } catch { }

            if (user == null)
            {
                label1.Text = "*User name or Password not corret";
                this.DialogResult = DialogResult.None;
            } else
            {
                Setting.user = user;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new RegisterGUI();
            f.Show();
        }
    }
}
