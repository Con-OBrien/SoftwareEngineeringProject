namespace PropertySysv2
{
    partial class frmRentProperty
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
            this.txtTenantID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTenants = new System.Windows.Forms.GroupBox();
            this.txtPropID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cboProperty = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpTenants.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenantID
            // 
            this.txtTenantID.Enabled = false;
            this.txtTenantID.Location = new System.Drawing.Point(89, 43);
            this.txtTenantID.MaxLength = 4;
            this.txtTenantID.Name = "txtTenantID";
            this.txtTenantID.Size = new System.Drawing.Size(49, 20);
            this.txtTenantID.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tenant ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Select your Property";
            // 
            // grpTenants
            // 
            this.grpTenants.Controls.Add(this.txtPropID);
            this.grpTenants.Controls.Add(this.label3);
            this.grpTenants.Controls.Add(this.txtSurname);
            this.grpTenants.Controls.Add(this.label2);
            this.grpTenants.Controls.Add(this.btnAdd);
            this.grpTenants.Controls.Add(this.txtDOB);
            this.grpTenants.Controls.Add(this.txtEmail);
            this.grpTenants.Controls.Add(this.txtPhone);
            this.grpTenants.Controls.Add(this.txtForename);
            this.grpTenants.Controls.Add(this.label10);
            this.grpTenants.Controls.Add(this.label11);
            this.grpTenants.Controls.Add(this.label12);
            this.grpTenants.Controls.Add(this.label13);
            this.grpTenants.Location = new System.Drawing.Point(12, 259);
            this.grpTenants.Name = "grpTenants";
            this.grpTenants.Size = new System.Drawing.Size(335, 263);
            this.grpTenants.TabIndex = 34;
            this.grpTenants.TabStop = false;
            this.grpTenants.Text = "Enter Tenant Details";
            this.grpTenants.Visible = false;
            // 
            // txtPropID
            // 
            this.txtPropID.Enabled = false;
            this.txtPropID.Location = new System.Drawing.Point(104, 25);
            this.txtPropID.Name = "txtPropID";
            this.txtPropID.Size = new System.Drawing.Size(124, 20);
            this.txtPropID.TabIndex = 34;
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Property ID:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(104, 89);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(124, 20);
            this.txtSurname.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Surname:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 19);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add Tenant";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(105, 187);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(123, 20);
            this.txtDOB.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(104, 123);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(124, 20);
            this.txtPhone.TabIndex = 23;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(104, 55);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(124, 20);
            this.txtForename.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "DOB:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Phone:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Forename:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // cboProperty
            // 
            this.cboProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProperty.FormattingEnabled = true;
            this.cboProperty.Location = new System.Drawing.Point(15, 105);
            this.cboProperty.Name = "cboProperty";
            this.cboProperty.Size = new System.Drawing.Size(169, 21);
            this.cboProperty.TabIndex = 36;
            this.cboProperty.SelectedIndexChanged += new System.EventHandler(this.cboProperty_SelectedIndexChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(12, 166);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 37;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(12, 223);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "End Date:";
            // 
            // frmRentProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 551);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cboProperty);
            this.Controls.Add(this.grpTenants);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenantID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRentProperty";
            this.Text = "frmRentProperty";
            this.Load += new System.EventHandler(this.frmRentProperty_Load);
            this.grpTenants.ResumeLayout(false);
            this.grpTenants.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenantID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTenants;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ComboBox cboProperty;
        private System.Windows.Forms.TextBox txtPropID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}