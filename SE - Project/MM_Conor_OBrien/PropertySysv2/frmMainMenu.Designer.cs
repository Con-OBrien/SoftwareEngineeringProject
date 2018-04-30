namespace PropertySysv2
{
    partial class frmMainMenu
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
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuOwner = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddOwner = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateOwner = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveOwner = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchOwner = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTenant = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateTenant = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveTenant = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchTenant = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCalculateRent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOwner,
            this.mnuProperty,
            this.mnuTenant,
            this.mnuAdmin,
            this.mnuExit});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(603, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuOwner
            // 
            this.mnuOwner.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddOwner,
            this.mnuUpdateOwner,
            this.mnuRemoveOwner,
            this.mnuSearchOwner});
            this.mnuOwner.Name = "mnuOwner";
            this.mnuOwner.Size = new System.Drawing.Size(59, 20);
            this.mnuOwner.Text = "Owners";
            // 
            // mnuAddOwner
            // 
            this.mnuAddOwner.Name = "mnuAddOwner";
            this.mnuAddOwner.Size = new System.Drawing.Size(155, 22);
            this.mnuAddOwner.Text = "Add Owner";
            this.mnuAddOwner.Click += new System.EventHandler(this.mnuAddOwner_Click);
            // 
            // mnuUpdateOwner
            // 
            this.mnuUpdateOwner.Name = "mnuUpdateOwner";
            this.mnuUpdateOwner.Size = new System.Drawing.Size(155, 22);
            this.mnuUpdateOwner.Text = "Update Owner";
            this.mnuUpdateOwner.Click += new System.EventHandler(this.mnuUpdateOwner_Click);
            // 
            // mnuRemoveOwner
            // 
            this.mnuRemoveOwner.Name = "mnuRemoveOwner";
            this.mnuRemoveOwner.Size = new System.Drawing.Size(155, 22);
            this.mnuRemoveOwner.Text = "Remove Owner";
            this.mnuRemoveOwner.Click += new System.EventHandler(this.mnuRemoveOwner_Click);
            // 
            // mnuSearchOwner
            // 
            this.mnuSearchOwner.Name = "mnuSearchOwner";
            this.mnuSearchOwner.Size = new System.Drawing.Size(155, 22);
            this.mnuSearchOwner.Text = "Search Owner";
            this.mnuSearchOwner.Click += new System.EventHandler(this.mnuSearchOwner_Click);
            // 
            // mnuProperty
            // 
            this.mnuProperty.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddProperty,
            this.mnuUpdateProperty,
            this.mnuRemoveProperty,
            this.mnuSearchProperty});
            this.mnuProperty.Name = "mnuProperty";
            this.mnuProperty.Size = new System.Drawing.Size(72, 20);
            this.mnuProperty.Text = "Properties";
            // 
            // mnuAddProperty
            // 
            this.mnuAddProperty.Name = "mnuAddProperty";
            this.mnuAddProperty.Size = new System.Drawing.Size(165, 22);
            this.mnuAddProperty.Text = "Add Property";
            this.mnuAddProperty.Click += new System.EventHandler(this.mnuAddProperty_Click);
            // 
            // mnuUpdateProperty
            // 
            this.mnuUpdateProperty.Name = "mnuUpdateProperty";
            this.mnuUpdateProperty.Size = new System.Drawing.Size(165, 22);
            this.mnuUpdateProperty.Text = "Update Property";
            this.mnuUpdateProperty.Click += new System.EventHandler(this.mnuUpdateProperty_Click);
            // 
            // mnuRemoveProperty
            // 
            this.mnuRemoveProperty.Name = "mnuRemoveProperty";
            this.mnuRemoveProperty.Size = new System.Drawing.Size(165, 22);
            this.mnuRemoveProperty.Text = "Remove Property";
            this.mnuRemoveProperty.Click += new System.EventHandler(this.mnuRemoveProperty_Click);
            // 
            // mnuSearchProperty
            // 
            this.mnuSearchProperty.Name = "mnuSearchProperty";
            this.mnuSearchProperty.Size = new System.Drawing.Size(165, 22);
            this.mnuSearchProperty.Text = "Search Property";
            this.mnuSearchProperty.Click += new System.EventHandler(this.mnuSearchProperty_Click);
            // 
            // mnuTenant
            // 
            this.mnuTenant.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRentProperty,
            this.mnuUpdateTenant,
            this.mnuRemoveTenant,
            this.mnuSearchTenant});
            this.mnuTenant.Name = "mnuTenant";
            this.mnuTenant.Size = new System.Drawing.Size(60, 20);
            this.mnuTenant.Text = "Tenants";
            // 
            // mnuRentProperty
            // 
            this.mnuRentProperty.Name = "mnuRentProperty";
            this.mnuRentProperty.Size = new System.Drawing.Size(156, 22);
            this.mnuRentProperty.Text = "Rent Property";
            this.mnuRentProperty.Click += new System.EventHandler(this.mnuRentProperty_Click);
            // 
            // mnuUpdateTenant
            // 
            this.mnuUpdateTenant.Name = "mnuUpdateTenant";
            this.mnuUpdateTenant.Size = new System.Drawing.Size(156, 22);
            this.mnuUpdateTenant.Text = "Update Tenant";
            this.mnuUpdateTenant.Click += new System.EventHandler(this.mnuUpdateTenant_Click);
            // 
            // mnuRemoveTenant
            // 
            this.mnuRemoveTenant.Name = "mnuRemoveTenant";
            this.mnuRemoveTenant.Size = new System.Drawing.Size(156, 22);
            this.mnuRemoveTenant.Text = "Remove Tenant";
            this.mnuRemoveTenant.Click += new System.EventHandler(this.mnuRemoveTenant_Click);
            // 
            // mnuSearchTenant
            // 
            this.mnuSearchTenant.Name = "mnuSearchTenant";
            this.mnuSearchTenant.Size = new System.Drawing.Size(156, 22);
            this.mnuSearchTenant.Text = "Search Tenant";
            this.mnuSearchTenant.Click += new System.EventHandler(this.mnuSearchTenant_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCalculateRent});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuCalculateRent
            // 
            this.mnuCalculateRent.Name = "mnuCalculateRent";
            this.mnuCalculateRent.Size = new System.Drawing.Size(150, 22);
            this.mnuCalculateRent.Text = "Calculate Rent";
            this.mnuCalculateRent.Click += new System.EventHandler(this.mnuCalculateRent_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PropertySysv2.Properties.Resources.Rental_Property;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 403);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(603, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainMenu";
            this.Text = "O\'Brien Property Rentals";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuOwner;
        private System.Windows.Forms.ToolStripMenuItem mnuAddOwner;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateOwner;
        private System.Windows.Forms.ToolStripMenuItem mnuProperty;
        private System.Windows.Forms.ToolStripMenuItem mnuTenant;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveOwner;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchOwner;
        private System.Windows.Forms.ToolStripMenuItem mnuAddProperty;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateProperty;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveProperty;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchProperty;
        private System.Windows.Forms.ToolStripMenuItem mnuRentProperty;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateTenant;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveTenant;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchTenant;
        private System.Windows.Forms.ToolStripMenuItem mnuCalculateRent;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}