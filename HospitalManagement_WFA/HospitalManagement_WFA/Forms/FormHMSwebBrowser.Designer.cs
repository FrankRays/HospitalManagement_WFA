namespace HospitalManagement_WFA
{
    partial class FormHMSwebBrowser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goForwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apolloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ibnSinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labaidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.goBackToolStripMenuItem,
            this.goForwardToolStripMenuItem,
            this.toolStripTextBox1,
            this.goToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.addTabToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 23);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.goBackToolStripMenuItem.Text = "<<Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // goForwardToolStripMenuItem
            // 
            this.goForwardToolStripMenuItem.Name = "goForwardToolStripMenuItem";
            this.goForwardToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.goForwardToolStripMenuItem.Text = "Go Forward>>";
            this.goForwardToolStripMenuItem.Click += new System.EventHandler(this.goForwardToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(300, 23);
            this.toolStripTextBox1.Text = "https://www.";
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.Size = new System.Drawing.Size(34, 23);
            this.goToolStripMenuItem.Text = "Go";
            this.goToolStripMenuItem.Click += new System.EventHandler(this.goToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // addTabToolStripMenuItem
            // 
            this.addTabToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.addTabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apolloToolStripMenuItem,
            this.enamToolStripMenuItem,
            this.ibnSinaToolStripMenuItem,
            this.iMCToolStripMenuItem,
            this.labaidToolStripMenuItem});
            this.addTabToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addTabToolStripMenuItem.Name = "addTabToolStripMenuItem";
            this.addTabToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.addTabToolStripMenuItem.Text = "BD Hospitals";
            this.addTabToolStripMenuItem.Click += new System.EventHandler(this.addTabToolStripMenuItem_Click);
            // 
            // apolloToolStripMenuItem
            // 
            this.apolloToolStripMenuItem.Name = "apolloToolStripMenuItem";
            this.apolloToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.apolloToolStripMenuItem.Text = "Apollo";
            this.apolloToolStripMenuItem.Click += new System.EventHandler(this.apolloToolStripMenuItem_Click);
            // 
            // enamToolStripMenuItem
            // 
            this.enamToolStripMenuItem.Name = "enamToolStripMenuItem";
            this.enamToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.enamToolStripMenuItem.Text = "Enam";
            this.enamToolStripMenuItem.Click += new System.EventHandler(this.enamToolStripMenuItem_Click);
            // 
            // ibnSinaToolStripMenuItem
            // 
            this.ibnSinaToolStripMenuItem.Name = "ibnSinaToolStripMenuItem";
            this.ibnSinaToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.ibnSinaToolStripMenuItem.Text = "Ibn Sina";
            this.ibnSinaToolStripMenuItem.Click += new System.EventHandler(this.ibnSinaToolStripMenuItem_Click);
            // 
            // iMCToolStripMenuItem
            // 
            this.iMCToolStripMenuItem.Name = "iMCToolStripMenuItem";
            this.iMCToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.iMCToolStripMenuItem.Text = "IMC";
            this.iMCToolStripMenuItem.Click += new System.EventHandler(this.iMCToolStripMenuItem_Click);
            // 
            // labaidToolStripMenuItem
            // 
            this.labaidToolStripMenuItem.Name = "labaidToolStripMenuItem";
            this.labaidToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.labaidToolStripMenuItem.Text = "Labaid";
            this.labaidToolStripMenuItem.Click += new System.EventHandler(this.labaidToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(818, 354);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://www.google.com.bd/", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 386);
            this.tabControl1.TabIndex = 0;
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // FormHMSwebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 413);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHMSwebBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHMSwebBrowser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goForwardToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apolloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ibnSinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labaidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
    }
}