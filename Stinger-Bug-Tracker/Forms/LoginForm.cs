using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessClassLibrary;

namespace Stinger_Bug_Tracker
{
    public partial class LoginForm : Form
    {
        UserClass uc = new UserClass();
        public LoginForm()
        {
            InitializeComponent();

            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 50);
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //DB db = new DB();
            //NewMethod(db);

            string role = uc.RoleBaseLogin(textBoxUsername.Text, textBoxPassword.Text);

            if (role == "Admin")
            {
                this.Hide();
                DashboardTester dashboard = new DashboardTester();
                dashboard.Show();

                MessageBox.Show("Welecome Admin!!", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (role == "Programmer")
            {
                this.Hide();
                DashboardTester dashboard = new DashboardTester();
                dashboard.buttonManage.Enabled = false;
                dashboard.Show();

                MessageBox.Show("Welecome Programmer!!", "A coder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (role == "Tester (default)")
            {
                this.Hide();
                DashboardTester dashboard = new DashboardTester();
                dashboard.buttonManage.Enabled = false;
                dashboard.buttonProject.Enabled = false;
                dashboard.buttonFixBug.Enabled = false;
                dashboard.Show();

                MessageBox.Show("Welecome Tester!!", "A default user", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String username = textBoxUsername.Text;
                String password = textBoxPassword.Text;

                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your username to login", "Empty username!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your password to login", "Empty password!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Wrong data!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void labelGoToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void labelGoToSignUp_MouseEnter(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.Yellow;
        }

        private void labelGoToSignUp_MouseLeave(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.White;
        }
    }
}
