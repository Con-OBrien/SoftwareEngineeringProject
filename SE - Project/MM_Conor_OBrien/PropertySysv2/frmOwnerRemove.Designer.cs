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
            this.btnRmv = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpOwners = new System.Windows.Forms.GroupBox();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
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
            this.grdOwners = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtOwnerSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpOwners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOwners)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRmv
            // 
            this.btnRmv.Location = new System.Drawing.Point(11, 221);
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
            // grpOwners
            // 
            this.grpOwners.Controls.Add(this.txtOwnerID);
            this.grpOwners.Controls.Add(this.txtForename);
            this.grpOwners.Controls.Add(this.label9);
            this.grpOwners.Controls.Add(this.btnRmv);
            this.grpOwners.Controls.Add(this.txtBoxCounty);
            this.grpOwners.Controls.Add(this.label7);
            this.grpOwners.Controls.Add(this.txtBoxAdd2);
            this.grpOwners.Controls.Add(this.label6);
            this.grpOwners.Controls.Add(this.txtBoxAdd1);
            this.grpOwners.Controls.Add(this.txtEmail);
            this.grpOwners.Controls.Add(this.txtPhone);
            this.grpOwners.Controls.Add(this.txtSurname);
            this.grpOwners.Controls.Add(this.label4);
            this.grpOwners.Controls.Add(this.label3);
            this.grpOwners.Controls.Add(this.label2);
            this.grpOwners.Controls.Add(this.label5);
            this.grpOwners.Location = new System.Drawing.Point(12, 202);
            this.grpOwners.Name = "grpOwners";
            this.grpOwners.Size = new System.Drawing.Size(335, 272);
            this.grpOwners.TabIndex = 22;
            this.grpOwners.TabStop = false;
            this.grpOwners.Text = "Update Owner Details";
            this.grpOwners.Visible = false;
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(122, 14);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(14, 20);
            this.txtOwnerID.TabIndex = 32;
            this.txtOwnerID.Visible = false;
            // 
            // txtForename
            // 
            this.txtForename.Enabled = false;
            this.txtForename.Location = new System.Drawing.Point(99, 63);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(123, 20);
            this.txtForename.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Forename:";
            // 
            // txtBoxCounty
            // 
            this.txtBoxCounty.Enabled = false;
            this.txtBoxCounty.Location = new System.Drawing.Point(99, 143);
            this.txtBoxCounty.Name = "txtBoxCounty";
            this.txtBoxCounty.Size = new System.Drawing.Size(123, 20);
            this.txtBoxCounty.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "County:";
            // 
            // txtBoxAdd2
            // 
            this.txtBoxAdd2.Enabled = false;
            this.txtBoxAdd2.Location = new System.Drawing.Point(99, 114);
            this.txtBoxAdd2.Name = "txtBoxAdd2";
            this.txtBoxAdd2.Size = new System.Drawing.Size(123, 20);
            this.txtBoxAdd2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Address Line 2:";
            // 
            // txtBoxAdd1
            // 
            this.txtBoxAdd1.Enabled = false;
            this.txtBoxAdd1.Location = new System.Drawing.Point(99, 88);
            this.txtBoxAdd1.Name = "txtBoxAdd1";
            this.txtBoxAdd1.Size = new System.Drawing.Size(123, 20);
            this.txtBoxAdd1.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(99, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(99, 169);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(123, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(99, 40);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(123, 20);
            this.txtSurname.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Address Line 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Surname:";
            // 
            // grdOwners
            // 
            this.grdOwners.AllowUserToAddRows = false;
            this.grdOwners.AllowUserToDeleteRows = false;
            this.grdOwners.AllowUserToResizeColumns = false;
            this.grdOwners.AllowUserToResizeRows = false;
            this.grdOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOwners.GridColor = System.Drawing.SystemColors.Info;
            this.grdOwners.Location = new System.Drawing.Point(12, 58);
            this.grdOwners.MultiSelect = false;
            this.grdOwners.Name = "grdOwners";
            this.grdOwners.ReadOnly = true;
            this.grdOwners.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdOwners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdOwners.Size = new System.Drawing.Size(502, 123);
            this.grdOwners.TabIndex = 40;
            this.grdOwners.Visible = false;
            this.grdOwners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOwners_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(305, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 23);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtOwnerSearch
            // 
            this.txtOwnerSearch.Location = new System.Drawing.Point(106, 31);
            this.txtOwnerSearch.Name = "txtOwnerSearch";
            this.txtOwnerSearch.Size = new System.Drawing.Size(178, 20);
            this.txtOwnerSearch.TabIndex = 38;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 33);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(80, 13);
            this.lblSearch.TabIndex = 37;
            this.lblSearch.Text = "Enter Surname:";
            // 
            // frmOwnerRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 195);
            this.Controls.Add(this.grdOwners);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtOwnerSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.grpOwners);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOwnerRemove";
            this.Text = "Remove Owner";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpOwners.ResumeLayout(false);
            this.grpOwners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOwners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpOwners;
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
        private System.Windows.Forms.DataGridView grdOwners;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtOwnerSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtOwnerID;
    }
}