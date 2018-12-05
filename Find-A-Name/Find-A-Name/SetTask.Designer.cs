namespace Find_A_Name
{
    partial class setTask
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
            this.dtTaskDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmbTimes = new System.Windows.Forms.ComboBox();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.cmbTaskTypes = new System.Windows.Forms.ComboBox();
            this.lblTaskType = new System.Windows.Forms.Label();
            this.cmbCrops = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFields = new System.Windows.Forms.ComboBox();
            this.lblFields = new System.Windows.Forms.Label();
            this.cmbVehicles = new System.Windows.Forms.ComboBox();
            this.lblVehicles = new System.Windows.Forms.Label();
            this.cmbStorageUnit = new System.Windows.Forms.ComboBox();
            this.lblStorageUnits = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.bxSetTask = new System.Windows.Forms.GroupBox();
            this.dgdTasksList = new System.Windows.Forms.DataGridView();
            this.bxSetTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdTasksList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTaskDate
            // 
            this.dtTaskDate.CustomFormat = "dd/MM/yyyy";
            this.dtTaskDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTaskDate.Location = new System.Drawing.Point(38, 43);
            this.dtTaskDate.Name = "dtTaskDate";
            this.dtTaskDate.Size = new System.Drawing.Size(140, 20);
            this.dtTaskDate.TabIndex = 0;
            this.dtTaskDate.Value = new System.DateTime(2018, 12, 4, 0, 0, 0, 0);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(35, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Set Date";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(582, 46);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(140, 21);
            this.cmbEmployees.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(333, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Set Time";
            // 
            // cmbTimes
            // 
            this.cmbTimes.FormattingEnabled = true;
            this.cmbTimes.Location = new System.Drawing.Point(333, 46);
            this.cmbTimes.Name = "cmbTimes";
            this.cmbTimes.Size = new System.Drawing.Size(140, 21);
            this.cmbTimes.TabIndex = 4;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(579, 30);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(107, 13);
            this.lblEmployees.TabIndex = 5;
            this.lblEmployees.Text = "Choose an Employee";
            // 
            // cmbTaskTypes
            // 
            this.cmbTaskTypes.FormattingEnabled = true;
            this.cmbTaskTypes.Location = new System.Drawing.Point(38, 103);
            this.cmbTaskTypes.Name = "cmbTaskTypes";
            this.cmbTaskTypes.Size = new System.Drawing.Size(140, 21);
            this.cmbTaskTypes.TabIndex = 6;
            // 
            // lblTaskType
            // 
            this.lblTaskType.AutoSize = true;
            this.lblTaskType.Location = new System.Drawing.Point(35, 87);
            this.lblTaskType.Name = "lblTaskType";
            this.lblTaskType.Size = new System.Drawing.Size(70, 13);
            this.lblTaskType.TabIndex = 7;
            this.lblTaskType.Text = "Choose Task";
            // 
            // cmbCrops
            // 
            this.cmbCrops.FormattingEnabled = true;
            this.cmbCrops.Location = new System.Drawing.Point(336, 103);
            this.cmbCrops.Name = "cmbCrops";
            this.cmbCrops.Size = new System.Drawing.Size(140, 21);
            this.cmbCrops.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose Crop";
            // 
            // cmbFields
            // 
            this.cmbFields.FormattingEnabled = true;
            this.cmbFields.Location = new System.Drawing.Point(582, 103);
            this.cmbFields.Name = "cmbFields";
            this.cmbFields.Size = new System.Drawing.Size(140, 21);
            this.cmbFields.TabIndex = 10;
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Location = new System.Drawing.Point(582, 87);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(73, 13);
            this.lblFields.TabIndex = 11;
            this.lblFields.Text = "Choose Fields";
            // 
            // cmbVehicles
            // 
            this.cmbVehicles.FormattingEnabled = true;
            this.cmbVehicles.Location = new System.Drawing.Point(38, 161);
            this.cmbVehicles.Name = "cmbVehicles";
            this.cmbVehicles.Size = new System.Drawing.Size(140, 21);
            this.cmbVehicles.TabIndex = 12;
            // 
            // lblVehicles
            // 
            this.lblVehicles.AutoSize = true;
            this.lblVehicles.Location = new System.Drawing.Point(35, 145);
            this.lblVehicles.Name = "lblVehicles";
            this.lblVehicles.Size = new System.Drawing.Size(81, 13);
            this.lblVehicles.TabIndex = 13;
            this.lblVehicles.Text = "Choose Vehicle";
            // 
            // cmbStorageUnit
            // 
            this.cmbStorageUnit.FormattingEnabled = true;
            this.cmbStorageUnit.Location = new System.Drawing.Point(333, 161);
            this.cmbStorageUnit.Name = "cmbStorageUnit";
            this.cmbStorageUnit.Size = new System.Drawing.Size(140, 21);
            this.cmbStorageUnit.TabIndex = 14;
            // 
            // lblStorageUnits
            // 
            this.lblStorageUnits.AutoSize = true;
            this.lblStorageUnits.Location = new System.Drawing.Point(330, 145);
            this.lblStorageUnits.Name = "lblStorageUnits";
            this.lblStorageUnits.Size = new System.Drawing.Size(108, 13);
            this.lblStorageUnits.TabIndex = 15;
            this.lblStorageUnits.Text = "Select a Storage Unit";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(628, 159);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 16;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // bxSetTask
            // 
            this.bxSetTask.Controls.Add(this.btnAddTask);
            this.bxSetTask.Controls.Add(this.lblStorageUnits);
            this.bxSetTask.Controls.Add(this.cmbStorageUnit);
            this.bxSetTask.Controls.Add(this.lblVehicles);
            this.bxSetTask.Controls.Add(this.cmbVehicles);
            this.bxSetTask.Controls.Add(this.lblFields);
            this.bxSetTask.Controls.Add(this.cmbFields);
            this.bxSetTask.Controls.Add(this.label1);
            this.bxSetTask.Controls.Add(this.cmbCrops);
            this.bxSetTask.Controls.Add(this.lblTaskType);
            this.bxSetTask.Controls.Add(this.cmbTaskTypes);
            this.bxSetTask.Controls.Add(this.lblEmployees);
            this.bxSetTask.Controls.Add(this.cmbTimes);
            this.bxSetTask.Controls.Add(this.lblTime);
            this.bxSetTask.Controls.Add(this.cmbEmployees);
            this.bxSetTask.Controls.Add(this.lblDate);
            this.bxSetTask.Controls.Add(this.dtTaskDate);
            this.bxSetTask.Location = new System.Drawing.Point(21, 243);
            this.bxSetTask.Name = "bxSetTask";
            this.bxSetTask.Size = new System.Drawing.Size(758, 189);
            this.bxSetTask.TabIndex = 17;
            this.bxSetTask.TabStop = false;
            this.bxSetTask.Text = "Set New Task";
            // 
            // dgdTasksList
            // 
            this.dgdTasksList.AllowUserToOrderColumns = true;
            this.dgdTasksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdTasksList.Location = new System.Drawing.Point(21, 20);
            this.dgdTasksList.Name = "dgdTasksList";
            this.dgdTasksList.Size = new System.Drawing.Size(758, 208);
            this.dgdTasksList.TabIndex = 18;
            // 
            // setTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgdTasksList);
            this.Controls.Add(this.bxSetTask);
            this.Name = "setTask";
            this.Text = "SetTask";
            this.bxSetTask.ResumeLayout(false);
            this.bxSetTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdTasksList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTaskDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmbTimes;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.ComboBox cmbTaskTypes;
        private System.Windows.Forms.Label lblTaskType;
        private System.Windows.Forms.ComboBox cmbCrops;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFields;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.ComboBox cmbVehicles;
        private System.Windows.Forms.Label lblVehicles;
        private System.Windows.Forms.ComboBox cmbStorageUnit;
        private System.Windows.Forms.Label lblStorageUnits;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.GroupBox bxSetTask;
        private System.Windows.Forms.DataGridView dgdTasksList;
    }
}