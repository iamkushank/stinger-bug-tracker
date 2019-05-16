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

        private void textBoxPidSearch_Enter(object sender, EventArgs e)
        {
            String searchProjectid = textBoxPidSearch.Text;
            if (searchProjectid.ToLower().Trim().Equals("project id"))
            {
                textBoxPidSearch.Text = "";
                textBoxPidSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxPidSearch_Leave(object sender, EventArgs e)
        {
            String searchProjectid = textBoxPidSearch.Text;
            if (searchProjectid.ToLower().Trim().Equals("project id") || searchProjectid.Trim().Equals(""))
            {
                textBoxPidSearch.Text = "project id";
                textBoxPidSearch.ForeColor = Color.Gray;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool res = pc.ManageProjects(0, textBoxProject.Text, dtpStartdate.Text, dtpEnddate.Text, txtRichDescription.Text, 1);
            if (res == true)
            {
                MessageBox.Show("A new project successfully added!!");
            }
            else
            {
                MessageBox.Show("Failed to add project!!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool res = pc.ManageProjects(Int32.Parse(textBoxPidSearch.Text), textBoxProject.Text, dtpStartdate.Text, dtpEnddate.Text, txtRichDescription.Text, 2);
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
            bool res = pc.ManageProjects(Int32.Parse(textBoxPidSearch.Text), textBoxProject.Text, dtpStartdate.Text, dtpEnddate.Text, txtRichDescription.Text, 3);
            if (res == true)
            {
                MessageBox.Show("Successfully deleted the project!!");
            }
            else
            {
                MessageBox.Show("Failed to delete the project!!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
