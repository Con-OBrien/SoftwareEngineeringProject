namespace PropertySysv2
{
    partial class frmRentProperty
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
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.grpTenants = new System.Windows.Forms.GroupBox();
            this.btnExisting = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtTenantID = new System.Windows.Forms.TextBox();
            this.lblTenantID = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtPropID = new System.Windows.Forms.TextBox();
            this.lblPropID = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblTenant = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.cboTenant = new System.Windows.Forms.ComboBox();
            this.grpTenantSelect = new System.Windows.Forms.GroupBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.grpDates = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblBeds = new System.Windows.Forms.Label();
            this.cboBeds = new System.Windows.Forms.ComboBox();
            this.cboTown = new System.Windows.Forms.ComboBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grdProperties = new System.Windows.Forms.DataGridView();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.grpTenants.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpTenantSelect.SuspendLayout();
            this.grpDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBookingID
            // 
            this.txtBookingID.Enabled = false;
            this.txtBookingID.Location = new System.Drawing.Point(89, 43);
            this.txtBookingID.MaxLength = 4;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(58, 20);
            this.txtBookingID.TabIndex = 19;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(12, 46);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(60, 13);
            this.lblBookingID.TabIndex = 18;
            this.lblBookingID.Text = "Booking ID";
            // 
            // grpTenants
            // 
            this.grpTenants.Controls.Add(this.btnExisting);
            this.grpTenants.Controls.Add(this.dtpDOB);
            this.grpTenants.Controls.Add(this.txtTenantID);
            this.grpTenants.Controls.Add(this.lblTenantID);
            this.grpTenants.Controls.Add(this.lblMsg);
            this.grpTenants.Controls.Add(this.txtPropID);
            this.grpTenants.Controls.Add(this.lblPropID);
            this.grpTenants.Controls.Add(this.txtSurname);
            this.grpTenants.Controls.Add(this.lblSurname);
            this.grpTenants.Controls.Add(this.btnAdd);
            this.grpTenants.Controls.Add(this.txtEmail);
            this.grpTenants.Controls.Add(this.txtPhone);
            this.grpTenants.Controls.Add(this.txtForename);
            this.grpTenants.Controls.Add(this.lblDOB);
            this.grpTenants.Controls.Add(this.lblEmail);
            this.grpTenants.Controls.Add(this.lblPhone);
            this.grpTenants.Controls.Add(this.lblForename);
            this.grpTenants.Location = new System.Drawing.Point(748, 46);
            this.grpTenants.Name = "grpTenants";
            this.grpTenants.Size = new System.Drawing.Size(335, 318);
            this.grpTenants.TabIndex = 34;
            this.grpTenants.TabStop = false;
            this.grpTenants.Text = "Enter Tenant Details";
            this.grpTenants.Visible = false;
            // 
            // btnExisting
            // 
            this.btnExisting.Location = new System.Drawing.Point(6, 264);
            this.btnExisting.Name = "btnExisting";
            this.btnExisting.Size = new System.Drawing.Size(109, 26);
            this.btnExisting.TabIndex = 39;
            this.btnExisting.Text = "Is this you?";
            this.btnExisting.UseVisualStyleBackColor = true;
            this.btnExisting.Visible = false;
            this.btnExisting.Click += new System.EventHandler(this.btnExisting_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(104, 208);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 38;
            // 
            // txtTenantID
            // 
            this.txtTenantID.Enabled = false;
            this.txtTenantID.Location = new System.Drawing.Point(104, 53);
            this.txtTenantID.Name = "txtTenantID";
            this.txtTenantID.Size = new System.Drawing.Size(124, 20);
            this.txtTenantID.TabIndex = 37;
            // 
            // lblTenantID
            // 
            this.lblTenantID.AutoSize = true;
            this.lblTenantID.Location = new System.Drawing.Point(15, 56);
            this.lblTenantID.Name = "lblTenantID";
            this.lblTenantID.Size = new System.Drawing.Size(58, 13);
            this.lblTenantID.TabIndex = 36;
            this.lblTenantID.Text = "Tenant ID:";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMsg.Location = new System.Drawing.Point(6, 293);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(190, 13);
            this.lblMsg.TabIndex = 35;
            this.lblMsg.Text = "Tenant has been entered successfully!";
            this.lblMsg.Visible = false;
            // 
            // txtPropID
            // 
            this.txtPropID.Enabled = false;
            this.txtPropID.Location = new System.Drawing.Point(104, 25);
            this.txtPropID.Name = "txtPropID";
            this.txtPropID.Size = new System.Drawing.Size(124, 20);
            this.txtPropID.TabIndex = 34;
            // 
            // lblPropID
            // 
            this.lblPropID.AutoSize = true;
            this.lblPropID.Location = new System.Drawing.Point(15, 28);
            this.lblPropID.Name = "lblPropID";
            this.lblPropID.Size = new System.Drawing.Size(63, 13);
            this.lblPropID.TabIndex = 33;
            this.lblPropID.Text = "Property ID:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(104, 116);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(124, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(15, 116);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 31;
            this.lblSurname.Text = "Surname:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 19);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Tenant";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 180);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(123, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(104, 150);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(124, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(104, 82);
            this.txtForename.MaxLength = 20;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(124, 20);
            this.txtForename.TabIndex = 0;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(15, 214);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(33, 13);
            this.lblDOB.TabIndex = 21;
            this.lblDOB.Text = "DOB:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 183);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 150);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(15, 82);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 18;
            this.lblForename.Text = "Forename:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(17, 36);
            this.dtpStart.MinDate = new System.DateTime(2018, 5, 3, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 37;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(17, 79);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 38;
            this.dtpEnd.Visible = false;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(14, 16);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(58, 13);
            this.lblStart.TabIndex = 39;
            this.lblStart.Text = "Start Date:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(14, 63);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(55, 13);
            this.lblEnd.TabIndex = 40;
            this.lblEnd.Text = "End Date:";
            this.lblEnd.Visible = false;
            // 
            // lblTenant
            // 
            this.lblTenant.AutoSize = true;
            this.lblTenant.Location = new System.Drawing.Point(528, 50);
            this.lblTenant.Name = "lblTenant";
            this.lblTenant.Size = new System.Drawing.Size(86, 13);
            this.lblTenant.TabIndex = 41;
            this.lblTenant.Text = "Existing Tenant?";
            this.lblTenant.Visible = false;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(531, 75);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(55, 25);
            this.btnYes.TabIndex = 42;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(605, 75);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(55, 25);
            this.btnNo.TabIndex = 43;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // cboTenant
            // 
            this.cboTenant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenant.FormattingEnabled = true;
            this.cboTenant.Location = new System.Drawing.Point(6, 19);
            this.cboTenant.Name = "cboTenant";
            this.cboTenant.Size = new System.Drawing.Size(169, 21);
            this.cboTenant.TabIndex = 45;
            this.cboTenant.SelectedIndexChanged += new System.EventHandler(this.cboTenant_SelectedIndexChanged);
            // 
            // grpTenantSelect
            // 
            this.grpTenantSelect.Controls.Add(this.cboTenant);
            this.grpTenantSelect.Location = new System.Drawing.Point(531, 136);
            this.grpTenantSelect.Name = "grpTenantSelect";
            this.grpTenantSelect.Size = new System.Drawing.Size(200, 55);
            this.grpTenantSelect.TabIndex = 46;
            this.grpTenantSelect.TabStop = false;
            this.grpTenantSelect.Text = "Select your TenantID";
            this.grpTenantSelect.Visible = false;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(17, 105);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(86, 25);
            this.btnRent.TabIndex = 48;
            this.btnRent.Text = "Rent Property";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // grpDates
            // 
            this.grpDates.Controls.Add(this.lblStart);
            this.grpDates.Controls.Add(this.dtpStart);
            this.grpDates.Controls.Add(this.btnRent);
            this.grpDates.Controls.Add(this.dtpEnd);
            this.grpDates.Controls.Add(this.lblEnd);
            this.grpDates.Location = new System.Drawing.Point(757, 370);
            this.grpDates.Name = "grpDates";
            this.grpDates.Size = new System.Drawing.Size(329, 172);
            this.grpDates.TabIndex = 50;
            this.grpDates.TabStop = false;
            this.grpDates.Text = "Dates";
            this.grpDates.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 179);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 19);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBeds
            // 
            this.lblBeds.AutoSize = true;
            this.lblBeds.Location = new System.Drawing.Point(12, 149);
            this.lblBeds.Name = "lblBeds";
            this.lblBeds.Size = new System.Drawing.Size(31, 13);
            this.lblBeds.TabIndex = 56;
            this.lblBeds.Text = "Beds";
            // 
            // cboBeds
            // 
            this.cboBeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBeds.FormattingEnabled = true;
            this.cboBeds.Location = new System.Drawing.Point(55, 146);
            this.cboBeds.Name = "cboBeds";
            this.cboBeds.Size = new System.Drawing.Size(92, 21);
            this.cboBeds.TabIndex = 55;
            // 
            // cboTown
            // 
            this.cboTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTown.FormattingEnabled = true;
            this.cboTown.Location = new System.Drawing.Point(55, 104);
            this.cboTown.Name = "cboTown";
            this.cboTown.Size = new System.Drawing.Size(92, 21);
            this.cboTown.TabIndex = 54;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(12, 107);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(34, 13);
            this.lblTown.TabIndex = 53;
            this.lblTown.Text = "Town";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 78);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(109, 13);
            this.lblSearch.TabIndex = 52;
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
            this.grdProperties.Location = new System.Drawing.Point(15, 204);
            this.grdProperties.MultiSelect = false;
            this.grdProperties.Name = "grdProperties";
            this.grdProperties.ReadOnly = true;
            this.grdProperties.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdProperties.Size = new System.Drawing.Size(614, 100);
            this.grdProperties.TabIndex = 51;
            this.grdProperties.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProperties_CellClick);
            // 
            // txtRooms
            // 
            this.txtRooms.Location = new System.Drawing.Point(681, 204);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.Size = new System.Drawing.Size(25, 20);
            this.txtRooms.TabIndex = 58;
            this.txtRooms.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(635, 230);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(62, 20);
            this.txtTotal.TabIndex = 59;
            this.txtTotal.Visible = false;
            // 
            // frmRentProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1119, 551);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtRooms);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblBeds);
            this.Controls.Add(this.cboBeds);
            this.Controls.Add(this.cboTown);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.grdProperties);
            this.Controls.Add(this.grpDates);
            this.Controls.Add(this.grpTenantSelect);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblTenant);
            this.Controls.Add(this.grpTenants);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRentProperty";
            this.Text = "Rent Property";
            this.Load += new System.EventHandler(this.frmRentProperty_Load);
            this.grpTenants.ResumeLayout(false);
            this.grpTenants.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpTenantSelect.ResumeLayout(false);
            this.grpDates.ResumeLayout(false);
            this.grpDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.GroupBox grpTenants;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.TextBox txtPropID;
        private System.Windows.Forms.Label lblPropID;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblTenant;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.ComboBox cboTenant;
        private System.Windows.Forms.GroupBox grpTenantSelect;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtTenantID;
        private System.Windows.Forms.Label lblTenantID;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.GroupBox grpDates;
        private System.Windows.Forms.Button btnExisting;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBeds;
        private System.Windows.Forms.ComboBox cboBeds;
        private System.Windows.Forms.ComboBox cboTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView grdProperties;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.TextBox txtTotal;
    }
}