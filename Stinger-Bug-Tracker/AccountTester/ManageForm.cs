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
    public partial class ManageForm : Form
    {
        UserClass uc = new UserClass();
        public ManageForm()
        {
            InitializeComponent();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            String searchUserid = textBoxUidSearch.Text;
            if (searchUserid.ToLower().Trim().Equals("member id"))
            {
                textBoxUidSearch.Text = "";
                textBoxUidSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            String searchUserid = textBoxUidSearch.Text;
            if (searchUserid.ToLower().Trim().Equals("member id") || searchUserid.Trim().Equals(""))
            {
                textBoxUidSearch.Text = "member id";
                textBoxUidSearch.ForeColor = Color.Gray;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool res = uc.ManageUser(0, textBoxFirstname.Text, textBoxlastname.Text, textBoxUsername.Text, textBoxPassword.Text, comboBoxRole.Text, 1);
            if (res == true)
            {
                MessageBox.Show("A new user successfully added!!");
            }
            else
            {
                MessageBox.Show("Failed to add user!!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool res = uc.ManageUser(Int32.Parse(textBoxUidSearch.Text), textBoxFirstname.Text, textBoxlastname.Text, textBoxUsername.Text, textBoxPassword.Text, comboBoxRole.Text, 2);
            if (res == true)
            {
                MessageBox.Show("Update successful!!");
            }
            else
            {
                MessageBox.Show("Update failed!!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool res = uc.ManageUser(Int32.Parse(textBoxUidSearch.Text), textBoxFirstname.Text, textBoxlastname.Text, textBoxUsername.Text, textBoxPassword.Text, comboBoxRole.Text, 3);
            if (res == true)
            {
                MessageBox.Show("Successfully deleted the user!!");
            }
            else
            {
                MessageBox.Show("Failed to delete the user!!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}