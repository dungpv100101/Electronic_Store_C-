using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Client;
using DataAccess.Models;

namespace DataAccess.GUI
{
    public partial class UserMangeGUI : Form
    {
        private UserClient userClient = new UserClient();
        public UserMangeGUI()
        {
            InitializeComponent();
            bindUserList("");
        }

        public void bindUserList(string userName)
        {
            panelUserList.Controls.Clear();
            //List<User> listUser = context.Users.Where(s => s.IsManager != 1 && s.Name.Contains(userName)).ToList();
            List<User> listUser = userClient.GetListUser(userName);

            int posX = 3;
            int posY = 3;

            int count = 1;

            for (int i = 0; i < listUser.Count; i++)
            {
                Panel panel = new Panel();
                panel = initUserPanelItem(posX, posY, listUser.ElementAt(i));
                panelUserList.Controls.Add(panel);
                

                if (count < 4)
                {
                    posX += panel.Width + 15;
                }
                else
                {
                    posY += 142;
                    posX = 3;
                    count = 0;
                }

                count++;
            }
        }

        public Panel initUserPanelItem(int posX, int posY, User user)
        {
            Panel panel1 = new System.Windows.Forms.Panel();
            Button btnDelivered = new System.Windows.Forms.Button();
            Panel panel2 = new System.Windows.Forms.Panel();
            Label label4 = new System.Windows.Forms.Label();
            Label label3 = new System.Windows.Forms.Label();
            Label label2 = new System.Windows.Forms.Label();
            Label label1 = new System.Windows.Forms.Label();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelivered);
            panel1.Controls.Add(panel2);
            panel1.Location = new System.Drawing.Point(posX, posY);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(165, 126);
            panel1.TabIndex = 0;
            // 
            // btnDelivered
            // 
            btnDelivered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            btnDelivered.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnDelivered.FlatAppearance.BorderSize = 0;
            btnDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelivered.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelivered.ForeColor = System.Drawing.Color.White;
            btnDelivered.Location = new System.Drawing.Point(0, 102);
            btnDelivered.Name = user.StaffId + "";
            btnDelivered.Size = new System.Drawing.Size(165, 24);
            btnDelivered.TabIndex = 27;
            btnDelivered.Text = user.IsStaff == 1 ? "Set To User" : "Set To Staff";
            btnDelivered.UseVisualStyleBackColor = false;
            btnDelivered.Click += btnSetToStaffOrUser_Click;
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
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(165, 103);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            label4.Location = new System.Drawing.Point(103, 76);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "      " + (user.IsStaff == 1 ? "Staff" : "User");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Blue;
            label3.Location = new System.Drawing.Point(4, 74);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 17);
            label3.TabIndex = 2;
            label3.Text = user.Phone;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(3, 32);
            label2.MaximumSize = new System.Drawing.Size(160, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(159, 30);
            label2.TabIndex = 1;
            label2.Text = user.Address;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(4, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 16);
            label1.TabIndex = 0;
            label1.Text = user.Name;

            return panel1;
        }

        public void btnSetToStaffOrUser_Click(object sender, EventArgs e)
        {
            Button btn = ((Button)sender);
            int userID = Int32.Parse(btn.Name);
            if (btn.Text == "Set To User")
            {
                if (MessageBox.Show("Do you really want to set to user", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //context.Users.Find(userID).IsStaff = 0;
                    userClient.SetStaff(userID, 0);
                }
            } else
            {
                if (MessageBox.Show("Do you really want to set to staff", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //context.Users.Find(userID).IsStaff = 1;
                    userClient.SetStaff(userID, 1);
                }
            }
            
            //context.SaveChanges();
            bindUserList("");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindUserList(txtUesrName.Text);
        }
    }
}
