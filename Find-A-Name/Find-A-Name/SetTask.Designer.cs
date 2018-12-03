namespace Find_A_Name
{
    partial class setTask
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
            this.dtTaskDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmbTimes = new System.Windows.Forms.ComboBox();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.cmbTaskTypes = new System.Windows.Forms.ComboBox();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtTaskDate
            // 
            this.dtTaskDate.Location = new System.Drawing.Point(42, 99);
            this.dtTaskDate.Name = "dtTaskDate";
            this.dtTaskDate.Size = new System.Drawing.Size(200, 20);
            this.dtTaskDate.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(39, 83);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Set Date";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(42, 211);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(121, 21);
            this.cmbEmployees.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(39, 139);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Set Time";
            // 
            // cmbTimes
            // 
            this.cmbTimes.FormattingEnabled = true;
            this.cmbTimes.Location = new System.Drawing.Point(42, 155);
            this.cmbTimes.Name = "cmbTimes";
            this.cmbTimes.Size = new System.Drawing.Size(121, 21);
            this.cmbTimes.TabIndex = 4;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(39, 195);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(107, 13);
            this.lblEmployees.TabIndex = 5;
            this.lblEmployees.Text = "Choose an Employee";
            // 
            // cmbTaskTypes
            // 
            this.cmbTaskTypes.FormattingEnabled = true;
            this.cmbTaskTypes.Location = new System.Drawing.Point(42, 272);
            this.cmbTaskTypes.Name = "cmbTaskTypes";
            this.cmbTaskTypes.Size = new System.Drawing.Size(121, 21);
            this.cmbTaskTypes.TabIndex = 6;
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.Location = new System.Drawing.Point(42, 253);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(70, 13);
            this.lblTaskType.TabIndex = 7;
            this.lblTaskType.Text = "Choose Task";
            // 
            // SetTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTaskType);
            this.Controls.Add(this.cmbTaskTypes);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.cmbTimes);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtTaskDate);
            this.Name = "SetTask";
            this.Text = "SetTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTaskDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmbTimes;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.ComboBox cmbTaskTypes;
        private System.Windows.Forms.Label lblTaskType;
    }
}