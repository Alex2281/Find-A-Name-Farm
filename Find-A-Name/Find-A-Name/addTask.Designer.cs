namespace Find_A_Name
{
    partial class addTask
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
            this.lblAddTask = new System.Windows.Forms.Label();
            this.lblTaskDate = new System.Windows.Forms.Label();
            this.lblSchedTime = new System.Windows.Forms.Label();
            this.txtTaskDate = new System.Windows.Forms.TextBox();
            this.txtSchedTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAddTask
            // 
            this.lblAddTask.AutoSize = true;
            this.lblAddTask.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTask.Location = new System.Drawing.Point(164, 32);
            this.lblAddTask.Name = "lblAddTask";
            this.lblAddTask.Size = new System.Drawing.Size(108, 26);
            this.lblAddTask.TabIndex = 15;
            this.lblAddTask.Text = "Add Task";
            // 
            // lblTaskDate
            // 
            this.lblTaskDate.AutoSize = true;
            this.lblTaskDate.Location = new System.Drawing.Point(73, 125);
            this.lblTaskDate.Name = "lblTaskDate";
            this.lblTaskDate.Size = new System.Drawing.Size(57, 13);
            this.lblTaskDate.TabIndex = 16;
            this.lblTaskDate.Text = "Task Date";
            // 
            // lblSchedTime
            // 
            this.lblSchedTime.AutoSize = true;
            this.lblSchedTime.Location = new System.Drawing.Point(73, 205);
            this.lblSchedTime.Name = "lblSchedTime";
            this.lblSchedTime.Size = new System.Drawing.Size(78, 13);
            this.lblSchedTime.TabIndex = 17;
            this.lblSchedTime.Text = "Schedule Time";
            // 
            // txtTaskDate
            // 
            this.txtTaskDate.Location = new System.Drawing.Point(169, 122);
            this.txtTaskDate.Name = "txtTaskDate";
            this.txtTaskDate.Size = new System.Drawing.Size(100, 20);
            this.txtTaskDate.TabIndex = 18;
            // 
            // txtSchedTime
            // 
            this.txtSchedTime.Location = new System.Drawing.Point(169, 202);
            this.txtSchedTime.Name = "txtSchedTime";
            this.txtSchedTime.Size = new System.Drawing.Size(100, 20);
            this.txtSchedTime.TabIndex = 19;
            // 
            // addTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 326);
            this.Controls.Add(this.txtSchedTime);
            this.Controls.Add(this.txtTaskDate);
            this.Controls.Add(this.lblSchedTime);
            this.Controls.Add(this.lblTaskDate);
            this.Controls.Add(this.lblAddTask);
            this.Name = "addTask";
            this.Text = "Add task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddTask;
        private System.Windows.Forms.Label lblTaskDate;
        private System.Windows.Forms.Label lblSchedTime;
        private System.Windows.Forms.TextBox txtTaskDate;
        private System.Windows.Forms.TextBox txtSchedTime;
    }
}