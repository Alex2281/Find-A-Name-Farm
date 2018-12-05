namespace Find_A_Name
{
    partial class editTask
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
            this.cmbTaskType = new System.Windows.Forms.ComboBox();
            this.cmbTaskTypeDesc = new System.Windows.Forms.ComboBox();
            this.dataGridTaskType = new System.Windows.Forms.DataGridView();
            this.lblEditTaskType = new System.Windows.Forms.Label();
            this.lblEditTaskDesc = new System.Windows.Forms.Label();
            this.btnEditTaskPrev = new System.Windows.Forms.Button();
            this.btnEditTaskType = new System.Windows.Forms.Button();
            this.btnEditTaskNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTaskType)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTaskType
            // 
            this.cmbTaskType.FormattingEnabled = true;
            this.cmbTaskType.Location = new System.Drawing.Point(121, 84);
            this.cmbTaskType.Name = "cmbTaskType";
            this.cmbTaskType.Size = new System.Drawing.Size(121, 21);
            this.cmbTaskType.TabIndex = 2;
            // 
            // cmbTaskTypeDesc
            // 
            this.cmbTaskTypeDesc.FormattingEnabled = true;
            this.cmbTaskTypeDesc.Location = new System.Drawing.Point(121, 111);
            this.cmbTaskTypeDesc.Name = "cmbTaskTypeDesc";
            this.cmbTaskTypeDesc.Size = new System.Drawing.Size(121, 21);
            this.cmbTaskTypeDesc.TabIndex = 3;
            // 
            // dataGridTaskType
            // 
            this.dataGridTaskType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTaskType.Location = new System.Drawing.Point(55, 183);
            this.dataGridTaskType.Name = "dataGridTaskType";
            this.dataGridTaskType.Size = new System.Drawing.Size(455, 145);
            this.dataGridTaskType.TabIndex = 4;
            // 
            // lblEditTaskType
            // 
            this.lblEditTaskType.AutoSize = true;
            this.lblEditTaskType.Location = new System.Drawing.Point(57, 87);
            this.lblEditTaskType.Name = "lblEditTaskType";
            this.lblEditTaskType.Size = new System.Drawing.Size(58, 13);
            this.lblEditTaskType.TabIndex = 5;
            this.lblEditTaskType.Text = "Task Type";
            // 
            // lblEditTaskDesc
            // 
            this.lblEditTaskDesc.AutoSize = true;
            this.lblEditTaskDesc.Location = new System.Drawing.Point(28, 114);
            this.lblEditTaskDesc.Name = "lblEditTaskDesc";
            this.lblEditTaskDesc.Size = new System.Drawing.Size(87, 13);
            this.lblEditTaskDesc.TabIndex = 6;
            this.lblEditTaskDesc.Text = "Task Description";
            // 
            // btnEditTaskPrev
            // 
            this.btnEditTaskPrev.Location = new System.Drawing.Point(55, 145);
            this.btnEditTaskPrev.Name = "btnEditTaskPrev";
            this.btnEditTaskPrev.Size = new System.Drawing.Size(75, 23);
            this.btnEditTaskPrev.TabIndex = 7;
            this.btnEditTaskPrev.Text = "Previous";
            this.btnEditTaskPrev.UseVisualStyleBackColor = true;
            // 
            // btnEditTaskType
            // 
            this.btnEditTaskType.Location = new System.Drawing.Point(149, 145);
            this.btnEditTaskType.Name = "btnEditTaskType";
            this.btnEditTaskType.Size = new System.Drawing.Size(75, 23);
            this.btnEditTaskType.TabIndex = 8;
            this.btnEditTaskType.Text = "Edit";
            this.btnEditTaskType.UseVisualStyleBackColor = true;
            // 
            // btnEditTaskNext
            // 
            this.btnEditTaskNext.Location = new System.Drawing.Point(247, 145);
            this.btnEditTaskNext.Name = "btnEditTaskNext";
            this.btnEditTaskNext.Size = new System.Drawing.Size(75, 23);
            this.btnEditTaskNext.TabIndex = 9;
            this.btnEditTaskNext.Text = "Next";
            this.btnEditTaskNext.UseVisualStyleBackColor = true;
            // 
            // editTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 351);
            this.Controls.Add(this.btnEditTaskNext);
            this.Controls.Add(this.btnEditTaskType);
            this.Controls.Add(this.btnEditTaskPrev);
            this.Controls.Add(this.lblEditTaskDesc);
            this.Controls.Add(this.lblEditTaskType);
            this.Controls.Add(this.dataGridTaskType);
            this.Controls.Add(this.cmbTaskTypeDesc);
            this.Controls.Add(this.cmbTaskType);
            this.Name = "editTask";
            this.Text = "Edit Task";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTaskType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTaskType;
        private System.Windows.Forms.ComboBox cmbTaskTypeDesc;
        private System.Windows.Forms.DataGridView dataGridTaskType;
        private System.Windows.Forms.Label lblEditTaskType;
        private System.Windows.Forms.Label lblEditTaskDesc;
        private System.Windows.Forms.Button btnEditTaskPrev;
        private System.Windows.Forms.Button btnEditTaskType;
        private System.Windows.Forms.Button btnEditTaskNext;
    }
}