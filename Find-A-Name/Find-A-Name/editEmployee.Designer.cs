namespace Find_A_Name
{
    partial class editEmployee
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSelectEmp = new System.Windows.Forms.Label();
            this.lblEditEmp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // lblSelectEmp
            // 
            this.lblSelectEmp.AutoSize = true;
            this.lblSelectEmp.Location = new System.Drawing.Point(25, 89);
            this.lblSelectEmp.Name = "lblSelectEmp";
            this.lblSelectEmp.Size = new System.Drawing.Size(86, 13);
            this.lblSelectEmp.TabIndex = 1;
            this.lblSelectEmp.Text = "Select Employee";
            // 
            // lblEditEmp
            // 
            this.lblEditEmp.AutoSize = true;
            this.lblEditEmp.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEmp.Location = new System.Drawing.Point(144, 21);
            this.lblEditEmp.Name = "lblEditEmp";
            this.lblEditEmp.Size = new System.Drawing.Size(162, 26);
            this.lblEditEmp.TabIndex = 16;
            this.lblEditEmp.Text = "Edit Employee";
            // 
            // editEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 326);
            this.Controls.Add(this.lblEditEmp);
            this.Controls.Add(this.lblSelectEmp);
            this.Controls.Add(this.comboBox1);
            this.Name = "editEmployee";
            this.Text = "Edit Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSelectEmp;
        private System.Windows.Forms.Label lblEditEmp;
    }
}