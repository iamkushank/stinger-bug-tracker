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
    public partial class ProjectForm : Form
    {
        ProjectClass pc = new ProjectClass();
        public ProjectForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool res = pc.ManageProjects(0, textBoxProject.Text, dtpStartdate.Text, dtpEnddate.Text, txtRichDescription.Text, 1);
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
            bool res = pc.ManageProjects(Int32.Parse(textBoxProjectid.Text), textBoxProject.Text, dtpStartdate.Text, dtpEnddate.Text, txtRichDescription.Text, 2);
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
            bool res = pc.ManageProjects(Int32.Parse(textBoxProjectid.Text), textBoxProject.Text, dtpStartdate.Text, dtpEnddate.Text, txtRichDescription.Text, 3);
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
    }
}
