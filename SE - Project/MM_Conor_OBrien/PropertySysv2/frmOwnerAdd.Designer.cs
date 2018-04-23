namespace PropertySysv2
{
    partial class frmOwnerAdd
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpOwner = new System.Windows.Forms.GroupBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxCounty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxAdd2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxAdd1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpOwner.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Enabled = false;
            this.txtOwnerID.Location = new System.Drawing.Point(105, 54);
            this.txtOwnerID.MaxLength = 4;
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(49, 20);
            this.txtOwnerID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Owner ID";
            // 
            // grpOwner
            // 
            this.grpOwner.Controls.Add(this.txtForename);
            this.grpOwner.Controls.Add(this.label9);
            this.grpOwner.Controls.Add(this.txtBoxCounty);
            this.grpOwner.Controls.Add(this.label7);
            this.grpOwner.Controls.Add(this.txtBoxAdd2);
            this.grpOwner.Controls.Add(this.label1);
            this.grpOwner.Controls.Add(this.txtSurname);
            this.grpOwner.Controls.Add(this.label6);
            this.grpOwner.Controls.Add(this.btnAdd);
            this.grpOwner.Controls.Add(this.txtBoxAdd1);
            this.grpOwner.Controls.Add(this.txtEmail);
            this.grpOwner.Controls.Add(this.txtPhone);
            this.grpOwner.Controls.Add(this.label4);
            this.grpOwner.Controls.Add(this.label3);
            this.grpOwner.Controls.Add(this.label2);
            this.grpOwner.Location = new System.Drawing.Point(21, 91);
            this.grpOwner.Name = "grpOwner";
            this.grpOwner.Size = new System.Drawing.Size(335, 250);
            this.grpOwner.TabIndex = 18;
            this.grpOwner.TabStop = false;
            this.grpOwner.Text = "Enter Owner Details";
            this.grpOwner.Enter += new System.EventHandler(this.grpOwner_Enter);
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(94, 22);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(123, 20);
            this.txtForename.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Forename:";
            // 
            // txtBoxCounty
            // 
            this.txtBoxCounty.Location = new System.Drawing.Point(94, 128);
            this.txtBoxCounty.Name = "txtBoxCounty";
            this.txtBoxCounty.Size = new System.Drawing.Size(123, 20);
            this.txtBoxCounty.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "County:";
            // 
            // txtBoxAdd2
            // 
            this.txtBoxAdd2.Location = new System.Drawing.Point(94, 99);
            this.txtBoxAdd2.Name = "txtBoxAdd2";
            this.txtBoxAdd2.Size = new System.Drawing.Size(123, 20);
            this.txtBoxAdd2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Address Line 2:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 19);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Owner";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtBoxAdd1
            // 
            this.txtBoxAdd1.Location = new System.Drawing.Point(94, 71);
            this.txtBoxAdd1.Name = "txtBoxAdd1";
            this.txtBoxAdd1.Size = new System.Drawing.Size(123, 20);
            this.txtBoxAdd1.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(94, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(94, 154);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(123, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(94, 46);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(123, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Address Line 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Surname:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // frmOwnerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(406, 361);
            this.Controls.Add(this.grpOwner);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOwnerAdd";
            this.Text = "Add Owner";
            this.Load += new System.EventHandler(this.frmOwnerAdd_Load);
            this.grpOwner.ResumeLayout(false);
            this.grpOwner.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpOwner;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxCounty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxAdd2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxAdd1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
    }
}

