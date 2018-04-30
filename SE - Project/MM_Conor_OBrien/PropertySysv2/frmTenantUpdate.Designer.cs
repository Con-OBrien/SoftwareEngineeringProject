namespace PropertySysv2
{
    partial class frmTenantUpdate
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTenantSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTenants = new System.Windows.Forms.GroupBox();
            this.txtTenantID = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grdTenants = new System.Windows.Forms.DataGridView();
            this.grpTenants.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(305, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTenantSearch
            // 
            this.txtTenantSearch.Location = new System.Drawing.Point(106, 56);
            this.txtTenantSearch.Name = "txtTenantSearch";
            this.txtTenantSearch.Size = new System.Drawing.Size(178, 20);
            this.txtTenantSearch.TabIndex = 26;
            this.txtTenantSearch.TextChanged += new System.EventHandler(this.txtTenantSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Enter Surname:";
            // 
            // grpTenants
            // 
            this.grpTenants.Controls.Add(this.txtTenantID);
            this.grpTenants.Controls.Add(this.txtSurname);
            this.grpTenants.Controls.Add(this.label8);
            this.grpTenants.Controls.Add(this.btnUpdate);
            this.grpTenants.Controls.Add(this.txtEmail);
            this.grpTenants.Controls.Add(this.txtPhone);
            this.grpTenants.Controls.Add(this.txtForename);
            this.grpTenants.Controls.Add(this.label11);
            this.grpTenants.Controls.Add(this.label12);
            this.grpTenants.Controls.Add(this.label13);
            this.grpTenants.Location = new System.Drawing.Point(23, 224);
            this.grpTenants.Name = "grpTenants";
            this.grpTenants.Size = new System.Drawing.Size(335, 227);
            this.grpTenants.TabIndex = 30;
            this.grpTenants.TabStop = false;
            this.grpTenants.Text = "Enter Tenant Details";
            this.grpTenants.Visible = false;
            this.grpTenants.Enter += new System.EventHandler(this.grpTenants_Enter);
            // 
            // txtTenantID
            // 
            this.txtTenantID.Location = new System.Drawing.Point(9, 19);
            this.txtTenantID.Name = "txtTenantID";
            this.txtTenantID.Size = new System.Drawing.Size(28, 20);
            this.txtTenantID.TabIndex = 33;
            this.txtTenantID.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(95, 79);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(124, 20);
            this.txtSurname.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Surname:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 169);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 19);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update Tenant";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(96, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(95, 113);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(124, 20);
            this.txtPhone.TabIndex = 23;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(95, 45);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(124, 20);
            this.txtForename.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Phone:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 45);
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
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grdTenants
            // 
            this.grdTenants.AllowUserToAddRows = false;
            this.grdTenants.AllowUserToDeleteRows = false;
            this.grdTenants.AllowUserToResizeColumns = false;
            this.grdTenants.AllowUserToResizeRows = false;
            this.grdTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTenants.GridColor = System.Drawing.SystemColors.Info;
            this.grdTenants.Location = new System.Drawing.Point(23, 82);
            this.grdTenants.MultiSelect = false;
            this.grdTenants.Name = "grdTenants";
            this.grdTenants.ReadOnly = true;
            this.grdTenants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdTenants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdTenants.Size = new System.Drawing.Size(502, 123);
            this.grdTenants.TabIndex = 32;
            this.grdTenants.Visible = false;
            this.grdTenants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTenants_CellClick);
            this.grdTenants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTenants_CellContentClick);
            this.grdTenants.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTenants_CellContentDoubleClick);
            this.grdTenants.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdTenants_RowHeaderMouseClick);
            // 
            // frmTenantUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(563, 463);
            this.Controls.Add(this.grdTenants);
            this.Controls.Add(this.grpTenants);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTenantSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTenantUpdate";
            this.Text = "Update Tenant";
            this.Load += new System.EventHandler(this.frmTenantUpdate_Load);
            this.grpTenants.ResumeLayout(false);
            this.grpTenants.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTenantSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTenants;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DataGridView grdTenants;
        private System.Windows.Forms.TextBox txtTenantID;
    }
}