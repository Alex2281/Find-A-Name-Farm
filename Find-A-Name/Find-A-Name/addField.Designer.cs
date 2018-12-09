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
            this.lblFieldSize = new System.Windows.Forms.Label();
            this.lblFieldRef = new System.Windows.Forms.Label();
            this.txtFieldRef = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleAddField
            // 
            this.titleAddField.AutoSize = true;
            this.titleAddField.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAddField.Location = new System.Drawing.Point(12, 9);
            this.titleAddField.Name = "titleAddField";
            this.titleAddField.Size = new System.Drawing.Size(149, 34);
            this.titleAddField.TabIndex = 15;
            this.titleAddField.Text = "Add Field";
            // 
            // txtFieldSize
            // 
            this.txtFieldSize.Location = new System.Drawing.Point(150, 97);
            this.txtFieldSize.Name = "txtFieldSize";
            this.txtFieldSize.Size = new System.Drawing.Size(116, 20);
            this.txtFieldSize.TabIndex = 20;
            // 
            // lblFieldSize
            // 
            this.lblFieldSize.AutoSize = true;
            this.lblFieldSize.Location = new System.Drawing.Point(147, 79);
            this.lblFieldSize.Margin = new System.Windows.Forms.Padding(12);
            this.lblFieldSize.Name = "lblFieldSize";
            this.lblFieldSize.Size = new System.Drawing.Size(52, 13);
            this.lblFieldSize.TabIndex = 18;
            this.lblFieldSize.Text = "Field Size";
            // 
            // lblFieldRef
            // 
            this.lblFieldRef.AutoSize = true;
            this.lblFieldRef.Location = new System.Drawing.Point(15, 79);
            this.lblFieldRef.Margin = new System.Windows.Forms.Padding(12);
            this.lblFieldRef.Name = "lblFieldRef";
            this.lblFieldRef.Size = new System.Drawing.Size(82, 13);
            this.lblFieldRef.TabIndex = 17;
            this.lblFieldRef.Text = "Field Reference";
            // 
            // txtFieldRef
            // 
            this.txtFieldRef.Location = new System.Drawing.Point(12, 97);
            this.txtFieldRef.Name = "txtFieldRef";
            this.txtFieldRef.Size = new System.Drawing.Size(116, 20);
            this.txtFieldRef.TabIndex = 16;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 152);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(166, 152);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(100, 35);
            this.btnAddField.TabIndex = 22;
            this.btnAddField.Text = "Create";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // addField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(296, 200);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddField);
            this.Controls.Add(this.txtFieldSize);
            this.Controls.Add(this.lblFieldSize);
            this.Controls.Add(this.lblFieldRef);
            this.Controls.Add(this.txtFieldRef);
            this.Controls.Add(this.titleAddField);
            this.Name = "addField";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Field";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleAddField;
        private System.Windows.Forms.TextBox txtFieldSize;
        private System.Windows.Forms.Label lblFieldSize;
        private System.Windows.Forms.Label lblFieldRef;
        private System.Windows.Forms.TextBox txtFieldRef;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddField;
    }
}