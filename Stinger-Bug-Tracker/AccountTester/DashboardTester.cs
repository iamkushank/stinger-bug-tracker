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

namespace Stinger_Bug_Tracker
{
    public partial class DashboardTester : Form
    {
        public DashboardTester()
        {
            InitializeComponent();
         
        }

        private void buttonSignout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            String search = textBoxSearch.Text;
            if (search.ToLower().Trim().Equals("search for bugs"))
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            String search = textBoxSearch.Text;
            if (search.ToLower().Trim().Equals("search for bugs") || search.Trim().Equals(""))
            {
                textBoxSearch.Text = "search for bugs";
                textBoxSearch.ForeColor = Color.Gray;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=stinger_users_db");
            DataTable dt = new DataTable();

            MySqlCommand SDA = new MySqlCommand("SELECT * FROM tbl_bugs where bug=@bug", conn);
            SDA.Parameters.AddWithValue("@bug", textBoxSearch.Text);
            conn.Open();
            MySqlDataReader dr = SDA.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            dataGridViewList.DataSource = dt;
            dataGridViewList.Show();
        }

        private void DashboardTester_Load(object sender, EventArgs e)
        {
            MdiClient ctlMdi;

            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMdi = (MdiClient)ctl;

                    ctlMdi.BackColor = System.Drawing.Color.Khaki;
                    buttonAddBug.Enabled = true;
                }
                catch (InvalidCastException exc)
                {
                }
            }
        }

        AddbugForm abf;
        private void buttonAddBug_Click(object sender, EventArgs e)
        {
            dataGridViewList.Hide();
            
            if (abf == null)
            {
                abf = new AddbugForm();
                abf.MdiParent = this;
                abf.FormClosed += abf_FormClosed;
                abf.Show();
            }
            else
            {
                abf.Activate();
            }
        }

        void abf_FormClosed(object sender, FormClosedEventArgs e)
        {
            abf = null;
            // throw new NotImplementedException();
        }

        ListbugForm lbf;
        private void buttonListBug_Click(object sender, EventArgs e)
        {
            dataGridViewList.Hide();

            if (lbf == null)
            {
                lbf = new ListbugForm();
                lbf.MdiParent = this;
                lbf.FormClosed += lbf_FormClosed;
                lbf.Show();
            }
            else
            {
                lbf.Activate();
            }
        }

        void lbf_FormClosed(object sender, FormClosedEventArgs e)
        {
            lbf = null;
            //throw new NotImplementedException();
        }

        FixbugForm fbf;
        private void buttonFixBug_Click(object sender, EventArgs e)
        {
            dataGridViewList.Hide();

            if (fbf == null)
            {
                fbf = new FixbugForm();
                fbf.MdiParent = this;
                fbf.FormClosed += fbf_FormClosed;
                fbf.Show();
            }
            else
            {
                fbf.Activate();
            }
        }

        void fbf_FormClosed(object sender, FormClosedEventArgs e)
        {
            fbf = null;
            //throw new NotImplementedException();
        }

        ProjectForm pf;
        private void buttonProject_Click(object sender, EventArgs e)
        {
            dataGridViewList.Hide();

            if (pf == null)
            {
                pf = new ProjectForm();
                pf.MdiParent = this;
                pf.FormClosed += pf_FormClosed;
                pf.Show();
            }
            else
            {
                pf.Activate();
            }
        }

        void pf_FormClosed(object sender, FormClosedEventArgs e)
        {
            pf = null;
            //throw new NotImplementedException();
        }

        ManageForm mf;
        private void buttonManage_Click(object sender, EventArgs e)
        {
            dataGridViewList.Hide();

            if (mf == null)
            {
                mf = new ManageForm();
                mf.MdiParent = this;
                mf.FormClosed += mf_FormClosed;
                mf.Show();
            }
            else
            {
                mf.Activate();
            }
        }

        void mf_FormClosed(object sender, FormClosedEventArgs e)
        {
            mf = null;
            //throw new NotImplementedException();
        }

        private void labelDisplayUname_MouseEnter(object sender, EventArgs e)
        {
            labelDisplayUname.ForeColor = Color.Yellow;
        }

        private void labelDisplayUname_MouseLeave(object sender, EventArgs e)
        {
            labelDisplayUname.ForeColor = Color.White;
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm();
            profile.Show();
        }

        private void labelDisplayUname_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm();
            profile.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }

        private void buttonGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/iamkuhank/stinger-bug-tracker/commits/master");
        }
    }
}
