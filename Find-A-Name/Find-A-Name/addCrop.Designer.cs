namespace Find_A_Name
{
    partial class addCrop
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
            this.lblAddCrop = new System.Windows.Forms.Label();
            this.lblCultivationTime = new System.Windows.Forms.Label();
            this.lblCropName = new System.Windows.Forms.Label();
            this.txtCropName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblYieldValue = new System.Windows.Forms.Label();
            this.lblFertiliserFreq = new System.Windows.Forms.Label();
            this.txtCultTime = new System.Windows.Forms.TextBox();
            this.txtFertFreq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAddCrop
            // 
            this.lblAddCrop.AutoSize = true;
            this.lblAddCrop.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCrop.Location = new System.Drawing.Point(147, 39);
            this.lblAddCrop.Name = "lblAddCrop";
            this.lblAddCrop.Size = new System.Drawing.Size(109, 26);
            this.lblAddCrop.TabIndex = 16;
            this.lblAddCrop.Text = "Add Crop";
            // 
            // lblCultivationTime
            // 
            this.lblCultivationTime.AutoSize = true;
            this.lblCultivationTime.Location = new System.Drawing.Point(116, 148);
            this.lblCultivationTime.Margin = new System.Windows.Forms.Padding(12);
            this.lblCultivationTime.Name = "lblCultivationTime";
            this.lblCultivationTime.Size = new System.Drawing.Size(82, 13);
            this.lblCultivationTime.TabIndex = 23;
            this.lblCultivationTime.Text = "Cultivation Time";
            // 
            // lblCropName
            // 
            this.lblCropName.AutoSize = true;
            this.lblCropName.Location = new System.Drawing.Point(138, 113);
            this.lblCropName.Margin = new System.Windows.Forms.Padding(12);
            this.lblCropName.Name = "lblCropName";
            this.lblCropName.Size = new System.Drawing.Size(60, 13);
            this.lblCropName.TabIndex = 22;
            this.lblCropName.Text = "Crop Name";
            // 
            // txtCropName
            // 
            this.txtCropName.Location = new System.Drawing.Point(200, 110);
            this.txtCropName.Name = "txtCropName";
            this.txtCropName.Size = new System.Drawing.Size(100, 20);
            this.txtCropName.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 28;
            // 
            // lblYieldValue
            // 
            this.lblYieldValue.AutoSize = true;
            this.lblYieldValue.Location = new System.Drawing.Point(138, 221);
            this.lblYieldValue.Margin = new System.Windows.Forms.Padding(12);
            this.lblYieldValue.Name = "lblYieldValue";
            this.lblYieldValue.Size = new System.Drawing.Size(60, 13);
            this.lblYieldValue.TabIndex = 27;
            this.lblYieldValue.Text = "Yield Value";
            // 
            // lblFertiliserFreq
            // 
            this.lblFertiliserFreq.AutoSize = true;
            this.lblFertiliserFreq.Location = new System.Drawing.Point(100, 185);
            this.lblFertiliserFreq.Margin = new System.Windows.Forms.Padding(12);
            this.lblFertiliserFreq.Name = "lblFertiliserFreq";
            this.lblFertiliserFreq.Size = new System.Drawing.Size(98, 13);
            this.lblFertiliserFreq.TabIndex = 26;
            this.lblFertiliserFreq.Text = "Fertiliser Frequency";
            // 
            // txtCultTime
            // 
            this.txtCultTime.Location = new System.Drawing.Point(200, 145);
            this.txtCultTime.Name = "txtCultTime";
            this.txtCultTime.Size = new System.Drawing.Size(100, 20);
            this.txtCultTime.TabIndex = 29;
            // 
            // txtFertFreq
            // 
            this.txtFertFreq.Location = new System.Drawing.Point(200, 182);
            this.txtFertFreq.Name = "txtFertFreq";
            this.txtFertFreq.Size = new System.Drawing.Size(100, 20);
            this.txtFertFreq.TabIndex = 30;
            // 
            // addCrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 326);
            this.Controls.Add(this.txtFertFreq);
            this.Controls.Add(this.txtCultTime);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblYieldValue);
            this.Controls.Add(this.lblFertiliserFreq);
            this.Controls.Add(this.lblCultivationTime);
            this.Controls.Add(this.lblCropName);
            this.Controls.Add(this.txtCropName);
            this.Controls.Add(this.lblAddCrop);
            this.Name = "addCrop";
            this.Text = "Add Crop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddCrop;
        private System.Windows.Forms.Label lblCultivationTime;
        private System.Windows.Forms.Label lblCropName;
        private System.Windows.Forms.TextBox txtCropName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblYieldValue;
        private System.Windows.Forms.Label lblFertiliserFreq;
        private System.Windows.Forms.TextBox txtCultTime;
        private System.Windows.Forms.TextBox txtFertFreq;
    }
}