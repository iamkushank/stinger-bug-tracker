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
using System.IO;

namespace Stinger_Bug_Tracker
{
    public partial class AddbugForm : Form
    {
        BugClass bc = new BugClass();
        public AddbugForm()
        {
            InitializeComponent();
        }

        FileStream fs;
        BinaryReader br;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string FileName = pictureBoxErrorSnapshot.Text;
            byte[] ImageData;
            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            ImageData = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();

            bool res = bc.ManageBugs(0, dtpDate.Text, Int32.Parse(combProject.Text), Int32.Parse(txtBug.Text), txtClass.Text, txtRichCode.Text, txtMethod.Text, comboIdentify.Text, Int32.Parse(txtLinenumber.Text), txtClassLibrary.Text, ImageData, 1);
            if (res == true)
            {
                MessageBox.Show("Successfully Added the bug!!");
            }
            else
            {
                MessageBox.Show("Failed to add the bug!!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string FileName = pictureBoxErrorSnapshot.Text;
            byte[] ImageData;
            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            ImageData = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            bool res = bc.ManageBugs(0, dtpDate.Text, Int32.Parse(combProject.Text), Int32.Parse(txtBug.Text), txtClass.Text, txtRichCode.Text, txtMethod.Text, comboIdentify.Text, Int32.Parse(txtLinenumber.Text), txtClassLibrary.Text, ImageData, 2);
            if (res == true)
            {
                MessageBox.Show("Successfully updated the bugs!!");
            }
            else
            {
                MessageBox.Show("Failed to update!!");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string FileName = pictureBoxErrorSnapshot.Text;
            byte[] ImageData;
            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            ImageData = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            bool res = bc.ManageBugs(0, dtpDate.Text, Int32.Parse(combProject.Text), Int32.Parse(txtBug.Text), txtClass.Text, txtRichCode.Text, txtMethod.Text, comboIdentify.Text, Int32.Parse(txtLinenumber.Text), txtClassLibrary.Text, ImageData, 3);
            if (res == true)
            {
                MessageBox.Show("Successfully deleted the bugs!!");
            }
            else
            {
                MessageBox.Show("Failed to delete the bugsn!!");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files | *.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //txtStudentImage.Text = openFileDialog1.FileName;
                pictureBoxErrorSnapshot.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
