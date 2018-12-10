namespace Find_A_Name
{
    partial class LabourerMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbUserDetails = new System.Windows.Forms.GroupBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnChangeDetails = new System.Windows.Forms.Button();
            this.lbvEmailAddress = new System.Windows.Forms.Label();
            this.lbvPhoneNumber = new System.Windows.Forms.Label();
            this.lbvAddress = new System.Windows.Forms.Label();
            this.lbvName = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgdUserTasks = new System.Windows.Forms.DataGridView();
            this.gbTaskViewer = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbJobStatus = new System.Windows.Forms.GroupBox();
            this.lbv4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbvComplete = new System.Windows.Forms.Label();
            this.lbvPending = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbUserDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdUserTasks)).BeginInit();
            this.gbTaskViewer.SuspendLayout();
            this.gbJobStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // gbUserDetails
            // 
            this.gbUserDetails.Controls.Add(this.btnLogOut);
            this.gbUserDetails.Controls.Add(this.btnChangeDetails);
            this.gbUserDetails.Controls.Add(this.lbvEmailAddress);
            this.gbUserDetails.Controls.Add(this.lbvPhoneNumber);
            this.gbUserDetails.Controls.Add(this.lbvAddress);
            this.gbUserDetails.Controls.Add(this.lbvName);
            this.gbUserDetails.Controls.Add(this.lblEmailAddress);
            this.gbUserDetails.Controls.Add(this.lblPhoneNumber);
            this.gbUserDetails.Controls.Add(this.lblAddress);
            this.gbUserDetails.Controls.Add(this.lblName);
            this.gbUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserDetails.Location = new System.Drawing.Point(13, 39);
            this.gbUserDetails.Name = "gbUserDetails";
            this.gbUserDetails.Size = new System.Drawing.Size(340, 253);
            this.gbUserDetails.TabIndex = 1;
            this.gbUserDetails.TabStop = false;
            this.gbUserDetails.Text = "Your Details";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(16, 202);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(136, 35);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnChangeDetails
            // 
            this.btnChangeDetails.Location = new System.Drawing.Point(187, 202);
            this.btnChangeDetails.Name = "btnChangeDetails";
            this.btnChangeDetails.Size = new System.Drawing.Size(136, 35);
            this.btnChangeDetails.TabIndex = 10;
            this.btnChangeDetails.Text = "Change Details";
            this.btnChangeDetails.UseVisualStyleBackColor = true;
            // 
            // lbvEmailAddress
            // 
            this.lbvEmailAddress.AutoSize = true;
            this.lbvEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvEmailAddress.Location = new System.Drawing.Point(176, 136);
            this.lbvEmailAddress.Name = "lbvEmailAddress";
            this.lbvEmailAddress.Size = new System.Drawing.Size(0, 17);
            this.lbvEmailAddress.TabIndex = 9;
            // 
            // lbvPhoneNumber
            // 
            this.lbvPhoneNumber.AutoSize = true;
            this.lbvPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvPhoneNumber.Location = new System.Drawing.Point(176, 101);
            this.lbvPhoneNumber.Name = "lbvPhoneNumber";
            this.lbvPhoneNumber.Size = new System.Drawing.Size(0, 17);
            this.lbvPhoneNumber.TabIndex = 8;
            // 
            // lbvAddress
            // 
            this.lbvAddress.AutoSize = true;
            this.lbvAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvAddress.Location = new System.Drawing.Point(176, 68);
            this.lbvAddress.Name = "lbvAddress";
            this.lbvAddress.Size = new System.Drawing.Size(0, 17);
            this.lbvAddress.TabIndex = 7;
            // 
            // lbvName
            // 
            this.lbvName.AutoSize = true;
            this.lbvName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvName.Location = new System.Drawing.Point(176, 36);
            this.lbvName.Name = "lbvName";
            this.lbvName.Size = new System.Drawing.Size(0, 17);
            this.lbvName.TabIndex = 6;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(16, 136);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(102, 17);
            this.lblEmailAddress.TabIndex = 5;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(16, 101);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(107, 17);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 68);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // dgdUserTasks
            // 
            this.dgdUserTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdUserTasks.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgdUserTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdUserTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdUserTasks.Location = new System.Drawing.Point(378, 49);
            this.dgdUserTasks.Name = "dgdUserTasks";
            this.dgdUserTasks.Size = new System.Drawing.Size(467, 166);
            this.dgdUserTasks.TabIndex = 2;
            // 
            // gbTaskViewer
            // 
            this.gbTaskViewer.Controls.Add(this.btnNext);
            this.gbTaskViewer.Controls.Add(this.btnPrevious);
            this.gbTaskViewer.Controls.Add(this.btnUpdate);
            this.gbTaskViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTaskViewer.Location = new System.Drawing.Point(12, 307);
            this.gbTaskViewer.Name = "gbTaskViewer";
            this.gbTaskViewer.Size = new System.Drawing.Size(838, 241);
            this.gbTaskViewer.TabIndex = 3;
            this.gbTaskViewer.TabStop = false;
            this.gbTaskViewer.Text = "View Task";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(132, 200);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 35);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(6, 200);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(120, 35);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "<<Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(689, 195);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 35);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // gbJobStatus
            // 
            this.gbJobStatus.Controls.Add(this.lbv4);
            this.gbJobStatus.Controls.Add(this.label3);
            this.gbJobStatus.Controls.Add(this.lbvComplete);
            this.gbJobStatus.Controls.Add(this.lbvPending);
            this.gbJobStatus.Controls.Add(this.label2);
            this.gbJobStatus.Controls.Add(this.label1);
            this.gbJobStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbJobStatus.Location = new System.Drawing.Point(378, 227);
            this.gbJobStatus.Name = "gbJobStatus";
            this.gbJobStatus.Size = new System.Drawing.Size(472, 65);
            this.gbJobStatus.TabIndex = 4;
            this.gbJobStatus.TabStop = false;
            this.gbJobStatus.Text = "Job Status";
            // 
            // lbv4
            // 
            this.lbv4.AutoSize = true;
            this.lbv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbv4.Location = new System.Drawing.Point(399, 16);
            this.lbv4.Name = "lbv4";
            this.lbv4.Size = new System.Drawing.Size(43, 46);
            this.lbv4.TabIndex = 4;
            this.lbv4.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "label";
            // 
            // lbvComplete
            // 
            this.lbvComplete.AutoSize = true;
            this.lbvComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvComplete.Location = new System.Drawing.Point(252, 16);
            this.lbvComplete.Name = "lbvComplete";
            this.lbvComplete.Size = new System.Drawing.Size(43, 46);
            this.lbvComplete.TabIndex = 0;
            this.lbvComplete.Text = "0";
            // 
            // lbvPending
            // 
            this.lbvPending.AutoSize = true;
            this.lbvPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvPending.Location = new System.Drawing.Point(104, 14);
            this.lbvPending.Name = "lbvPending";
            this.lbvPending.Size = new System.Drawing.Size(43, 46);
            this.lbvPending.TabIndex = 2;
            this.lbvPending.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Completed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pending:";
            // 
            // LabourerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 560);
            this.Controls.Add(this.gbJobStatus);
            this.Controls.Add(this.gbTaskViewer);
            this.Controls.Add(this.dgdUserTasks);
            this.Controls.Add(this.gbUserDetails);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LabourerMain";
            this.Text = "Labourer Homepage";
            this.Load += new System.EventHandler(this.LabourerPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbUserDetails.ResumeLayout(false);
            this.gbUserDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdUserTasks)).EndInit();
            this.gbTaskViewer.ResumeLayout(false);
            this.gbJobStatus.ResumeLayout(false);
            this.gbJobStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbUserDetails;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.DataGridView dgdUserTasks;
        private System.Windows.Forms.Label lbvEmailAddress;
        private System.Windows.Forms.Label lbvPhoneNumber;
        private System.Windows.Forms.Label lbvAddress;
        private System.Windows.Forms.Label lbvName;
        private System.Windows.Forms.Button btnChangeDetails;
        private System.Windows.Forms.GroupBox gbTaskViewer;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.GroupBox gbJobStatus;
        private System.Windows.Forms.Label lbv4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbvComplete;
        private System.Windows.Forms.Label lbvPending;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnUpdate;
    }
}