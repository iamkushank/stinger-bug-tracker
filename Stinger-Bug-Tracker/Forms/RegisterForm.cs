using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AccessClassLibrary;

namespace Stinger_Bug_Tracker
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Remove focus from the textboxes
            this.ActiveControl = label1;
        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            String fname = textBoxFirstName.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                textBoxFirstName.Text = "";
                textBoxFirstName.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            String fname = textBoxFirstName.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                textBoxFirstName.Text = "first name";
                textBoxFirstName.ForeColor = Color.Gray;
            }
        }

        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
            String lname = textBoxLastName.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                textBoxLastName.Text = "";
                textBoxLastName.ForeColor = Color.Black;
            }
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            String lname = textBoxLastName.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                textBoxLastName.Text = "last name";
                textBoxLastName.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email address"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email address") || email.Trim().Equals(""))
            {
                textBoxEmail.Text = "email address";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxUserName_Enter(object sender, EventArgs e)
        {
            String username = textBoxUserName.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = Color.Black;
            }
        }

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            String username = textBoxUserName.Text;
            if (username.ToLower().Trim().Equals("username") || username.Trim().Equals(""))
            {
                textBoxUserName.Text = "username";
                textBoxUserName.ForeColor = Color.Gray;
            }
        }

        private void comboBoxRole_Enter(object sender, EventArgs e)
        {
            String role = comboBoxRole.Text;
            if (role.ToLower().Trim().Equals("role"))
            {
                comboBoxRole.Text = "";
                comboBoxRole.ForeColor = Color.Black;
            }
        }

        private void comboBoxRole_Leave(object sender, EventArgs e)
        {
            String role = comboBoxRole.Text;
            if (role.ToLower().Trim().Equals("role") || role.Trim().Equals(""))
            {
                comboBoxRole.Text = "role";
                comboBoxRole.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                textBoxPassword.Text = "password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxPasswordConfirm_Enter(object sender, EventArgs e)
        {
            String cpassword = textBoxPasswordConfirm.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password"))
            {
                textBoxPasswordConfirm.Text = "";
                textBoxPasswordConfirm.UseSystemPasswordChar = true;
                textBoxPasswordConfirm.ForeColor = Color.Black;
            }
        }

        private void textBoxPasswordConfirm_Leave(object sender, EventArgs e)
        {
            String cpassword = textBoxPasswordConfirm.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password") || cpassword.Trim().Equals(""))
            {
                textBoxPasswordConfirm.Text = "confirm password";
                textBoxPasswordConfirm.UseSystemPasswordChar = false;
                textBoxPasswordConfirm.ForeColor = Color.Gray;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            // add new users
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `members`(`firstname`, `lastname`, `emailaddress`, `username`, `password`, `role`) VALUES (@fn, @ln, @email, @usn, @pass, @role)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxFirstName.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxLastName.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUserName.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = comboBoxRole.Text;

            // open the connection
            db.openConnection();

            // check if the textboxes contains the default values
            if(!checkTextBoxesValues())
            {

                // check if the password equals to the confirmed password
                if(textBoxPassword.Text.Equals(textBoxPasswordConfirm.Text))
                {
                    // check if this username already exists
                    if (checkUsername())
                    {
                        MessageBox.Show("This username already exists, please choose a different name","Duplicate username!!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    }
                    else
                    {
                        // execute the querry
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your account has successfully been created","Account created!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please match the passwords correctly","Password Error!!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all the required information","Empty Data!!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }

            // close the connection
            db.closeConnection();
        }

        // check if the username already exits
        public Boolean checkUsername()
        {
            DB db = new DB();
            String username = textBoxUserName.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `members` WHERE `username` = @usn", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            // check if this username already exists in the database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // check if the textboxes contains the default values
        public Boolean checkTextBoxesValues()
        {
            String fname = textBoxFirstName.Text;
            String lname = textBoxLastName.Text;
            String email = textBoxEmail.Text;
            String uname = textBoxUserName.Text;
            String pass = textBoxPassword.Text;
            String role = comboBoxRole.Text;

            if (fname.Equals("first name") || lname.Equals("last name") || email.Equals("email address") || uname.Equals("username") || pass.Equals("password") || role.Equals("role"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void labelGoToLogIn_MouseEnter(object sender, EventArgs e)
        {
            labelGoToLogIn.ForeColor = Color.Yellow;
        }

        private void labelGoToLogIn_MouseLeave(object sender, EventArgs e)
        {
            labelGoToLogIn.ForeColor = Color.White;
        }

        private void labelGoToLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }
    }
}
