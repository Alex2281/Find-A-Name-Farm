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
            this.lblTaskType = new System.Windows.Forms.Label();
            this.lblTaskDesc = new System.Windows.Forms.Label();
            this.txtTaskType = new System.Windows.Forms.TextBox();
            this.txtTaskDesc = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnTaskBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddTask
            // 
            this.lblAddTask.AutoSize = true;
            this.lblAddTask.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTask.Location = new System.Drawing.Point(164, 32);
            this.lblAddTask.Name = "lblAddTask";
            this.lblAddTask.Size = new System.Drawing.Size(186, 26);
            this.lblAddTask.TabIndex = 15;
            this.lblAddTask.Text = "Add a Task Type";
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.Location = new System.Drawing.Point(76, 114);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(58, 13);
            this.lblTaskType.TabIndex = 16;
            this.lblTaskType.Text = "Task Type";
            // 
            // lblTaskDesc
            // 
            this.lblTaskDesc.AutoSize = true;
            this.lblTaskDesc.Location = new System.Drawing.Point(76, 152);
            this.lblTaskDesc.Name = "lblTaskDesc";
            this.lblTaskDesc.Size = new System.Drawing.Size(87, 13);
            this.lblTaskDesc.TabIndex = 17;
            this.lblTaskDesc.Text = "Task Description";
            // 
            // txtTaskType
            // 
            this.txtTaskType.Location = new System.Drawing.Point(172, 111);
            this.txtTaskType.Name = "txtTaskType";
            this.txtTaskType.Size = new System.Drawing.Size(100, 20);
            this.txtTaskType.TabIndex = 18;
            // 
            // txtTaskDesc
            // 
            this.txtTaskDesc.Location = new System.Drawing.Point(172, 149);
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(100, 20);
            this.txtTaskDesc.TabIndex = 19;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(118, 259);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 20;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnTaskBack
            // 
            this.btnTaskBack.Location = new System.Drawing.Point(241, 259);
            this.btnTaskBack.Name = "btnTaskBack";
            this.btnTaskBack.Size = new System.Drawing.Size(75, 23);
            this.btnTaskBack.TabIndex = 21;
            this.btnTaskBack.Text = "Back";
            this.btnTaskBack.UseVisualStyleBackColor = true;
            // 
            // addTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 326);
            this.Controls.Add(this.btnTaskBack);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtTaskDesc);
            this.Controls.Add(this.txtTaskType);
            this.Controls.Add(this.lblTaskDesc);
            this.Controls.Add(this.lblTaskType);
            this.Controls.Add(this.lblAddTask);
            this.Name = "addTask";
            this.Text = "Add task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddTask;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.Label lblTaskDesc;
        private System.Windows.Forms.TextBox txtTaskType;
        private System.Windows.Forms.TextBox txtTaskDesc;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnTaskBack;
    }
}