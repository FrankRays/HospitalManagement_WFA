namespace HospitalManagement_WFA
{
    partial class FormDrugSell
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
            this.buttonShowDrugList = new System.Windows.Forms.Button();
            this.dataGridViewShowDList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSellDrugandPrint = new System.Windows.Forms.Button();
            this.textBoxDrugId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCollected = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReturned = new System.Windows.Forms.TextBox();
            this.buttonEmpLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowDList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowDrugList
            // 
            this.buttonShowDrugList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonShowDrugList.AutoSize = true;
            this.buttonShowDrugList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowDrugList.Location = new System.Drawing.Point(236, 557);
            this.buttonShowDrugList.Name = "buttonShowDrugList";
            this.buttonShowDrugList.Size = new System.Drawing.Size(88, 30);
            this.buttonShowDrugList.TabIndex = 17;
            this.buttonShowDrugList.Text = "Show List";
            this.buttonShowDrugList.UseVisualStyleBackColor = true;
            this.buttonShowDrugList.Click += new System.EventHandler(this.buttonShowDrugList_Click_1);
            // 
            // dataGridViewShowDList
            // 
            this.dataGridViewShowDList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShowDList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewShowDList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowDList.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewShowDList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewShowDList.Name = "dataGridViewShowDList";
            this.dataGridViewShowDList.Size = new System.Drawing.Size(526, 537);
            this.dataGridViewShowDList.TabIndex = 18;
            this.dataGridViewShowDList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowDList_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelEmployee);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.buttonSellDrugandPrint);
            this.panel1.Controls.Add(this.textBoxDrugId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxCollected);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxReturned);
            this.panel1.Location = new System.Drawing.Point(568, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 371);
            this.panel1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "DRUG SELLING";
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.ForeColor = System.Drawing.Color.Crimson;
            this.labelEmployee.Location = new System.Drawing.Point(222, 46);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(70, 17);
            this.labelEmployee.TabIndex = 44;
            this.labelEmployee.Text = "Employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Enter Id Of Drug :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Responsible ::";
            // 
            // buttonSellDrugandPrint
            // 
            this.buttonSellDrugandPrint.AutoSize = true;
            this.buttonSellDrugandPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSellDrugandPrint.Location = new System.Drawing.Point(175, 278);
            this.buttonSellDrugandPrint.Name = "buttonSellDrugandPrint";
            this.buttonSellDrugandPrint.Size = new System.Drawing.Size(171, 30);
            this.buttonSellDrugandPrint.TabIndex = 33;
            this.buttonSellDrugandPrint.Text = "Sell and Print Receipt";
            this.buttonSellDrugandPrint.UseVisualStyleBackColor = true;
            this.buttonSellDrugandPrint.Click += new System.EventHandler(this.buttonSellDrug_Click);
            // 
            // textBoxDrugId
            // 
            this.textBoxDrugId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDrugId.Location = new System.Drawing.Point(209, 105);
            this.textBoxDrugId.Name = "textBoxDrugId";
            this.textBoxDrugId.Size = new System.Drawing.Size(137, 26);
            this.textBoxDrugId.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "/=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Enter Collected Amount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "/=";
            // 
            // textBoxCollected
            // 
            this.textBoxCollected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCollected.Location = new System.Drawing.Point(209, 164);
            this.textBoxCollected.Name = "textBoxCollected";
            this.textBoxCollected.Size = new System.Drawing.Size(137, 26);
            this.textBoxCollected.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Enter Returned Amount :";
            // 
            // textBoxReturned
            // 
            this.textBoxReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReturned.Location = new System.Drawing.Point(209, 222);
            this.textBoxReturned.Name = "textBoxReturned";
            this.textBoxReturned.Size = new System.Drawing.Size(137, 26);
            this.textBoxReturned.TabIndex = 38;
            // 
            // buttonEmpLogOut
            // 
            this.buttonEmpLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEmpLogOut.AutoSize = true;
            this.buttonEmpLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpLogOut.Location = new System.Drawing.Point(831, 557);
            this.buttonEmpLogOut.Name = "buttonEmpLogOut";
            this.buttonEmpLogOut.Size = new System.Drawing.Size(123, 30);
            this.buttonEmpLogOut.TabIndex = 20;
            this.buttonEmpLogOut.Text = "Log Out";
            this.buttonEmpLogOut.UseVisualStyleBackColor = true;
            this.buttonEmpLogOut.Click += new System.EventHandler(this.buttonEmpLogOut_Click);
            // 
            // FormDrugSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 599);
            this.Controls.Add(this.buttonEmpLogOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewShowDList);
            this.Controls.Add(this.buttonShowDrugList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDrugSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDrugSell";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDrugSell_FormClosed);
            this.Load += new System.EventHandler(this.FormDrugSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowDList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowDrugList;
        private System.Windows.Forms.DataGridView dataGridViewShowDList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSellDrugandPrint;
        private System.Windows.Forms.TextBox textBoxDrugId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCollected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReturned;
        private System.Windows.Forms.Button buttonEmpLogOut;


    }
}