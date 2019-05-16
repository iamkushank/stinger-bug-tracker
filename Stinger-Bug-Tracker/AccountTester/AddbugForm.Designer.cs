namespace Stinger_Bug_Tracker
{
    partial class AddbugForm
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
            this.labelDate = new System.Windows.Forms.Label();
            this.labelProject = new System.Windows.Forms.Label();
            this.labelBug = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelClasslibrary = new System.Windows.Forms.Label();
            this.labelLinenumber = new System.Windows.Forms.Label();
            this.labelIdentify = new System.Windows.Forms.Label();
            this.labelMethod = new System.Windows.Forms.Label();
            this.labelErroSnapshot = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.combProject = new System.Windows.Forms.ComboBox();
            this.txtBug = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtClassLibrary = new System.Windows.Forms.TextBox();
            this.txtLinenumber = new System.Windows.Forms.TextBox();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.comboIdentify = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRichCode = new System.Windows.Forms.RichTextBox();
            this.pictureBoxErrorSnapshot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorSnapshot)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(230, 96);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 20);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProject.Location = new System.Drawing.Point(215, 152);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(61, 20);
            this.labelProject.TabIndex = 0;
            this.labelProject.Text = "Project";
            // 
            // labelBug
            // 
            this.labelBug.AutoSize = true;
            this.labelBug.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBug.Location = new System.Drawing.Point(239, 212);
            this.labelBug.Name = "labelBug";
            this.labelBug.Size = new System.Drawing.Size(37, 20);
            this.labelBug.TabIndex = 0;
            this.labelBug.Text = "Bug";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(230, 273);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(46, 20);
            this.labelClass.TabIndex = 0;
            this.labelClass.Text = "Class";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.Location = new System.Drawing.Point(224, 323);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(51, 20);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "Code";
            // 
            // labelClasslibrary
            // 
            this.labelClasslibrary.AutoSize = true;
            this.labelClasslibrary.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClasslibrary.Location = new System.Drawing.Point(555, 273);
            this.labelClasslibrary.Name = "labelClasslibrary";
            this.labelClasslibrary.Size = new System.Drawing.Size(98, 20);
            this.labelClasslibrary.TabIndex = 0;
            this.labelClasslibrary.Text = "Class Library";
            // 
            // labelLinenumber
            // 
            this.labelLinenumber.AutoSize = true;
            this.labelLinenumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLinenumber.Location = new System.Drawing.Point(555, 212);
            this.labelLinenumber.Name = "labelLinenumber";
            this.labelLinenumber.Size = new System.Drawing.Size(100, 20);
            this.labelLinenumber.TabIndex = 0;
            this.labelLinenumber.Text = "Line Number";
            // 
            // labelIdentify
            // 
            this.labelIdentify.AutoSize = true;
            this.labelIdentify.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentify.Location = new System.Drawing.Point(570, 152);
            this.labelIdentify.Name = "labelIdentify";
            this.labelIdentify.Size = new System.Drawing.Size(85, 20);
            this.labelIdentify.TabIndex = 0;
            this.labelIdentify.Text = "Identify By";
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMethod.Location = new System.Drawing.Point(582, 97);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(68, 20);
            this.labelMethod.TabIndex = 0;
            this.labelMethod.Text = "Method";
            // 
            // labelErroSnapshot
            // 
            this.labelErroSnapshot.AutoSize = true;
            this.labelErroSnapshot.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErroSnapshot.Location = new System.Drawing.Point(543, 325);
            this.labelErroSnapshot.Name = "labelErroSnapshot";
            this.labelErroSnapshot.Size = new System.Drawing.Size(112, 20);
            this.labelErroSnapshot.TabIndex = 0;
            this.labelErroSnapshot.Text = "Error Snapshot";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(312, 91);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDate.TabIndex = 1;
            // 
            // combProject
            // 
            this.combProject.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combProject.FormattingEnabled = true;
            this.combProject.Location = new System.Drawing.Point(312, 149);
            this.combProject.Name = "combProject";
            this.combProject.Size = new System.Drawing.Size(200, 28);
            this.combProject.TabIndex = 2;
            // 
            // txtBug
            // 
            this.txtBug.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBug.Location = new System.Drawing.Point(312, 209);
            this.txtBug.Name = "txtBug";
            this.txtBug.Size = new System.Drawing.Size(200, 26);
            this.txtBug.TabIndex = 3;
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(312, 267);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(200, 26);
            this.txtClass.TabIndex = 3;
            // 
            // txtClassLibrary
            // 
            this.txtClassLibrary.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassLibrary.Location = new System.Drawing.Point(677, 91);
            this.txtClassLibrary.Name = "txtClassLibrary";
            this.txtClassLibrary.Size = new System.Drawing.Size(200, 26);
            this.txtClassLibrary.TabIndex = 3;
            // 
            // txtLinenumber
            // 
            this.txtLinenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinenumber.Location = new System.Drawing.Point(677, 210);
            this.txtLinenumber.Name = "txtLinenumber";
            this.txtLinenumber.Size = new System.Drawing.Size(200, 24);
            this.txtLinenumber.TabIndex = 3;
            // 
            // txtMethod
            // 
            this.txtMethod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMethod.Location = new System.Drawing.Point(677, 267);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(200, 26);
            this.txtMethod.TabIndex = 3;
            // 
            // comboIdentify
            // 
            this.comboIdentify.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboIdentify.FormattingEnabled = true;
            this.comboIdentify.Location = new System.Drawing.Point(677, 149);
            this.comboIdentify.Name = "comboIdentify";
            this.comboIdentify.Size = new System.Drawing.Size(200, 28);
            this.comboIdentify.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(312, 28);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 30);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(475, 28);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 30);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(638, 28);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(801, 28);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 30);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(578, 448);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 30);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(172, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 476);
            this.panel1.TabIndex = 5;
            // 
            // txtRichCode
            // 
            this.txtRichCode.Location = new System.Drawing.Point(312, 325);
            this.txtRichCode.Name = "txtRichCode";
            this.txtRichCode.Size = new System.Drawing.Size(200, 153);
            this.txtRichCode.TabIndex = 6;
            this.txtRichCode.Text = "";
            // 
            // pictureBoxErrorSnapshot
            // 
            this.pictureBoxErrorSnapshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxErrorSnapshot.Location = new System.Drawing.Point(678, 325);
            this.pictureBoxErrorSnapshot.Name = "pictureBoxErrorSnapshot";
            this.pictureBoxErrorSnapshot.Size = new System.Drawing.Size(199, 153);
            this.pictureBoxErrorSnapshot.TabIndex = 54;
            this.pictureBoxErrorSnapshot.TabStop = false;
            // 
            // AddbugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(967, 501);
            this.Controls.Add(this.pictureBoxErrorSnapshot);
            this.Controls.Add(this.txtRichCode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.txtLinenumber);
            this.Controls.Add(this.txtClassLibrary);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtBug);
            this.Controls.Add(this.comboIdentify);
            this.Controls.Add(this.combProject);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.labelErroSnapshot);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.labelIdentify);
            this.Controls.Add(this.labelLinenumber);
            this.Controls.Add(this.labelClasslibrary);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelBug);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.labelDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 155);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddbugForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddbugForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorSnapshot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.Label labelBug;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelClasslibrary;
        private System.Windows.Forms.Label labelLinenumber;
        private System.Windows.Forms.Label labelIdentify;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.Label labelErroSnapshot;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox combProject;
        private System.Windows.Forms.TextBox txtBug;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtClassLibrary;
        private System.Windows.Forms.TextBox txtLinenumber;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.ComboBox comboIdentify;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtRichCode;
        private System.Windows.Forms.PictureBox pictureBoxErrorSnapshot;
    }
}