namespace PropertySysv2
{
    partial class frmOwnerUpd
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
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpOwner = new System.Windows.Forms.GroupBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtBoxCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtBoxAdd2 = new System.Windows.Forms.TextBox();
            this.lblAdd2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBoxAdd1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblAdd1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.grdOwners = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtOwnerSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpOwner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOwners)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpOwner
            // 
            this.grpOwner.Controls.Add(this.txtForename);
            this.grpOwner.Controls.Add(this.lblForename);
            this.grpOwner.Controls.Add(this.txtBoxCounty);
            this.grpOwner.Controls.Add(this.lblCounty);
            this.grpOwner.Controls.Add(this.txtBoxAdd2);
            this.grpOwner.Controls.Add(this.lblAdd2);
            this.grpOwner.Controls.Add(this.btnUpdate);
            this.grpOwner.Controls.Add(this.txtBoxAdd1);
            this.grpOwner.Controls.Add(this.txtEmail);
            this.grpOwner.Controls.Add(this.txtPhone);
            this.grpOwner.Controls.Add(this.txtSurname);
            this.grpOwner.Controls.Add(this.lblAdd1);
            this.grpOwner.Controls.Add(this.lblEmail);
            this.grpOwner.Controls.Add(this.lblPhone);
            this.grpOwner.Controls.Add(this.lblSurname);
            this.grpOwner.Location = new System.Drawing.Point(25, 208);
            this.grpOwner.Name = "grpOwner";
            this.grpOwner.Size = new System.Drawing.Size(335, 250);
            this.grpOwner.TabIndex = 21;
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
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(11, 51);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 31;
            this.lblForename.Text = "Forename:";
            // 
            // txtBoxCounty
            // 
            this.txtBoxCounty.Location = new System.Drawing.Point(94, 128);
            this.txtBoxCounty.Name = "txtBoxCounty";
            this.txtBoxCounty.Size = new System.Drawing.Size(123, 20);
            this.txtBoxCounty.TabIndex = 4;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(11, 131);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(43, 13);
            this.lblCounty.TabIndex = 29;
            this.lblCounty.Text = "County:";
            // 
            // txtBoxAdd2
            // 
            this.txtBoxAdd2.Location = new System.Drawing.Point(94, 99);
            this.txtBoxAdd2.Name = "txtBoxAdd2";
            this.txtBoxAdd2.Size = new System.Drawing.Size(123, 20);
            this.txtBoxAdd2.TabIndex = 3;
            // 
            // lblAdd2
            // 
            this.lblAdd2.AutoSize = true;
            this.lblAdd2.Location = new System.Drawing.Point(11, 102);
            this.lblAdd2.Name = "lblAdd2";
            this.lblAdd2.Size = new System.Drawing.Size(80, 13);
            this.lblAdd2.TabIndex = 27;
            this.lblAdd2.Text = "Address Line 2:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 24);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update Owner";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // lblAdd1
            // 
            this.lblAdd1.AutoSize = true;
            this.lblAdd1.Location = new System.Drawing.Point(11, 74);
            this.lblAdd1.Name = "lblAdd1";
            this.lblAdd1.Size = new System.Drawing.Size(80, 13);
            this.lblAdd1.TabIndex = 21;
            this.lblAdd1.Text = "Address Line 1:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 180);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(11, 157);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(11, 28);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 18;
            this.lblSurname.Text = "Surname:";
            // 
            // grdOwners
            // 
            this.grdOwners.AllowUserToAddRows = false;
            this.grdOwners.AllowUserToDeleteRows = false;
            this.grdOwners.AllowUserToResizeColumns = false;
            this.grdOwners.AllowUserToResizeRows = false;
            this.grdOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOwners.GridColor = System.Drawing.SystemColors.Info;
            this.grdOwners.Location = new System.Drawing.Point(25, 70);
            this.grdOwners.MultiSelect = false;
            this.grdOwners.Name = "grdOwners";
            this.grdOwners.ReadOnly = true;
            this.grdOwners.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdOwners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdOwners.Size = new System.Drawing.Size(502, 123);
            this.grdOwners.TabIndex = 36;
            this.grdOwners.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(307, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 23);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtOwnerSearch
            // 
            this.txtOwnerSearch.Location = new System.Drawing.Point(108, 34);
            this.txtOwnerSearch.Name = "txtOwnerSearch";
            this.txtOwnerSearch.Size = new System.Drawing.Size(178, 20);
            this.txtOwnerSearch.TabIndex = 34;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(22, 36);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(80, 13);
            this.lblSearch.TabIndex = 33;
            this.lblSearch.Text = "Enter Surname:";
            // 
            // frmOwnerUpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 476);
            this.Controls.Add(this.grdOwners);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtOwnerSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.grpOwner);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOwnerUpd";
            this.Text = "Update Owner";
            this.Load += new System.EventHandler(this.frmOwnerUpd_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpOwner.ResumeLayout(false);
            this.grpOwner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOwners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpOwner;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtBoxCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtBoxAdd2;
        private System.Windows.Forms.Label lblAdd2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxAdd1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblAdd1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.DataGridView grdOwners;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtOwnerSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}