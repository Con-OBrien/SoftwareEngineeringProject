namespace PropertySysv2
{
    partial class frmOwnerSearch
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpOwner = new System.Windows.Forms.GroupBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpOwner.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for OwnerID: ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(141, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(114, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(31, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search:";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpOwner
            // 
            this.grpOwner.Controls.Add(this.txtForename);
            this.grpOwner.Controls.Add(this.label9);
            this.grpOwner.Controls.Add(this.txtCounty);
            this.grpOwner.Controls.Add(this.label7);
            this.grpOwner.Controls.Add(this.txtAdd2);
            this.grpOwner.Controls.Add(this.label6);
            this.grpOwner.Controls.Add(this.txtAdd1);
            this.grpOwner.Controls.Add(this.txtEmail);
            this.grpOwner.Controls.Add(this.txtPhone);
            this.grpOwner.Controls.Add(this.txtSurname);
            this.grpOwner.Controls.Add(this.label4);
            this.grpOwner.Controls.Add(this.label3);
            this.grpOwner.Controls.Add(this.label2);
            this.grpOwner.Controls.Add(this.label5);
            this.grpOwner.Location = new System.Drawing.Point(31, 113);
            this.grpOwner.Name = "grpOwner";
            this.grpOwner.Size = new System.Drawing.Size(335, 252);
            this.grpOwner.TabIndex = 26;
            this.grpOwner.TabStop = false;
            this.grpOwner.Visible = false;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(91, 51);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(124, 20);
            this.txtForename.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Forename:";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(90, 201);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(122, 20);
            this.txtCounty.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "County";
            // 
            // txtAdd2
            // 
            this.txtAdd2.Location = new System.Drawing.Point(91, 169);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(123, 20);
            this.txtAdd2.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Address Line 2";
            // 
            // txtAdd1
            // 
            this.txtAdd1.Location = new System.Drawing.Point(91, 141);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(123, 20);
            this.txtAdd1.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 109);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPhone.Location = new System.Drawing.Point(90, 79);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(124, 20);
            this.txtPhone.TabIndex = 23;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(91, 25);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(124, 20);
            this.txtSurname.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Address Line 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Surname:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(391, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // frmOwnerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 379);
            this.Controls.Add(this.grpOwner);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOwnerSearch";
            this.Text = "Search Owner";
            this.Load += new System.EventHandler(this.frmOwnerSearch_Load);
            this.grpOwner.ResumeLayout(false);
            this.grpOwner.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpOwner;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
    }
}