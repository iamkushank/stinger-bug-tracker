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
    public partial class FixbugForm : Form
    {
        FixbugClass fbc = new FixbugClass();
        public FixbugForm()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {   
            MemoryStream ms1 = new MemoryStream();
            MemoryStream ms2 = new MemoryStream();
            pictureBoxErrorSnapshot.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] ImageData = new byte[ms1.Length];
            ms1.Read(ImageData, 0, ImageData.Length);

            bool res = fbc.ManageFixbug(0, dtpDate.Text, Int32.Parse(combProject.Text), Int32.Parse(txtBug.Text), txtClass.Text, txtRichCode.Text, txtMethod.Text, comboSolved.Text, Int32.Parse(txtLinenumber.Text), txtClassLibrary.Text, ImageData, 2);
            if (res == true)
            {
                MessageBox.Show("Successfully updated the solutions!!");
            }
            else
            {
                MessageBox.Show("Failed to update!!");
            }
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
