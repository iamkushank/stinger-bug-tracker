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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool res = uc.ManageUser(0, textBoxFirstname.Text, textBoxlastname.Text, textBoxUsername.Text, textBoxPassword.Text, comboBoxRole.Text, 1);
            if (res == true)
            {
                MessageBox.Show("User add successfully!!");
            }
            else
            {
                MessageBox.Show("User added failed!!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool res = uc.ManageUser(Int32.Parse(textBoxSearch.Text), textBoxFirstname.Text, textBoxlastname.Text, textBoxUsername.Text, textBoxPassword.Text, comboBoxRole.Text, 2);
            if (res == true)
            {
                MessageBox.Show("User updated successfully!!");
            }
            else
            {
                MessageBox.Show("User updated failed!!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool res = uc.ManageUser(Int32.Parse(textBoxSearch.Text), textBoxFirstname.Text, textBoxlastname.Text, textBoxUsername.Text, textBoxPassword.Text, comboBoxRole.Text, 3);
            if (res == true)
            {
                MessageBox.Show("User deleted successfully!!");
            }
            else
            {
                MessageBox.Show("User delete failed!!");
            }
        }
    }
}
