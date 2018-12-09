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
            this.dgdInventoryWindow = new System.Windows.Forms.DataGridView();
            this.lstVehicles = new System.Windows.Forms.Button();
            this.lstFields = new System.Windows.Forms.Button();
            this.lstCrops = new System.Windows.Forms.Button();
            this.lstStorage = new System.Windows.Forms.Button();
            this.lstEmployees = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFertiliser = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdInventoryWindow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgdInventoryWindow
            // 
            this.dgdInventoryWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdInventoryWindow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdInventoryWindow.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgdInventoryWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdInventoryWindow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdInventoryWindow.Location = new System.Drawing.Point(12, 12);
            this.dgdInventoryWindow.Name = "dgdInventoryWindow";
            this.dgdInventoryWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgdInventoryWindow.Size = new System.Drawing.Size(825, 397);
            this.dgdInventoryWindow.TabIndex = 0;
            this.dgdInventoryWindow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lstVehicles
            // 
            this.lstVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVehicles.Location = new System.Drawing.Point(108, 15);
            this.lstVehicles.Name = "lstVehicles";
            this.lstVehicles.Size = new System.Drawing.Size(100, 35);
            this.lstVehicles.TabIndex = 4;
            this.lstVehicles.Text = "Vehicles";
            this.lstVehicles.UseVisualStyleBackColor = true;
            this.lstVehicles.Click += new System.EventHandler(this.lstVehicles_Click);
            // 
            // lstFields
            // 
            this.lstFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFields.Location = new System.Drawing.Point(208, 15);
            this.lstFields.Name = "lstFields";
            this.lstFields.Size = new System.Drawing.Size(100, 35);
            this.lstFields.TabIndex = 5;
            this.lstFields.Text = "Fields";
            this.lstFields.UseVisualStyleBackColor = true;
            this.lstFields.Click += new System.EventHandler(this.lstFields_Click);
            // 
            // lstCrops
            // 
            this.lstCrops.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCrops.Location = new System.Drawing.Point(309, 15);
            this.lstCrops.Name = "lstCrops";
            this.lstCrops.Size = new System.Drawing.Size(100, 35);
            this.lstCrops.TabIndex = 6;
            this.lstCrops.Text = "Crops";
            this.lstCrops.UseVisualStyleBackColor = true;
            this.lstCrops.Click += new System.EventHandler(this.lstCrops_Click);
            // 
            // lstStorage
            // 
            this.lstStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStorage.Location = new System.Drawing.Point(510, 15);
            this.lstStorage.Name = "lstStorage";
            this.lstStorage.Size = new System.Drawing.Size(100, 35);
            this.lstStorage.TabIndex = 7;
            this.lstStorage.Text = "Storage";
            this.lstStorage.UseVisualStyleBackColor = true;
            this.lstStorage.Click += new System.EventHandler(this.lstStorage_Click);
            // 
            // lstEmployees
            // 
            this.lstEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEmployees.Location = new System.Drawing.Point(8, 15);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.Size = new System.Drawing.Size(100, 35);
            this.lstEmployees.TabIndex = 8;
            this.lstEmployees.Text = "Employees";
            this.lstEmployees.UseVisualStyleBackColor = true;
            this.lstEmployees.Click += new System.EventHandler(this.lstEmployees_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(631, 428);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFertiliser
            // 
            this.btnFertiliser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFertiliser.Location = new System.Drawing.Point(409, 15);
            this.btnFertiliser.Name = "btnFertiliser";
            this.btnFertiliser.Size = new System.Drawing.Size(100, 35);
            this.btnFertiliser.TabIndex = 10;
            this.btnFertiliser.Text = "Fertiliser";
            this.btnFertiliser.UseVisualStyleBackColor = true;
            this.btnFertiliser.Click += new System.EventHandler(this.btnFertiliser_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(737, 428);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstFields);
            this.groupBox1.Controls.Add(this.lstVehicles);
            this.groupBox1.Controls.Add(this.btnFertiliser);
            this.groupBox1.Controls.Add(this.lstCrops);
            this.groupBox1.Controls.Add(this.lstStorage);
            this.groupBox1.Controls.Add(this.lstEmployees);
            this.groupBox1.Location = new System.Drawing.Point(3, 415);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 56);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select to View";
            // 
            // Inventory
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgdInventoryWindow);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdInventoryWindow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdInventoryWindow;
        private System.Windows.Forms.Button lstVehicles;
        private System.Windows.Forms.Button lstFields;
        private System.Windows.Forms.Button lstCrops;
        private System.Windows.Forms.Button lstStorage;
        private System.Windows.Forms.Button lstEmployees;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFertiliser;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}