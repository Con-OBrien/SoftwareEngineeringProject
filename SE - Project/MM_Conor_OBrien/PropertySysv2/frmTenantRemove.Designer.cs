namespace PropertySysv2
{
    partial class frmTenantRemove
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
            this.txtTenantSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grdTenants = new System.Windows.Forms.DataGridView();
            this.TenantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRmv
            // 
            this.btnRmv.Location = new System.Drawing.Point(12, 195);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(97, 28);
            this.btnRmv.TabIndex = 27;
            this.btnRmv.Text = "Remove Tenant";
            this.btnRmv.UseVisualStyleBackColor = true;
            this.btnRmv.Click += new System.EventHandler(this.btnRmv_Click);
            // 
            // txtTenantSearch
            // 
            this.txtTenantSearch.Location = new System.Drawing.Point(139, 46);
            this.txtTenantSearch.Name = "txtTenantSearch";
            this.txtTenantSearch.Size = new System.Drawing.Size(133, 20);
            this.txtTenantSearch.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Enter TenantID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
            this.menuStrip1.TabIndex = 30;
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
            this.grdTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTenants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenantID,
            this.Street,
            this.Town});
            this.grdTenants.Location = new System.Drawing.Point(15, 83);
            this.grdTenants.Name = "grdTenants";
            this.grdTenants.Size = new System.Drawing.Size(346, 96);
            this.grdTenants.TabIndex = 31;
            this.grdTenants.Visible = false;
            // 
            // TenantID
            // 
            this.TenantID.HeaderText = "Tenant ID";
            this.TenantID.Name = "TenantID";
            // 
            // Street
            // 
            this.Street.HeaderText = "Forename";
            this.Street.Name = "Street";
            // 
            // Town
            // 
            this.Town.HeaderText = "Surname";
            this.Town.Name = "Town";
            // 
            // frmTenantRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 254);
            this.Controls.Add(this.grdTenants);
            this.Controls.Add(this.btnRmv);
            this.Controls.Add(this.txtTenantSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTenantRemove";
            this.Text = "Remove Tenant";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.TextBox txtTenantSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DataGridView grdTenants;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn Town;
    }
}