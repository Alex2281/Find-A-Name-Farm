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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblVehicleDescription = new System.Windows.Forms.Label();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblVehicleStatus = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddVeh = new System.Windows.Forms.Button();
            this.cmbVehStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAddVehicle
            // 
            this.lblAddVehicle.AutoSize = true;
            this.lblAddVehicle.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddVehicle.Location = new System.Drawing.Point(12, 9);
            this.lblAddVehicle.Name = "lblAddVehicle";
            this.lblAddVehicle.Size = new System.Drawing.Size(183, 34);
            this.lblAddVehicle.TabIndex = 15;
            this.lblAddVehicle.Text = "Add Vehicle";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(159, 86);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(116, 20);
            this.txtDescription.TabIndex = 20;
            // 
            // lblVehicleDescription
            // 
            this.lblVehicleDescription.AutoSize = true;
            this.lblVehicleDescription.Location = new System.Drawing.Point(156, 69);
            this.lblVehicleDescription.Margin = new System.Windows.Forms.Padding(12);
            this.lblVehicleDescription.Name = "lblVehicleDescription";
            this.lblVehicleDescription.Size = new System.Drawing.Size(98, 13);
            this.lblVehicleDescription.TabIndex = 18;
            this.lblVehicleDescription.Text = "Vehicle Description";
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Location = new System.Drawing.Point(15, 69);
            this.lblVehicleType.Margin = new System.Windows.Forms.Padding(12);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(69, 13);
            this.lblVehicleType.TabIndex = 17;
            this.lblVehicleType.Text = "Vehicle Type";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(12, 86);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(116, 20);
            this.txtType.TabIndex = 16;
            // 
            // lblVehicleStatus
            // 
            this.lblVehicleStatus.AutoSize = true;
            this.lblVehicleStatus.Location = new System.Drawing.Point(12, 129);
            this.lblVehicleStatus.Name = "lblVehicleStatus";
            this.lblVehicleStatus.Size = new System.Drawing.Size(75, 13);
            this.lblVehicleStatus.TabIndex = 19;
            this.lblVehicleStatus.Text = "Vehicle Status";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 201);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddVeh
            // 
            this.btnAddVeh.Location = new System.Drawing.Point(175, 201);
            this.btnAddVeh.Name = "btnAddVeh";
            this.btnAddVeh.Size = new System.Drawing.Size(100, 35);
            this.btnAddVeh.TabIndex = 24;
            this.btnAddVeh.Text = "Create";
            this.btnAddVeh.UseVisualStyleBackColor = true;
            this.btnAddVeh.Click += new System.EventHandler(this.btnAddVeh_Click);
            // 
            // cmbVehStatus
            // 
            this.cmbVehStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVehStatus.FormattingEnabled = true;
            this.cmbVehStatus.Location = new System.Drawing.Point(12, 154);
            this.cmbVehStatus.Name = "cmbVehStatus";
            this.cmbVehStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbVehStatus.TabIndex = 26;
            // 
            // addVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(296, 249);
            this.Controls.Add(this.cmbVehStatus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddVeh);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblVehicleStatus);
            this.Controls.Add(this.lblVehicleDescription);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblAddVehicle);
            this.Name = "addVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addVehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddVehicle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblVehicleDescription;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblVehicleStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddVeh;
        private System.Windows.Forms.ComboBox cmbVehStatus;
    }
}