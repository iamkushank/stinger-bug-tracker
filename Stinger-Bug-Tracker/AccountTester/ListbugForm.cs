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
    public partial class ListbugForm : Form
    {
        ProjectClass pc = new ProjectClass();
        BugClass bc = new BugClass();
        FixbugClass fbc = new FixbugClass();

        public ListbugForm()
        {
            InitializeComponent();
        }

        private void textBoxProjectid_Enter(object sender, EventArgs e)
        {
            String searchPid = textBoxProjectid.Text;
            if (searchPid.ToLower().Trim().Equals("project id"))
            {
                textBoxProjectid.Text = "";
                textBoxProjectid.ForeColor = Color.Black;
            }
        }

        private void textBoxProjectid_Leave(object sender, EventArgs e)
        {
            String searchPid = textBoxProjectid.Text;
            if (searchPid.ToLower().Trim().Equals("project id") || searchPid.Trim().Equals(""))
            {
                textBoxProjectid.Text = "project id";
                textBoxProjectid.ForeColor = Color.Gray;
            }
        }

        private void textBoxBugid_Enter(object sender, EventArgs e)
        {
            String searchBid = textBoxBugid.Text;
            if (searchBid.ToLower().Trim().Equals("bug id"))
            {
                textBoxBugid.Text = "";
                textBoxBugid.ForeColor = Color.Black;
            }
        }

        private void textBoxBugid_Leave(object sender, EventArgs e)
        {
            String searchBid = textBoxBugid.Text;
            if (searchBid.ToLower().Trim().Equals("bug id") || searchBid.Trim().Equals(""))
            {
                textBoxBugid.Text = "bug id";
                textBoxBugid.ForeColor = Color.Gray;
            }
        }

        private void textBoxSolutionid_Enter(object sender, EventArgs e)
        {
            String searchSid = textBoxSolutionid.Text;
            if (searchSid.ToLower().Trim().Equals("solution id"))
            {
                textBoxSolutionid.Text = "";
                textBoxSolutionid.ForeColor = Color.Black;
            }
        }

        private void textBoxSolutionid_Leave(object sender, EventArgs e)
        {
            String searchSid = textBoxSolutionid.Text;
            if (searchSid.ToLower().Trim().Equals("solution id") || searchSid.Trim().Equals(""))
            {
                textBoxSolutionid.Text = "solution id";
                textBoxSolutionid.ForeColor = Color.Gray;
            }
        }

        private void buttonProjectid_Click(object sender, EventArgs e)
        {
            dataGridViewList.DataSource = pc.getallprojectbyid(Int32.Parse(textBoxProjectid.Text));
        }

        private void buttonBugid_Click(object sender, EventArgs e)
        {
            dataGridViewList.DataSource = bc.getallbugbyid(Int32.Parse(textBoxBugid.Text));
        }

        private void buttonSolutionid_Click(object sender, EventArgs e)
        {
            dataGridViewList.DataSource = fbc.getallsolutionbyid(Int32.Parse(textBoxSolutionid.Text));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
