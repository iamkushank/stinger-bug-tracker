namespace Stinger_Bug_Tracker
{
    partial class ListbugForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListbugForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewList = new System.Windows.Forms.DataGridView();
            this.buttonProjectid = new System.Windows.Forms.Button();
            this.textBoxProjectid = new System.Windows.Forms.TextBox();
            this.textBoxBugid = new System.Windows.Forms.TextBox();
            this.buttonBugid = new System.Windows.Forms.Button();
            this.textBoxSolutionid = new System.Windows.Forms.TextBox();
            this.buttonSolutionid = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(172, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 476);
            this.panel1.TabIndex = 27;
            // 
            // dataGridViewList
            // 
            this.dataGridViewList.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridViewList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewList.GridColor = System.Drawing.Color.Khaki;
            this.dataGridViewList.Location = new System.Drawing.Point(179, 7);
            this.dataGridViewList.Name = "dataGridViewList";
            this.dataGridViewList.Size = new System.Drawing.Size(782, 486);
            this.dataGridViewList.TabIndex = 28;
            // 
            // buttonProjectid
            // 
            this.buttonProjectid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.buttonProjectid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProjectid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProjectid.Image = ((System.Drawing.Image)(resources.GetObject("buttonProjectid.Image")));
            this.buttonProjectid.Location = new System.Drawing.Point(125, 49);
            this.buttonProjectid.Name = "buttonProjectid";
            this.buttonProjectid.Size = new System.Drawing.Size(28, 28);
            this.buttonProjectid.TabIndex = 34;
            this.buttonProjectid.UseVisualStyleBackColor = false;
            this.buttonProjectid.Click += new System.EventHandler(this.buttonProjectid_Click);
            // 
            // textBoxProjectid
            // 
            this.textBoxProjectid.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectid.ForeColor = System.Drawing.Color.Gray;
            this.textBoxProjectid.Location = new System.Drawing.Point(25, 54);
            this.textBoxProjectid.Name = "textBoxProjectid";
            this.textBoxProjectid.Size = new System.Drawing.Size(100, 21);
            this.textBoxProjectid.TabIndex = 31;
            this.textBoxProjectid.Text = "project id";
            this.textBoxProjectid.Enter += new System.EventHandler(this.textBoxProjectid_Enter);
            this.textBoxProjectid.Leave += new System.EventHandler(this.textBoxProjectid_Leave);
            // 
            // textBoxBugid
            // 
            this.textBoxBugid.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBugid.ForeColor = System.Drawing.Color.Gray;
            this.textBoxBugid.Location = new System.Drawing.Point(25, 114);
            this.textBoxBugid.Name = "textBoxBugid";
            this.textBoxBugid.Size = new System.Drawing.Size(100, 21);
            this.textBoxBugid.TabIndex = 31;
            this.textBoxBugid.Text = "bug id";
            this.textBoxBugid.Enter += new System.EventHandler(this.textBoxBugid_Enter);
            this.textBoxBugid.Leave += new System.EventHandler(this.textBoxBugid_Leave);
            // 
            // buttonBugid
            // 
            this.buttonBugid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.buttonBugid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBugid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBugid.Image = ((System.Drawing.Image)(resources.GetObject("buttonBugid.Image")));
            this.buttonBugid.Location = new System.Drawing.Point(125, 109);
            this.buttonBugid.Name = "buttonBugid";
            this.buttonBugid.Size = new System.Drawing.Size(28, 28);
            this.buttonBugid.TabIndex = 34;
            this.buttonBugid.UseVisualStyleBackColor = false;
            this.buttonBugid.Click += new System.EventHandler(this.buttonBugid_Click);
            // 
            // textBoxSolutionid
            // 
            this.textBoxSolutionid.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSolutionid.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSolutionid.Location = new System.Drawing.Point(25, 174);
            this.textBoxSolutionid.Name = "textBoxSolutionid";
            this.textBoxSolutionid.Size = new System.Drawing.Size(100, 21);
            this.textBoxSolutionid.TabIndex = 31;
            this.textBoxSolutionid.Text = "solution id";
            this.textBoxSolutionid.Enter += new System.EventHandler(this.textBoxSolutionid_Enter);
            this.textBoxSolutionid.Leave += new System.EventHandler(this.textBoxSolutionid_Leave);
            // 
            // buttonSolutionid
            // 
            this.buttonSolutionid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.buttonSolutionid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSolutionid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSolutionid.Image = ((System.Drawing.Image)(resources.GetObject("buttonSolutionid.Image")));
            this.buttonSolutionid.Location = new System.Drawing.Point(125, 169);
            this.buttonSolutionid.Name = "buttonSolutionid";
            this.buttonSolutionid.Size = new System.Drawing.Size(28, 28);
            this.buttonSolutionid.TabIndex = 34;
            this.buttonSolutionid.UseVisualStyleBackColor = false;
            this.buttonSolutionid.Click += new System.EventHandler(this.buttonSolutionid_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(48, 448);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 30);
            this.buttonClose.TabIndex = 44;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ListbugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(967, 501);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSolutionid);
            this.Controls.Add(this.buttonBugid);
            this.Controls.Add(this.buttonProjectid);
            this.Controls.Add(this.textBoxSolutionid);
            this.Controls.Add(this.textBoxBugid);
            this.Controls.Add(this.textBoxProjectid);
            this.Controls.Add(this.dataGridViewList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 155);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListbugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ListbugForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewList;
        private System.Windows.Forms.Button buttonProjectid;
        private System.Windows.Forms.TextBox textBoxProjectid;
        private System.Windows.Forms.TextBox textBoxBugid;
        private System.Windows.Forms.Button buttonBugid;
        private System.Windows.Forms.TextBox textBoxSolutionid;
        private System.Windows.Forms.Button buttonSolutionid;
        private System.Windows.Forms.Button buttonClose;
    }
}