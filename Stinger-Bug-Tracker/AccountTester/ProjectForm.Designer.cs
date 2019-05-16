namespace Stinger_Bug_Tracker
{
    partial class ProjectForm
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxProject = new System.Windows.Forms.TextBox();
            this.dtpEnddate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartdate = new System.Windows.Forms.DateTimePicker();
            this.labelErroSnapshot = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProjectid = new System.Windows.Forms.TextBox();
            this.txtRichDescription = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(728, 410);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 30);
            this.buttonExit.TabIndex = 53;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(728, 361);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.TabIndex = 54;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(728, 312);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 30);
            this.buttonUpdate.TabIndex = 55;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(728, 263);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 30);
            this.buttonAdd.TabIndex = 56;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxProject
            // 
            this.textBoxProject.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProject.Location = new System.Drawing.Point(439, 116);
            this.textBoxProject.Name = "textBoxProject";
            this.textBoxProject.Size = new System.Drawing.Size(200, 26);
            this.textBoxProject.TabIndex = 52;
            // 
            // dtpEnddate
            // 
            this.dtpEnddate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnddate.Location = new System.Drawing.Point(439, 218);
            this.dtpEnddate.Name = "dtpEnddate";
            this.dtpEnddate.Size = new System.Drawing.Size(200, 26);
            this.dtpEnddate.TabIndex = 50;
            // 
            // dtpStartdate
            // 
            this.dtpStartdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartdate.Location = new System.Drawing.Point(439, 167);
            this.dtpStartdate.Name = "dtpStartdate";
            this.dtpStartdate.Size = new System.Drawing.Size(200, 26);
            this.dtpStartdate.TabIndex = 51;
            // 
            // labelErroSnapshot
            // 
            this.labelErroSnapshot.AutoSize = true;
            this.labelErroSnapshot.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErroSnapshot.Location = new System.Drawing.Point(318, 223);
            this.labelErroSnapshot.Name = "labelErroSnapshot";
            this.labelErroSnapshot.Size = new System.Drawing.Size(76, 20);
            this.labelErroSnapshot.TabIndex = 45;
            this.labelErroSnapshot.Text = "End Date";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(303, 286);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(91, 20);
            this.labelDescription.TabIndex = 46;
            this.labelDescription.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Project";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(313, 172);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(81, 20);
            this.labelDate.TabIndex = 49;
            this.labelDate.Text = "Start Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(172, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 476);
            this.panel1.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(323, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 60;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "ID";
            // 
            // textBoxProjectid
            // 
            this.textBoxProjectid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProjectid.Location = new System.Drawing.Point(234, 14);
            this.textBoxProjectid.Name = "textBoxProjectid";
            this.textBoxProjectid.Size = new System.Drawing.Size(89, 26);
            this.textBoxProjectid.TabIndex = 58;
            // 
            // txtRichDescription
            // 
            this.txtRichDescription.Location = new System.Drawing.Point(439, 288);
            this.txtRichDescription.Name = "txtRichDescription";
            this.txtRichDescription.Size = new System.Drawing.Size(199, 151);
            this.txtRichDescription.TabIndex = 61;
            this.txtRichDescription.Text = "";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(967, 501);
            this.Controls.Add(this.txtRichDescription);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProjectid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxProject);
            this.Controls.Add(this.dtpEnddate);
            this.Controls.Add(this.dtpStartdate);
            this.Controls.Add(this.labelErroSnapshot);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 155);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ProjectForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxProject;
        private System.Windows.Forms.DateTimePicker dtpEnddate;
        private System.Windows.Forms.DateTimePicker dtpStartdate;
        private System.Windows.Forms.Label labelErroSnapshot;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProjectid;
        private System.Windows.Forms.RichTextBox txtRichDescription;
    }
}