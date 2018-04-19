namespace PropertySysv2
{
    partial class frmOwnerRemove
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtOwnerSearch = new System.Windows.Forms.TextBox();
            this.btnRmv = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.Button();
            this.grpOwner = new System.Windows.Forms.GroupBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxCounty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxAdd2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxAdd1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the OwnerID:";
            // 
            // txtOwnerSearch
            // 
            this.txtOwnerSearch.Location = new System.Drawing.Point(116, 37);
            this.txtOwnerSearch.Name = "txtOwnerSearch";
            this.txtOwnerSearch.Size = new System.Drawing.Size(133, 20);
            this.txtOwnerSearch.TabIndex = 1;
            // 
            // btnRmv
            // 
            this.btnRmv.Location = new System.Drawing.Point(6, 206);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(89, 24);
            this.btnRmv.TabIndex = 2;
            this.btnRmv.Text = "Remove Owner";
            this.btnRmv.UseVisualStyleBackColor = true;
            this.btnRmv.Click += new System.EventHandler(this.btnRmv_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(97, 24);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Text = "Search";
            this.txtSearch.UseVisualStyleBackColor = true;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // grpOwner
            // 
            this.grpOwner.Controls.Add(this.txtForename);
            this.grpOwner.Controls.Add(this.label9);
            this.grpOwner.Controls.Add(this.btnRmv);
            this.grpOwner.Controls.Add(this.txtBoxCounty);
            this.grpOwner.Controls.Add(this.label7);
            this.grpOwner.Controls.Add(this.txtBoxAdd2);
            this.grpOwner.Controls.Add(this.label6);
            this.grpOwner.Controls.Add(this.txtBoxAdd1);
            this.grpOwner.Controls.Add(this.txtEmail);
            this.grpOwner.Controls.Add(this.txtPhone);
            this.grpOwner.Controls.Add(this.txtSurname);
            this.grpOwner.Controls.Add(this.label4);
            this.grpOwner.Controls.Add(this.label3);
            this.grpOwner.Controls.Add(this.label2);
            this.grpOwner.Controls.Add(this.label5);
            this.grpOwner.Location = new System.Drawing.Point(15, 122);
            this.grpOwner.Name = "grpOwner";
            this.grpOwner.Size = new System.Drawing.Size(335, 250);
            this.grpOwner.TabIndex = 22;
            this.grpOwner.TabStop = false;
            this.grpOwner.Text = "Update Owner Details";
            this.grpOwner.Visible = false;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(94, 48);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(123, 20);
            this.txtForename.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 51);
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
            this.txtSurname.Location = new System.Drawing.Point(94, 25);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(123, 20);
            this.txtSurname.TabIndex = 0;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Surname:";
            // 
            // frmOwnerRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 384);
            this.Controls.Add(this.grpOwner);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtOwnerSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOwnerRemove";
            this.Text = "Remove Owner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpOwner.ResumeLayout(false);
            this.grpOwner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOwnerSearch;
        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.GroupBox grpOwner;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxCounty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxAdd2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxAdd1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}