namespace HospitalManagement_WFA
{
    partial class FormPharmasy
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmployeeUN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmployeePW = new System.Windows.Forms.TextBox();
            this.buttonEmployeeLogIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonShowDrugList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username::";
            // 
            // textBoxEmployeeUN
            // 
            this.textBoxEmployeeUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeUN.Location = new System.Drawing.Point(123, 10);
            this.textBoxEmployeeUN.Name = "textBoxEmployeeUN";
            this.textBoxEmployeeUN.Size = new System.Drawing.Size(100, 26);
            this.textBoxEmployeeUN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password::";
            // 
            // textBoxEmployeePW
            // 
            this.textBoxEmployeePW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeePW.Location = new System.Drawing.Point(123, 40);
            this.textBoxEmployeePW.Name = "textBoxEmployeePW";
            this.textBoxEmployeePW.PasswordChar = '*';
            this.textBoxEmployeePW.Size = new System.Drawing.Size(100, 26);
            this.textBoxEmployeePW.TabIndex = 3;
            // 
            // buttonEmployeeLogIn
            // 
            this.buttonEmployeeLogIn.AutoSize = true;
            this.buttonEmployeeLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployeeLogIn.Location = new System.Drawing.Point(148, 72);
            this.buttonEmployeeLogIn.Name = "buttonEmployeeLogIn";
            this.buttonEmployeeLogIn.Size = new System.Drawing.Size(75, 30);
            this.buttonEmployeeLogIn.TabIndex = 4;
            this.buttonEmployeeLogIn.Text = "Log In";
            this.buttonEmployeeLogIn.UseVisualStyleBackColor = true;
            this.buttonEmployeeLogIn.Click += new System.EventHandler(this.buttonEmployeeLogIn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxEmployeeUN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonEmployeeLogIn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxEmployeePW);
            this.panel1.Location = new System.Drawing.Point(24, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 114);
            this.panel1.TabIndex = 6;
            // 
            // buttonShowDrugList
            // 
            this.buttonShowDrugList.AutoSize = true;
            this.buttonShowDrugList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowDrugList.Location = new System.Drawing.Point(24, 43);
            this.buttonShowDrugList.Name = "buttonShowDrugList";
            this.buttonShowDrugList.Size = new System.Drawing.Size(239, 35);
            this.buttonShowDrugList.TabIndex = 7;
            this.buttonShowDrugList.Text = "Show Available Drug List";
            this.buttonShowDrugList.UseVisualStyleBackColor = true;
            this.buttonShowDrugList.Click += new System.EventHandler(this.buttonShowDrugList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Only For Pharmasy Employee";
            // 
            // FormPharmasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonShowDrugList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPharmasy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmasy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmployeeUN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmployeePW;
        private System.Windows.Forms.Button buttonEmployeeLogIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShowDrugList;
        private System.Windows.Forms.Label label3;
    }
}