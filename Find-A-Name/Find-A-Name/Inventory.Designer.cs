namespace Find_A_Name
{
    partial class Inventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstVehicles = new System.Windows.Forms.Button();
            this.lstFields = new System.Windows.Forms.Button();
            this.lstCrops = new System.Windows.Forms.Button();
            this.lstStorage = new System.Windows.Forms.Button();
            this.lstEmployees = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFertiliser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(825, 422);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lstVehicles
            // 
            this.lstVehicles.Location = new System.Drawing.Point(93, 12);
            this.lstVehicles.Name = "lstVehicles";
            this.lstVehicles.Size = new System.Drawing.Size(75, 23);
            this.lstVehicles.TabIndex = 4;
            this.lstVehicles.Text = "Vehicles";
            this.lstVehicles.UseVisualStyleBackColor = true;
            this.lstVehicles.Click += new System.EventHandler(this.lstVehicles_Click);
            // 
            // lstFields
            // 
            this.lstFields.Location = new System.Drawing.Point(174, 12);
            this.lstFields.Name = "lstFields";
            this.lstFields.Size = new System.Drawing.Size(75, 23);
            this.lstFields.TabIndex = 5;
            this.lstFields.Text = "Fields";
            this.lstFields.UseVisualStyleBackColor = true;
            this.lstFields.Click += new System.EventHandler(this.lstFields_Click);
            // 
            // lstCrops
            // 
            this.lstCrops.Location = new System.Drawing.Point(255, 12);
            this.lstCrops.Name = "lstCrops";
            this.lstCrops.Size = new System.Drawing.Size(75, 23);
            this.lstCrops.TabIndex = 6;
            this.lstCrops.Text = "Crops";
            this.lstCrops.UseVisualStyleBackColor = true;
            this.lstCrops.Click += new System.EventHandler(this.lstCrops_Click);
            // 
            // lstStorage
            // 
            this.lstStorage.Location = new System.Drawing.Point(417, 12);
            this.lstStorage.Name = "lstStorage";
            this.lstStorage.Size = new System.Drawing.Size(75, 23);
            this.lstStorage.TabIndex = 7;
            this.lstStorage.Text = "Storage";
            this.lstStorage.UseVisualStyleBackColor = true;
            this.lstStorage.Click += new System.EventHandler(this.lstStorage_Click);
            // 
            // lstEmployees
            // 
            this.lstEmployees.Location = new System.Drawing.Point(12, 12);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(75, 23);
            this.lstEmployees.TabIndex = 8;
            this.lstEmployees.Text = "Employees";
            this.lstEmployees.UseVisualStyleBackColor = true;
            this.lstEmployees.Click += new System.EventHandler(this.lstEmployees_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(762, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFertiliser
            // 
            this.btnFertiliser.Location = new System.Drawing.Point(336, 12);
            this.btnFertiliser.Name = "btnFertiliser";
            this.btnFertiliser.Size = new System.Drawing.Size(75, 23);
            this.btnFertiliser.TabIndex = 10;
            this.btnFertiliser.Text = "Fertiliser";
            this.btnFertiliser.UseVisualStyleBackColor = true;
            this.btnFertiliser.Click += new System.EventHandler(this.btnFertiliser_Click);
            // 
            // Inventory
            // 
            this.ClientSize = new System.Drawing.Size(849, 475);
            this.Controls.Add(this.btnFertiliser);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstEmployees);
            this.Controls.Add(this.lstStorage);
            this.Controls.Add(this.lstCrops);
            this.Controls.Add(this.lstFields);
            this.Controls.Add(this.lstVehicles);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button lstVehicles;
        private System.Windows.Forms.Button lstFields;
        private System.Windows.Forms.Button lstCrops;
        private System.Windows.Forms.Button lstStorage;
        private System.Windows.Forms.Button lstEmployees;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFertiliser;
    }
}