namespace Find_A_Name
{
    partial class addField
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
            this.titleAddField = new System.Windows.Forms.Label();
            this.txtFieldSize = new System.Windows.Forms.TextBox();
            this.lblFieldStatus = new System.Windows.Forms.Label();
            this.lblFieldSize = new System.Windows.Forms.Label();
            this.lblFieldRef = new System.Windows.Forms.Label();
            this.txtFieldRef = new System.Windows.Forms.TextBox();
            this.chboxFieldStatus = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleAddField
            // 
            this.titleAddField.AutoSize = true;
            this.titleAddField.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAddField.Location = new System.Drawing.Point(155, 41);
            this.titleAddField.Name = "titleAddField";
            this.titleAddField.Size = new System.Drawing.Size(109, 26);
            this.titleAddField.TabIndex = 15;
            this.titleAddField.Text = "Add Field";
            // 
            // txtFieldSize
            // 
            this.txtFieldSize.Location = new System.Drawing.Point(187, 150);
            this.txtFieldSize.Name = "txtFieldSize";
            this.txtFieldSize.Size = new System.Drawing.Size(100, 20);
            this.txtFieldSize.TabIndex = 20;
            // 
            // lblFieldStatus
            // 
            this.lblFieldStatus.AutoSize = true;
            this.lblFieldStatus.Location = new System.Drawing.Point(120, 190);
            this.lblFieldStatus.Name = "lblFieldStatus";
            this.lblFieldStatus.Size = new System.Drawing.Size(62, 13);
            this.lblFieldStatus.TabIndex = 19;
            this.lblFieldStatus.Text = "Field Status";
            // 
            // lblFieldSize
            // 
            this.lblFieldSize.AutoSize = true;
            this.lblFieldSize.Location = new System.Drawing.Point(123, 153);
            this.lblFieldSize.Margin = new System.Windows.Forms.Padding(12);
            this.lblFieldSize.Name = "lblFieldSize";
            this.lblFieldSize.Size = new System.Drawing.Size(52, 13);
            this.lblFieldSize.TabIndex = 18;
            this.lblFieldSize.Text = "Field Size";
            // 
            // lblFieldRef
            // 
            this.lblFieldRef.AutoSize = true;
            this.lblFieldRef.Location = new System.Drawing.Point(101, 117);
            this.lblFieldRef.Margin = new System.Windows.Forms.Padding(12);
            this.lblFieldRef.Name = "lblFieldRef";
            this.lblFieldRef.Size = new System.Drawing.Size(82, 13);
            this.lblFieldRef.TabIndex = 17;
            this.lblFieldRef.Text = "Field Reference";
            // 
            // txtFieldRef
            // 
            this.txtFieldRef.Location = new System.Drawing.Point(187, 114);
            this.txtFieldRef.Name = "txtFieldRef";
            this.txtFieldRef.Size = new System.Drawing.Size(100, 20);
            this.txtFieldRef.TabIndex = 16;
            // 
            // chboxFieldStatus
            // 
            this.chboxFieldStatus.AutoSize = true;
            this.chboxFieldStatus.Location = new System.Drawing.Point(187, 189);
            this.chboxFieldStatus.Name = "chboxFieldStatus";
            this.chboxFieldStatus.Size = new System.Drawing.Size(63, 17);
            this.chboxFieldStatus.TabIndex = 21;
            this.chboxFieldStatus.Text = "Yes/No";
            this.chboxFieldStatus.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(212, 237);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(123, 237);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(75, 23);
            this.btnAddField.TabIndex = 22;
            this.btnAddField.Text = "Create";
            this.btnAddField.UseVisualStyleBackColor = true;
            // 
            // addField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 326);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddField);
            this.Controls.Add(this.chboxFieldStatus);
            this.Controls.Add(this.txtFieldSize);
            this.Controls.Add(this.lblFieldStatus);
            this.Controls.Add(this.lblFieldSize);
            this.Controls.Add(this.lblFieldRef);
            this.Controls.Add(this.txtFieldRef);
            this.Controls.Add(this.titleAddField);
            this.Name = "addField";
            this.Text = "Add Field";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleAddField;
        private System.Windows.Forms.TextBox txtFieldSize;
        private System.Windows.Forms.Label lblFieldStatus;
        private System.Windows.Forms.Label lblFieldSize;
        private System.Windows.Forms.Label lblFieldRef;
        private System.Windows.Forms.TextBox txtFieldRef;
        private System.Windows.Forms.CheckBox chboxFieldStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddField;
    }
}