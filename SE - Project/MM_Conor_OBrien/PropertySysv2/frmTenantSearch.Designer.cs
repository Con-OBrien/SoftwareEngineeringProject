namespace PropertySysv2
{
    partial class frmTenantSearch
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
            this.txtSearchTenant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grdTenants = new System.Windows.Forms.DataGridView();
            this.TenantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTenants = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).BeginInit();
            this.grpTenants.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 27);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search:";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchTenant
            // 
            this.txtSearchTenant.Location = new System.Drawing.Point(139, 38);
            this.txtSearchTenant.Name = "txtSearchTenant";
            this.txtSearchTenant.Size = new System.Drawing.Size(114, 20);
            this.txtSearchTenant.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search for Surname: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 32;
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
            this.grdTenants.Location = new System.Drawing.Point(15, 123);
            this.grdTenants.Name = "grdTenants";
            this.grdTenants.Size = new System.Drawing.Size(346, 96);
            this.grdTenants.TabIndex = 33;
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
            // grpTenants
            // 
            this.grpTenants.Controls.Add(this.textBox1);
            this.grpTenants.Controls.Add(this.label8);
            this.grpTenants.Controls.Add(this.textBox2);
            this.grpTenants.Controls.Add(this.textBox3);
            this.grpTenants.Controls.Add(this.textBox4);
            this.grpTenants.Controls.Add(this.textBox5);
            this.grpTenants.Controls.Add(this.label10);
            this.grpTenants.Controls.Add(this.label11);
            this.grpTenants.Controls.Add(this.label12);
            this.grpTenants.Controls.Add(this.label13);
            this.grpTenants.Location = new System.Drawing.Point(15, 240);
            this.grpTenants.Name = "grpTenants";
            this.grpTenants.Size = new System.Drawing.Size(335, 218);
            this.grpTenants.TabIndex = 34;
            this.grpTenants.TabStop = false;
            this.grpTenants.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Surname:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 161);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 20);
            this.textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(124, 20);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(95, 29);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(124, 20);
            this.textBox5.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "DOB:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Phone:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Forename:";
            // 
            // frmTenantSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 470);
            this.Controls.Add(this.grpTenants);
            this.Controls.Add(this.grdTenants);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchTenant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTenantSearch";
            this.Text = "frmTenantSearch";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTenants)).EndInit();
            this.grpTenants.ResumeLayout(false);
            this.grpTenants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchTenant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DataGridView grdTenants;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn Town;
        private System.Windows.Forms.GroupBox grpTenants;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}