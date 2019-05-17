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
                MessageBox.Show("Successfully launched a new project!!", "New Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to launch the project!!", "Launching failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool res = pc.ManageProjects(Int32.Parse(textBoxPidSearch.Text), textBoxProject.Text, dtpStartdate.Text, dtpEnddate.Text, txtRichDescription.Text, 2);
            if (res == true)
            {
                MessageBox.Show("Successfully updated the project!!", "Update successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update the project!!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool res = pc.ManageProjects(Int32.Parse(textBoxPidSearch.Text), textBoxProject.Text, dtpStartdate.Text, dtpEnddate.Text, txtRichDescription.Text, 3);
            if (res == true)
            {
                MessageBox.Show("Successfully deleted the project!!", "Deleting successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to delete the project!!", "Deleting failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = pc.getallprojectbyid(Convert.ToInt32(textBoxPidSearch.Text));
            textBoxProject.Text = dt.Rows[0]["projectname"].ToString();
            dtpStartdate.Text = dt.Rows[0]["startdate"].ToString();
            dtpEnddate.Text = dt.Rows[0]["enddate"].ToString();
            txtRichDescription.Text = dt.Rows[0]["description"].ToString();
        }
    }
}
