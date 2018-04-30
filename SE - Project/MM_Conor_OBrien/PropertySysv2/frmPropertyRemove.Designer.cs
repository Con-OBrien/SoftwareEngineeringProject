namespace PropertySysv2
{
    partial class frmPropertyRemove
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
            this.grpProperties = new System.Windows.Forms.GroupBox();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.txtPropID = new System.Windows.Forms.TextBox();
            this.txtOwnerId = new System.Windows.Forms.TextBox();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.txtBedrooms = new System.Windows.Forms.TextBox();
            this.lblBedrooms = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.lblPropAddress2 = new System.Windows.Forms.Label();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.txtBathrooms = new System.Windows.Forms.TextBox();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.lblPropAddress1 = new System.Windows.Forms.Label();
            this.lblHouse = new System.Windows.Forms.Label();
            this.lblBathrooms = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblBeds = new System.Windows.Forms.Label();
            this.cboBeds = new System.Windows.Forms.ComboBox();
            this.cboTown = new System.Windows.Forms.ComboBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grdProperties = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grpProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRmv
            // 
            this.btnRmv.Location = new System.Drawing.Point(9, 317);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(97, 28);
            this.btnRmv.TabIndex = 5;
            this.btnRmv.Text = "Remove Property";
            this.btnRmv.UseVisualStyleBackColor = true;
            this.btnRmv.Visible = false;
            this.btnRmv.Click += new System.EventHandler(this.btnRmv_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpProperties
            // 
            this.grpProperties.Controls.Add(this.txtActivity);
            this.grpProperties.Controls.Add(this.lblActivity);
            this.grpProperties.Controls.Add(this.txtPropID);
            this.grpProperties.Controls.Add(this.txtOwnerId);
            this.grpProperties.Controls.Add(this.lblOwnerID);
            this.grpProperties.Controls.Add(this.btnRmv);
            this.grpProperties.Controls.Add(this.txtBedrooms);
            this.grpProperties.Controls.Add(this.lblBedrooms);
            this.grpProperties.Controls.Add(this.txtCounty);
            this.grpProperties.Controls.Add(this.lblCounty);
            this.grpProperties.Controls.Add(this.txtAdd2);
            this.grpProperties.Controls.Add(this.lblPropAddress2);
            this.grpProperties.Controls.Add(this.txtAdd1);
            this.grpProperties.Controls.Add(this.txtHouse);
            this.grpProperties.Controls.Add(this.txtBathrooms);
            this.grpProperties.Controls.Add(this.txtRent);
            this.grpProperties.Controls.Add(this.lblPropAddress1);
            this.grpProperties.Controls.Add(this.lblHouse);
            this.grpProperties.Controls.Add(this.lblBathrooms);
            this.grpProperties.Controls.Add(this.lblRent);
            this.grpProperties.Location = new System.Drawing.Point(24, 272);
            this.grpProperties.Name = "grpProperties";
            this.grpProperties.Size = new System.Drawing.Size(335, 355);
            this.grpProperties.TabIndex = 31;
            this.grpProperties.TabStop = false;
            this.grpProperties.Text = "Enter Property Details";
            this.grpProperties.Visible = false;
            // 
            // txtActivity
            // 
            this.txtActivity.Location = new System.Drawing.Point(95, 254);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(122, 20);
            this.txtActivity.TabIndex = 54;
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(6, 257);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(44, 13);
            this.lblActivity.TabIndex = 54;
            this.lblActivity.Text = "Activity:";
            // 
            // txtPropID
            // 
            this.txtPropID.Location = new System.Drawing.Point(225, 19);
            this.txtPropID.Name = "txtPropID";
            this.txtPropID.Size = new System.Drawing.Size(14, 20);
            this.txtPropID.TabIndex = 35;
            this.txtPropID.Visible = false;
            // 
            // txtOwnerId
            // 
            this.txtOwnerId.Enabled = false;
            this.txtOwnerId.Location = new System.Drawing.Point(95, 285);
            this.txtOwnerId.Name = "txtOwnerId";
            this.txtOwnerId.Size = new System.Drawing.Size(122, 20);
            this.txtOwnerId.TabIndex = 34;
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(6, 288);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(55, 13);
            this.lblOwnerID.TabIndex = 33;
            this.lblOwnerID.Text = "Owner ID:";
            // 
            // txtBedrooms
            // 
            this.txtBedrooms.Enabled = false;
            this.txtBedrooms.Location = new System.Drawing.Point(95, 63);
            this.txtBedrooms.Name = "txtBedrooms";
            this.txtBedrooms.Size = new System.Drawing.Size(124, 20);
            this.txtBedrooms.TabIndex = 32;
            // 
            // lblBedrooms
            // 
            this.lblBedrooms.AutoSize = true;
            this.lblBedrooms.Location = new System.Drawing.Point(6, 63);
            this.lblBedrooms.Name = "lblBedrooms";
            this.lblBedrooms.Size = new System.Drawing.Size(57, 13);
            this.lblBedrooms.TabIndex = 31;
            this.lblBedrooms.Text = "Bedrooms:";
            // 
            // txtCounty
            // 
            this.txtCounty.Enabled = false;
            this.txtCounty.Location = new System.Drawing.Point(95, 223);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(122, 20);
            this.txtCounty.TabIndex = 30;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(6, 223);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(43, 13);
            this.lblCounty.TabIndex = 29;
            this.lblCounty.Text = "County:";
            // 
            // txtAdd2
            // 
            this.txtAdd2.Enabled = false;
            this.txtAdd2.Location = new System.Drawing.Point(96, 193);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(123, 20);
            this.txtAdd2.TabIndex = 28;
            // 
            // lblPropAddress2
            // 
            this.lblPropAddress2.AutoSize = true;
            this.lblPropAddress2.Location = new System.Drawing.Point(6, 193);
            this.lblPropAddress2.Name = "lblPropAddress2";
            this.lblPropAddress2.Size = new System.Drawing.Size(80, 13);
            this.lblPropAddress2.TabIndex = 27;
            this.lblPropAddress2.Text = "Address Line 2:";
            // 
            // txtAdd1
            // 
            this.txtAdd1.Enabled = false;
            this.txtAdd1.Location = new System.Drawing.Point(96, 161);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(123, 20);
            this.txtAdd1.TabIndex = 25;
            // 
            // txtHouse
            // 
            this.txtHouse.Enabled = false;
            this.txtHouse.Location = new System.Drawing.Point(96, 127);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(123, 20);
            this.txtHouse.TabIndex = 24;
            // 
            // txtBathrooms
            // 
            this.txtBathrooms.Enabled = false;
            this.txtBathrooms.Location = new System.Drawing.Point(95, 97);
            this.txtBathrooms.Name = "txtBathrooms";
            this.txtBathrooms.Size = new System.Drawing.Size(124, 20);
            this.txtBathrooms.TabIndex = 23;
            // 
            // txtRent
            // 
            this.txtRent.Enabled = false;
            this.txtRent.Location = new System.Drawing.Point(95, 29);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(124, 20);
            this.txtRent.TabIndex = 22;
            // 
            // lblPropAddress1
            // 
            this.lblPropAddress1.AutoSize = true;
            this.lblPropAddress1.Location = new System.Drawing.Point(6, 161);
            this.lblPropAddress1.Name = "lblPropAddress1";
            this.lblPropAddress1.Size = new System.Drawing.Size(80, 13);
            this.lblPropAddress1.TabIndex = 21;
            this.lblPropAddress1.Text = "Address Line 1:";
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.Location = new System.Drawing.Point(6, 130);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(68, 13);
            this.lblHouse.TabIndex = 20;
            this.lblHouse.Text = "House Type:";
            // 
            // lblBathrooms
            // 
            this.lblBathrooms.AutoSize = true;
            this.lblBathrooms.Location = new System.Drawing.Point(6, 97);
            this.lblBathrooms.Name = "lblBathrooms";
            this.lblBathrooms.Size = new System.Drawing.Size(60, 13);
            this.lblBathrooms.TabIndex = 19;
            this.lblBathrooms.Text = "Bathrooms:";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Location = new System.Drawing.Point(6, 29);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(83, 13);
            this.lblRent.TabIndex = 18;
            this.lblRent.Text = "Rent per month:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 19);
            this.btnSearch.TabIndex = 53;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBeds
            // 
            this.lblBeds.AutoSize = true;
            this.lblBeds.Location = new System.Drawing.Point(12, 112);
            this.lblBeds.Name = "lblBeds";
            this.lblBeds.Size = new System.Drawing.Size(31, 13);
            this.lblBeds.TabIndex = 52;
            this.lblBeds.Text = "Beds";
            // 
            // cboBeds
            // 
            this.cboBeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBeds.FormattingEnabled = true;
            this.cboBeds.Location = new System.Drawing.Point(49, 109);
            this.cboBeds.Name = "cboBeds";
            this.cboBeds.Size = new System.Drawing.Size(121, 21);
            this.cboBeds.TabIndex = 51;
            // 
            // cboTown
            // 
            this.cboTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTown.FormattingEnabled = true;
            this.cboTown.Location = new System.Drawing.Point(49, 67);
            this.cboTown.Name = "cboTown";
            this.cboTown.Size = new System.Drawing.Size(121, 21);
            this.cboTown.TabIndex = 50;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(9, 70);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(34, 13);
            this.lblTown.TabIndex = 49;
            this.lblTown.Text = "Town";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 41);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(109, 13);
            this.lblSearch.TabIndex = 48;
            this.lblSearch.Text = "Search Requirements";
            // 
            // grdProperties
            // 
            this.grdProperties.AllowUserToAddRows = false;
            this.grdProperties.AllowUserToDeleteRows = false;
            this.grdProperties.AllowUserToResizeColumns = false;
            this.grdProperties.AllowUserToResizeRows = false;
            this.grdProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProperties.GridColor = System.Drawing.SystemColors.Info;
            this.grdProperties.Location = new System.Drawing.Point(15, 167);
            this.grdProperties.MultiSelect = false;
            this.grdProperties.Name = "grdProperties";
            this.grdProperties.ReadOnly = true;
            this.grdProperties.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdProperties.Size = new System.Drawing.Size(502, 100);
            this.grdProperties.TabIndex = 47;
            this.grdProperties.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProperties_CellContentClick);
            // 
            // frmPropertyRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(633, 641);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpProperties);
            this.Controls.Add(this.lblBeds);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cboBeds);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cboTown);
            this.Controls.Add(this.grdProperties);
            this.Controls.Add(this.lblTown);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPropertyRemove";
            this.Text = "Remove Property";
            this.Load += new System.EventHandler(this.frmPropertyRemove_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpProperties.ResumeLayout(false);
            this.grpProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpProperties;
        private System.Windows.Forms.TextBox txtOwnerId;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.TextBox txtBedrooms;
        private System.Windows.Forms.Label lblBedrooms;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.Label lblPropAddress2;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.TextBox txtBathrooms;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label lblPropAddress1;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.Label lblBathrooms;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBeds;
        private System.Windows.Forms.ComboBox cboBeds;
        private System.Windows.Forms.ComboBox cboTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView grdProperties;
        private System.Windows.Forms.TextBox txtPropID;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.Label lblActivity;
    }
}