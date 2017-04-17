namespace HospitalManagement_WFA
{
    partial class FormShowDrugList
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
            this.dataGridViewShowDrugListnForm = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowDrugListnForm)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewShowDrugListnForm
            // 
            this.dataGridViewShowDrugListnForm.AllowUserToAddRows = false;
            this.dataGridViewShowDrugListnForm.AllowUserToDeleteRows = false;
            this.dataGridViewShowDrugListnForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewShowDrugListnForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowDrugListnForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShowDrugListnForm.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewShowDrugListnForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewShowDrugListnForm.Name = "dataGridViewShowDrugListnForm";
            this.dataGridViewShowDrugListnForm.ReadOnly = true;
            this.dataGridViewShowDrugListnForm.Size = new System.Drawing.Size(430, 233);
            this.dataGridViewShowDrugListnForm.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 211);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(430, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(347, 17);
            this.toolStripStatusLabel1.Text = "Donor List ::Please take Donor Mobile Number If you need Blood";
            // 
            // FormShowDrugList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 233);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridViewShowDrugListnForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormShowDrugList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormShowDrugList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowDrugListnForm)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowDrugListnForm;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}