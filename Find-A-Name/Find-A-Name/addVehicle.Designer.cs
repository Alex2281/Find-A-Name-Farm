namespace Find_A_Name
{
    partial class addVehicle
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
            this.lblAddVehicle = new System.Windows.Forms.Label();
            this.txtVehDescription = new System.Windows.Forms.TextBox();
            this.lblVehicleDescription = new System.Windows.Forms.Label();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.txtVehType = new System.Windows.Forms.TextBox();
            this.lblVehicleStatus = new System.Windows.Forms.Label();
            this.chboxVehicleStatus = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddVeh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddVehicle
            // 
            this.lblAddVehicle.AutoSize = true;
            this.lblAddVehicle.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddVehicle.Location = new System.Drawing.Point(142, 36);
            this.lblAddVehicle.Name = "lblAddVehicle";
            this.lblAddVehicle.Size = new System.Drawing.Size(135, 26);
            this.lblAddVehicle.TabIndex = 15;
            this.lblAddVehicle.Text = "Add Vehicle";
            // 
            // txtVehDescription
            // 
            this.txtVehDescription.Location = new System.Drawing.Point(177, 130);
            this.txtVehDescription.Name = "txtVehDescription";
            this.txtVehDescription.Size = new System.Drawing.Size(100, 20);
            this.txtVehDescription.TabIndex = 20;
            // 
            // lblVehicleDescription
            // 
            this.lblVehicleDescription.AutoSize = true;
            this.lblVehicleDescription.Location = new System.Drawing.Point(79, 133);
            this.lblVehicleDescription.Margin = new System.Windows.Forms.Padding(12);
            this.lblVehicleDescription.Name = "lblVehicleDescription";
            this.lblVehicleDescription.Size = new System.Drawing.Size(98, 13);
            this.lblVehicleDescription.TabIndex = 18;
            this.lblVehicleDescription.Text = "Vehicle Description";
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Location = new System.Drawing.Point(106, 97);
            this.lblVehicleType.Margin = new System.Windows.Forms.Padding(12);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(69, 13);
            this.lblVehicleType.TabIndex = 17;
            this.lblVehicleType.Text = "Vehicle Type";
            // 
            // txtVehType
            // 
            this.txtVehType.Location = new System.Drawing.Point(177, 94);
            this.txtVehType.Name = "txtVehType";
            this.txtVehType.Size = new System.Drawing.Size(100, 20);
            this.txtVehType.TabIndex = 16;
            // 
            // lblVehicleStatus
            // 
            this.lblVehicleStatus.AutoSize = true;
            this.lblVehicleStatus.Location = new System.Drawing.Point(100, 169);
            this.lblVehicleStatus.Name = "lblVehicleStatus";
            this.lblVehicleStatus.Size = new System.Drawing.Size(75, 13);
            this.lblVehicleStatus.TabIndex = 19;
            this.lblVehicleStatus.Text = "Vehicle Status";
            // 
            // chboxVehicleStatus
            // 
            this.chboxVehicleStatus.AutoSize = true;
            this.chboxVehicleStatus.Location = new System.Drawing.Point(177, 168);
            this.chboxVehicleStatus.Name = "chboxVehicleStatus";
            this.chboxVehicleStatus.Size = new System.Drawing.Size(63, 17);
            this.chboxVehicleStatus.TabIndex = 21;
            this.chboxVehicleStatus.Text = "Yes/No";
            this.chboxVehicleStatus.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(221, 215);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddVeh
            // 
            this.btnAddVeh.Location = new System.Drawing.Point(132, 215);
            this.btnAddVeh.Name = "btnAddVeh";
            this.btnAddVeh.Size = new System.Drawing.Size(75, 23);
            this.btnAddVeh.TabIndex = 24;
            this.btnAddVeh.Text = "Create";
            this.btnAddVeh.UseVisualStyleBackColor = true;
            // 
            // addVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(445, 326);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddVeh);
            this.Controls.Add(this.chboxVehicleStatus);
            this.Controls.Add(this.txtVehDescription);
            this.Controls.Add(this.lblVehicleStatus);
            this.Controls.Add(this.lblVehicleDescription);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.txtVehType);
            this.Controls.Add(this.lblAddVehicle);
            this.Name = "addVehicle";
            this.Text = "addVehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddVehicle;
        private System.Windows.Forms.TextBox txtVehDescription;
        private System.Windows.Forms.Label lblVehicleDescription;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.TextBox txtVehType;
        private System.Windows.Forms.Label lblVehicleStatus;
        private System.Windows.Forms.CheckBox chboxVehicleStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddVeh;
    }
}