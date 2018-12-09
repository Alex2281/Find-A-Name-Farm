namespace Find_A_Name
{
    partial class editEmployee
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
            this.lblEditEmp = new System.Windows.Forms.Label();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.cboxEdPrivilege = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEdPassword = new System.Windows.Forms.Label();
            this.lblEdUsername = new System.Windows.Forms.Label();
            this.lblEdEmail = new System.Windows.Forms.Label();
            this.lblEdPhoneNumber = new System.Windows.Forms.Label();
            this.lblEdPostcode = new System.Windows.Forms.Label();
            this.lblEdSurname = new System.Windows.Forms.Label();
            this.lblEdFirstname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataEmployee = new System.Windows.Forms.DataGridView();
            this.btnEditEmpPrev = new System.Windows.Forms.Button();
            this.btnEdEmpNext = new System.Windows.Forms.Button();
            this.txtEdEmpFirstName = new System.Windows.Forms.TextBox();
            this.txtEdEmpSurname = new System.Windows.Forms.TextBox();
            this.txtEdEmpUsern = new System.Windows.Forms.TextBox();
            this.txtEdEmpPhone = new System.Windows.Forms.TextBox();
            this.txtEdEmpPost = new System.Windows.Forms.TextBox();
            this.txtEdEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEdEmpPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditEmp
            // 
            this.lblEditEmp.AutoSize = true;
            this.lblEditEmp.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEmp.Location = new System.Drawing.Point(412, 10);
            this.lblEditEmp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditEmp.Name = "lblEditEmp";
            this.lblEditEmp.Size = new System.Drawing.Size(208, 34);
            this.lblEditEmp.TabIndex = 16;
            this.lblEditEmp.Text = "Edit Employee";
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.Location = new System.Drawing.Point(721, 374);
            this.btnEditEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(100, 28);
            this.btnEditEmp.TabIndex = 58;
            this.btnEditEmp.Text = "Edit";
            this.btnEditEmp.UseVisualStyleBackColor = true;
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            // 
            // cboxEdPrivilege
            // 
            this.cboxEdPrivilege.AutoSize = true;
            this.cboxEdPrivilege.Location = new System.Drawing.Point(431, 357);
            this.cboxEdPrivilege.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxEdPrivilege.Name = "cboxEdPrivilege";
            this.cboxEdPrivilege.Size = new System.Drawing.Size(76, 21);
            this.cboxEdPrivilege.TabIndex = 57;
            this.cboxEdPrivilege.Text = "Yes/No";
            this.cboxEdPrivilege.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 358);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Privilege";
            // 
            // lblEdPassword
            // 
            this.lblEdPassword.AutoSize = true;
            this.lblEdPassword.Location = new System.Drawing.Point(316, 226);
            this.lblEdPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdPassword.Name = "lblEdPassword";
            this.lblEdPassword.Size = new System.Drawing.Size(69, 17);
            this.lblEdPassword.TabIndex = 49;
            this.lblEdPassword.Text = "Password";
            // 
            // lblEdUsername
            // 
            this.lblEdUsername.AutoSize = true;
            this.lblEdUsername.Location = new System.Drawing.Point(316, 193);
            this.lblEdUsername.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.lblEdUsername.Name = "lblEdUsername";
            this.lblEdUsername.Size = new System.Drawing.Size(73, 17);
            this.lblEdUsername.TabIndex = 48;
            this.lblEdUsername.Text = "Username";
            // 
            // lblEdEmail
            // 
            this.lblEdEmail.AutoSize = true;
            this.lblEdEmail.Location = new System.Drawing.Point(339, 260);
            this.lblEdEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdEmail.Name = "lblEdEmail";
            this.lblEdEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEdEmail.TabIndex = 47;
            this.lblEdEmail.Text = "Email";
            // 
            // lblEdPhoneNumber
            // 
            this.lblEdPhoneNumber.AutoSize = true;
            this.lblEdPhoneNumber.Location = new System.Drawing.Point(281, 327);
            this.lblEdPhoneNumber.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.lblEdPhoneNumber.Name = "lblEdPhoneNumber";
            this.lblEdPhoneNumber.Size = new System.Drawing.Size(99, 17);
            this.lblEdPhoneNumber.TabIndex = 46;
            this.lblEdPhoneNumber.Text = "PhoneNumber";
            // 
            // lblEdPostcode
            // 
            this.lblEdPostcode.AutoSize = true;
            this.lblEdPostcode.Location = new System.Drawing.Point(312, 294);
            this.lblEdPostcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdPostcode.Name = "lblEdPostcode";
            this.lblEdPostcode.Size = new System.Drawing.Size(67, 17);
            this.lblEdPostcode.TabIndex = 45;
            this.lblEdPostcode.Text = "Postcode";
            // 
            // lblEdSurname
            // 
            this.lblEdSurname.AutoSize = true;
            this.lblEdSurname.Location = new System.Drawing.Point(316, 161);
            this.lblEdSurname.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.lblEdSurname.Name = "lblEdSurname";
            this.lblEdSurname.Size = new System.Drawing.Size(65, 17);
            this.lblEdSurname.TabIndex = 44;
            this.lblEdSurname.Text = "Surname";
            // 
            // lblEdFirstname
            // 
            this.lblEdFirstname.AutoSize = true;
            this.lblEdFirstname.Location = new System.Drawing.Point(312, 128);
            this.lblEdFirstname.Margin = new System.Windows.Forms.Padding(16, 15, 16, 15);
            this.lblEdFirstname.Name = "lblEdFirstname";
            this.lblEdFirstname.Size = new System.Drawing.Size(70, 17);
            this.lblEdFirstname.TabIndex = 43;
            this.lblEdFirstname.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Select Employee";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(392, 73);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 39;
            // 
            // dataEmployee
            // 
            this.dataEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmployee.Location = new System.Drawing.Point(80, 410);
            this.dataEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataEmployee.Name = "dataEmployee";
            this.dataEmployee.Size = new System.Drawing.Size(876, 229);
            this.dataEmployee.TabIndex = 60;
            this.dataEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEditEmpPrev
            // 
            this.btnEditEmpPrev.Location = new System.Drawing.Point(613, 374);
            this.btnEditEmpPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditEmpPrev.Name = "btnEditEmpPrev";
            this.btnEditEmpPrev.Size = new System.Drawing.Size(100, 28);
            this.btnEditEmpPrev.TabIndex = 69;
            this.btnEditEmpPrev.Text = "Previous";
            this.btnEditEmpPrev.UseVisualStyleBackColor = true;
            this.btnEditEmpPrev.Click += new System.EventHandler(this.btnEditEmpPrev_Click);
            // 
            // btnEdEmpNext
            // 
            this.btnEdEmpNext.Location = new System.Drawing.Point(829, 374);
            this.btnEdEmpNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdEmpNext.Name = "btnEdEmpNext";
            this.btnEdEmpNext.Size = new System.Drawing.Size(100, 28);
            this.btnEdEmpNext.TabIndex = 70;
            this.btnEdEmpNext.Text = "Next";
            this.btnEdEmpNext.UseVisualStyleBackColor = true;
            this.btnEdEmpNext.Click += new System.EventHandler(this.btnEdEmpNext_Click);
            // 
            // txtEdEmpFirstName
            // 
            this.txtEdEmpFirstName.Location = new System.Drawing.Point(401, 124);
            this.txtEdEmpFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdEmpFirstName.Name = "txtEdEmpFirstName";
            this.txtEdEmpFirstName.Size = new System.Drawing.Size(132, 22);
            this.txtEdEmpFirstName.TabIndex = 71;
            // 
            // txtEdEmpSurname
            // 
            this.txtEdEmpSurname.Location = new System.Drawing.Point(401, 158);
            this.txtEdEmpSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdEmpSurname.Name = "txtEdEmpSurname";
            this.txtEdEmpSurname.Size = new System.Drawing.Size(132, 22);
            this.txtEdEmpSurname.TabIndex = 72;
            // 
            // txtEdEmpUsern
            // 
            this.txtEdEmpUsern.Location = new System.Drawing.Point(401, 190);
            this.txtEdEmpUsern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdEmpUsern.Name = "txtEdEmpUsern";
            this.txtEdEmpUsern.Size = new System.Drawing.Size(132, 22);
            this.txtEdEmpUsern.TabIndex = 73;
            // 
            // txtEdEmpPhone
            // 
            this.txtEdEmpPhone.Location = new System.Drawing.Point(401, 324);
            this.txtEdEmpPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdEmpPhone.Name = "txtEdEmpPhone";
            this.txtEdEmpPhone.Size = new System.Drawing.Size(132, 22);
            this.txtEdEmpPhone.TabIndex = 74;
            // 
            // txtEdEmpPost
            // 
            this.txtEdEmpPost.Location = new System.Drawing.Point(401, 290);
            this.txtEdEmpPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdEmpPost.Name = "txtEdEmpPost";
            this.txtEdEmpPost.Size = new System.Drawing.Size(132, 22);
            this.txtEdEmpPost.TabIndex = 75;
            // 
            // txtEdEmpEmail
            // 
            this.txtEdEmpEmail.Location = new System.Drawing.Point(401, 256);
            this.txtEdEmpEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdEmpEmail.Name = "txtEdEmpEmail";
            this.txtEdEmpEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEdEmpEmail.TabIndex = 76;
            // 
            // txtEdEmpPass
            // 
            this.txtEdEmpPass.Location = new System.Drawing.Point(401, 223);
            this.txtEdEmpPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdEmpPass.Name = "txtEdEmpPass";
            this.txtEdEmpPass.Size = new System.Drawing.Size(132, 22);
            this.txtEdEmpPass.TabIndex = 77;
            // 
            // editEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1108, 654);
            this.Controls.Add(this.txtEdEmpPass);
            this.Controls.Add(this.txtEdEmpEmail);
            this.Controls.Add(this.txtEdEmpPost);
            this.Controls.Add(this.txtEdEmpPhone);
            this.Controls.Add(this.txtEdEmpUsern);
            this.Controls.Add(this.txtEdEmpSurname);
            this.Controls.Add(this.txtEdEmpFirstName);
            this.Controls.Add(this.btnEdEmpNext);
            this.Controls.Add(this.btnEditEmpPrev);
            this.Controls.Add(this.dataEmployee);
            this.Controls.Add(this.btnEditEmp);
            this.Controls.Add(this.cboxEdPrivilege);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEdPassword);
            this.Controls.Add(this.lblEdUsername);
            this.Controls.Add(this.lblEdEmail);
            this.Controls.Add(this.lblEdPhoneNumber);
            this.Controls.Add(this.lblEdPostcode);
            this.Controls.Add(this.lblEdSurname);
            this.Controls.Add(this.lblEdFirstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblEditEmp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "editEmployee";
            this.Text = "Edit Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dataEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEditEmp;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.CheckBox cboxEdPrivilege;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEdPassword;
        private System.Windows.Forms.Label lblEdUsername;
        private System.Windows.Forms.Label lblEdEmail;
        private System.Windows.Forms.Label lblEdPhoneNumber;
        private System.Windows.Forms.Label lblEdPostcode;
        private System.Windows.Forms.Label lblEdSurname;
        private System.Windows.Forms.Label lblEdFirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataEmployee;
        private System.Windows.Forms.Button btnEditEmpPrev;
        private System.Windows.Forms.Button btnEdEmpNext;
        private System.Windows.Forms.TextBox txtEdEmpFirstName;
        private System.Windows.Forms.TextBox txtEdEmpSurname;
        private System.Windows.Forms.TextBox txtEdEmpUsern;
        private System.Windows.Forms.TextBox txtEdEmpPhone;
        private System.Windows.Forms.TextBox txtEdEmpPost;
        private System.Windows.Forms.TextBox txtEdEmpEmail;
        private System.Windows.Forms.TextBox txtEdEmpPass;
    }
}