namespace Stinger_Bug_Tracker
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBugsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancel = new Stinger_Bug_Tracker.CircularButton();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(234, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Need Help?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 416);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutTheApplicationToolStripMenuItem,
            this.menuBarToolStripMenuItem,
            this.searchBugsToolStripMenuItem,
            this.gitHubToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(145, 416);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 4);
            // 
            // aboutTheApplicationToolStripMenuItem
            // 
            this.aboutTheApplicationToolStripMenuItem.Name = "aboutTheApplicationToolStripMenuItem";
            this.aboutTheApplicationToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.aboutTheApplicationToolStripMenuItem.Text = "About the application.";
            this.aboutTheApplicationToolStripMenuItem.Click += new System.EventHandler(this.aboutTheApplicationToolStripMenuItem_Click);
            // 
            // menuBarToolStripMenuItem
            // 
            this.menuBarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBugToolStripMenuItem,
            this.listBugToolStripMenuItem,
            this.fixBugToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.menuBarToolStripMenuItem.Name = "menuBarToolStripMenuItem";
            this.menuBarToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.menuBarToolStripMenuItem.Text = "Menu bar";
            // 
            // addBugToolStripMenuItem
            // 
            this.addBugToolStripMenuItem.Name = "addBugToolStripMenuItem";
            this.addBugToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.addBugToolStripMenuItem.Text = "Add bug";
            this.addBugToolStripMenuItem.Click += new System.EventHandler(this.addBugToolStripMenuItem_Click);
            // 
            // listBugToolStripMenuItem
            // 
            this.listBugToolStripMenuItem.Name = "listBugToolStripMenuItem";
            this.listBugToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.listBugToolStripMenuItem.Text = "List bug";
            this.listBugToolStripMenuItem.Click += new System.EventHandler(this.listBugToolStripMenuItem_Click);
            // 
            // fixBugToolStripMenuItem
            // 
            this.fixBugToolStripMenuItem.Name = "fixBugToolStripMenuItem";
            this.fixBugToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.fixBugToolStripMenuItem.Text = "Fix bug";
            this.fixBugToolStripMenuItem.Click += new System.EventHandler(this.fixBugToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.projectToolStripMenuItem.Text = "Project";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // searchBugsToolStripMenuItem
            // 
            this.searchBugsToolStripMenuItem.Name = "searchBugsToolStripMenuItem";
            this.searchBugsToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.searchBugsToolStripMenuItem.Text = "Search bugs";
            this.searchBugsToolStripMenuItem.Click += new System.EventHandler(this.searchBugsToolStripMenuItem_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 71);
            this.panel2.TabIndex = 2;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancel.Image")));
            this.buttonCancel.Location = new System.Drawing.Point(638, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(28, 28);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutTheApplicationToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem menuBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBugsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private CircularButton buttonCancel;
    }
}