using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stinger_Bug_Tracker
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        About about;
        private void aboutTheApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new About();
                about.MdiParent = this;
                about.FormClosed += about_FormClosed;
                about.Show();
            }
            else
            {
                about.Activate();
            }
        }

        void about_FormClosed(object sender, FormClosedEventArgs e)
        {
            about = null;
            //throw new NotImplementedException();
        }

        aboutAddbug aab;
        private void addBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aab == null)
            {
                aab = new aboutAddbug();
                aab.MdiParent = this;
                aab.FormClosed += aab_FormClosed;
                aab.Show();
            }
            else
            {
                aab.Activate();
            }
        }

        void aab_FormClosed(object sender, FormClosedEventArgs e)
        {
            aab = null;
            //throw new NotImplementedException();
        }

        aboutListbug alb;
        private void listBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alb == null)
            {
                alb = new aboutListbug();
                alb.MdiParent = this;
                alb.FormClosed += alb_FormClosed;
                alb.Show();
            }
            else
            {
                alb.Activate();
            }
        }

        void alb_FormClosed(object sender, FormClosedEventArgs e)
        {
            alb = null;
            //throw new NotImplementedException();
        }

        aboutFixbug afb;
        private void fixBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (afb == null)
            {
                afb = new aboutFixbug();
                afb.MdiParent = this;
                afb.FormClosed += afb_FormClosed;
                afb.Show();
            }
            else
            {
                afb.Activate();
            }
        }

        void afb_FormClosed(object sender, FormClosedEventArgs e)
        {
            afb = null;
            //throw new NotImplementedException();
        }

        aboutProject ap;
        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ap == null)
            {
                ap = new aboutProject();
                ap.MdiParent = this;
                ap.FormClosed += ap_FormClosed;
                ap.Show();
            }
            else
            {
                ap.Activate();
            }
        }

        void ap_FormClosed(object sender, FormClosedEventArgs e)
        {
            ap = null;
            //throw new NotImplementedException();
        }

        aboutManage am;
        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (am == null)
            {
                am = new aboutManage();
                am.MdiParent = this;
                am.FormClosed += am_FormClosed;
                am.Show();
            }
            else
            {
                am.Activate();
            }
        }

        void am_FormClosed(object sender, FormClosedEventArgs e)
        {
            am = null;
            //throw new NotImplementedException();
        }

        aboutSearchbug asb;
        private void searchBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (asb == null)
            {
                asb = new aboutSearchbug();
                asb.MdiParent = this;
                asb.FormClosed += asb_FormClosed;
                asb.Show();
            }
            else
            {
                asb.Activate();
            }
        }

        void asb_FormClosed(object sender, FormClosedEventArgs e)
        {
            asb = null;
            //throw new NotImplementedException();
        }

        aboutGitHub agh;
        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (agh == null)
            {
                agh = new aboutGitHub();
                agh.MdiParent = this;
                agh.FormClosed += agh_FormClosed;
                agh.Show();
            }
            else
            {
                agh.Activate();
            }
        }

        void agh_FormClosed(object sender, FormClosedEventArgs e)
        {
            agh = null;
            //throw new NotImplementedException();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
