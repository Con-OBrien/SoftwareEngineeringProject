namespace PropertySysv2
{
    partial class frmPropertyAdd
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
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.lblPropID = new System.Windows.Forms.Label();
            this.grpProperty = new System.Windows.Forms.GroupBox();
            this.txtBedroom = new System.Windows.Forms.TextBox();
            this.lblBedrooms = new System.Windows.Forms.Label();
            this.txtBoxCounty = new System.Windows.Forms.TextBox();
            this.lblPropCounty = new System.Windows.Forms.Label();
            this.txtBoxAdd2 = new System.Windows.Forms.TextBox();
            this.lblPropAddress2 = new System.Windows.Forms.Label();
            this.btnPropertyAdd = new System.Windows.Forms.Button();
            this.txtBoxAdd1 = new System.Windows.Forms.TextBox();
            this.txtBoxHouse = new System.Windows.Forms.TextBox();
            this.txtBathroom = new System.Windows.Forms.TextBox();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.lblPropAddress1 = new System.Windows.Forms.Label();
            this.lblHouse = new System.Windows.Forms.Label();
            this.lblBathrooms = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpOwners = new System.Windows.Forms.GroupBox();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblOwnerCounty = new System.Windows.Forms.Label();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.lblOwnerAddress2 = new System.Windows.Forms.Label();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblOwnerAddress1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.grdOwners = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtOwnerSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpProperty.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpOwners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOwners)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPropertyID
            // 
            this.txtPropertyID.Enabled = false;
            this.txtPropertyID.Location = new System.Drawing.Point(105, 28);
            this.txtPropertyID.MaxLength = 4;
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.Size = new System.Drawing.Size(124, 20);
            this.txtPropertyID.TabIndex = 17;
            // 
            // lblPropID
            // 
            this.lblPropID.AutoSize = true;
            this.lblPropID.Location = new System.Drawing.Point(31, 31);
            this.lblPropID.Name = "lblPropID";
            this.lblPropID.Size = new System.Drawing.Size(60, 13);
            this.lblPropID.TabIndex = 16;
            this.lblPropID.Text = "Property ID";
            // 
            // grpProperty
            // 
            this.grpProperty.Controls.Add(this.txtBedroom);
            this.grpProperty.Controls.Add(this.lblBedrooms);
            this.grpProperty.Controls.Add(this.txtBoxCounty);
            this.grpProperty.Controls.Add(this.lblPropCounty);
            this.grpProperty.Controls.Add(this.txtBoxAdd2);
            this.grpProperty.Controls.Add(this.lblPropAddress2);
            this.grpProperty.Controls.Add(this.txtPropertyID);
            this.grpProperty.Controls.Add(this.btnPropertyAdd);
            this.grpProperty.Controls.Add(this.lblPropID);
            this.grpProperty.Controls.Add(this.txtBoxAdd1);
            this.grpProperty.Controls.Add(this.txtBoxHouse);
            this.grpProperty.Controls.Add(this.txtBathroom);
            this.grpProperty.Controls.Add(this.txtRent);
            this.grpProperty.Controls.Add(this.lblPropAddress1);
            this.grpProperty.Controls.Add(this.lblHouse);
            this.grpProperty.Controls.Add(this.lblBathrooms);
            this.grpProperty.Controls.Add(this.lblRent);
            this.grpProperty.Location = new System.Drawing.Point(395, 207);
            this.grpProperty.Name = "grpProperty";
            this.grpProperty.Size = new System.Drawing.Size(318, 302);
            this.grpProperty.TabIndex = 19;
            this.grpProperty.TabStop = false;
            this.grpProperty.Text = "Enter Property Details";
            this.grpProperty.Visible = false;
            // 
            // txtBedroom
            // 
            this.txtBedroom.Location = new System.Drawing.Point(105, 83);
            this.txtBedroom.Name = "txtBedroom";
            this.txtBedroom.Size = new System.Drawing.Size(124, 20);
            this.txtBedroom.TabIndex = 1;
            // 
            // lblBedrooms
            // 
            this.lblBedrooms.AutoSize = true;
            this.lblBedrooms.Location = new System.Drawing.Point(34, 86);
            this.lblBedrooms.Name = "lblBedrooms";
            this.lblBedrooms.Size = new System.Drawing.Size(57, 13);
            this.lblBedrooms.TabIndex = 31;
            this.lblBedrooms.Text = "Bedrooms:";
            // 
            // txtBoxCounty
            // 
            this.txtBoxCounty.Location = new System.Drawing.Point(105, 221);
            this.txtBoxCounty.Name = "txtBoxCounty";
            this.txtBoxCounty.Size = new System.Drawing.Size(124, 20);
            this.txtBoxCounty.TabIndex = 6;
            // 
            // lblPropCounty
            // 
            this.lblPropCounty.AutoSize = true;
            this.lblPropCounty.Location = new System.Drawing.Point(51, 221);
            this.lblPropCounty.Name = "lblPropCounty";
            this.lblPropCounty.Size = new System.Drawing.Size(40, 13);
            this.lblPropCounty.TabIndex = 29;
            this.lblPropCounty.Text = "County";
            // 
            // txtBoxAdd2
            // 
            this.txtBoxAdd2.Location = new System.Drawing.Point(105, 195);
            this.txtBoxAdd2.Name = "txtBoxAdd2";
            this.txtBoxAdd2.Size = new System.Drawing.Size(124, 20);
            this.txtBoxAdd2.TabIndex = 5;
            // 
            // lblPropAddress2
            // 
            this.lblPropAddress2.AutoSize = true;
            this.lblPropAddress2.Location = new System.Drawing.Point(11, 198);
            this.lblPropAddress2.Name = "lblPropAddress2";
            this.lblPropAddress2.Size = new System.Drawing.Size(80, 13);
            this.lblPropAddress2.TabIndex = 27;
            this.lblPropAddress2.Text = "Address Line 2:";
            // 
            // btnPropertyAdd
            // 
            this.btnPropertyAdd.Location = new System.Drawing.Point(19, 254);
            this.btnPropertyAdd.Name = "btnPropertyAdd";
            this.btnPropertyAdd.Size = new System.Drawing.Size(109, 30);
            this.btnPropertyAdd.TabIndex = 7;
            this.btnPropertyAdd.Text = "Add Property";
            this.btnPropertyAdd.UseVisualStyleBackColor = true;
            this.btnPropertyAdd.Click += new System.EventHandler(this.btnPropertyAdd_Click);
            // 
            // txtBoxAdd1
            // 
            this.txtBoxAdd1.Location = new System.Drawing.Point(105, 168);
            this.txtBoxAdd1.Name = "txtBoxAdd1";
            this.txtBoxAdd1.Size = new System.Drawing.Size(124, 20);
            this.txtBoxAdd1.TabIndex = 4;
            // 
            // txtBoxHouse
            // 
            this.txtBoxHouse.Location = new System.Drawing.Point(105, 142);
            this.txtBoxHouse.Name = "txtBoxHouse";
            this.txtBoxHouse.Size = new System.Drawing.Size(124, 20);
            this.txtBoxHouse.TabIndex = 3;
            // 
            // txtBathroom
            // 
            this.txtBathroom.Location = new System.Drawing.Point(105, 113);
            this.txtBathroom.Name = "txtBathroom";
            this.txtBathroom.Size = new System.Drawing.Size(124, 20);
            this.txtBathroom.TabIndex = 2;
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(105, 57);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(124, 20);
            this.txtRent.TabIndex = 0;
            // 
            // lblPropAddress1
            // 
            this.lblPropAddress1.AutoSize = true;
            this.lblPropAddress1.Location = new System.Drawing.Point(11, 171);
            this.lblPropAddress1.Name = "lblPropAddress1";
            this.lblPropAddress1.Size = new System.Drawing.Size(80, 13);
            this.lblPropAddress1.TabIndex = 21;
            this.lblPropAddress1.Text = "Address Line 1:";
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.Location = new System.Drawing.Point(23, 145);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(68, 13);
            this.lblHouse.TabIndex = 20;
            this.lblHouse.Text = "House Type:";
            // 
            // lblBathrooms
            // 
            this.lblBathrooms.AutoSize = true;
            this.lblBathrooms.Location = new System.Drawing.Point(31, 116);
            this.lblBathrooms.Name = "lblBathrooms";
            this.lblBathrooms.Size = new System.Drawing.Size(60, 13);
            this.lblBathrooms.TabIndex = 19;
            this.lblBathrooms.Text = "Bathrooms:";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Location = new System.Drawing.Point(16, 57);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(83, 13);
            this.lblRent.TabIndex = 18;
            this.lblRent.Text = "Rent per month:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
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
            // grpOwners
            // 
            this.grpOwners.Controls.Add(this.txtOwnerID);
            this.grpOwners.Controls.Add(this.lblOwnerID);
            this.grpOwners.Controls.Add(this.txtForename);
            this.grpOwners.Controls.Add(this.lblForename);
            this.grpOwners.Controls.Add(this.txtCounty);
            this.grpOwners.Controls.Add(this.lblOwnerCounty);
            this.grpOwners.Controls.Add(this.txtAdd2);
            this.grpOwners.Controls.Add(this.lblOwnerAddress2);
            this.grpOwners.Controls.Add(this.txtAdd1);
            this.grpOwners.Controls.Add(this.txtEmail);
            this.grpOwners.Controls.Add(this.txtPhone);
            this.grpOwners.Controls.Add(this.txtSurname);
            this.grpOwners.Controls.Add(this.lblOwnerAddress1);
            this.grpOwners.Controls.Add(this.lblEmail);
            this.grpOwners.Controls.Add(this.lblPhone);
            this.grpOwners.Controls.Add(this.lblSurname);
            this.grpOwners.Location = new System.Drawing.Point(24, 207);
            this.grpOwners.Name = "grpOwners";
            this.grpOwners.Size = new System.Drawing.Size(335, 302);
            this.grpOwners.TabIndex = 30;
            this.grpOwners.TabStop = false;
            this.grpOwners.Visible = false;
            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Enabled = false;
            this.txtOwnerID.Location = new System.Drawing.Point(90, 35);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(124, 20);
            this.txtOwnerID.TabIndex = 34;
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(6, 38);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(52, 13);
            this.lblOwnerID.TabIndex = 33;
            this.lblOwnerID.Text = "OwnerID:";
            // 
            // txtForename
            // 
            this.txtForename.Enabled = false;
            this.txtForename.Location = new System.Drawing.Point(91, 88);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(123, 20);
            this.txtForename.TabIndex = 32;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(6, 90);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 31;
            this.lblForename.Text = "Forename:";
            // 
            // txtCounty
            // 
            this.txtCounty.Enabled = false;
            this.txtCounty.Location = new System.Drawing.Point(90, 238);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(124, 20);
            this.txtCounty.TabIndex = 30;
            // 
            // lblOwnerCounty
            // 
            this.lblOwnerCounty.AutoSize = true;
            this.lblOwnerCounty.Location = new System.Drawing.Point(6, 241);
            this.lblOwnerCounty.Name = "lblOwnerCounty";
            this.lblOwnerCounty.Size = new System.Drawing.Size(40, 13);
            this.lblOwnerCounty.TabIndex = 29;
            this.lblOwnerCounty.Text = "County";
            // 
            // txtAdd2
            // 
            this.txtAdd2.Enabled = false;
            this.txtAdd2.Location = new System.Drawing.Point(91, 206);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(123, 20);
            this.txtAdd2.TabIndex = 28;
            // 
            // lblOwnerAddress2
            // 
            this.lblOwnerAddress2.AutoSize = true;
            this.lblOwnerAddress2.Location = new System.Drawing.Point(6, 209);
            this.lblOwnerAddress2.Name = "lblOwnerAddress2";
            this.lblOwnerAddress2.Size = new System.Drawing.Size(77, 13);
            this.lblOwnerAddress2.TabIndex = 27;
            this.lblOwnerAddress2.Text = "Address Line 2";
            // 
            // txtAdd1
            // 
            this.txtAdd1.Enabled = false;
            this.txtAdd1.Location = new System.Drawing.Point(91, 178);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(123, 20);
            this.txtAdd1.TabIndex = 25;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(90, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(124, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPhone.Location = new System.Drawing.Point(90, 116);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(124, 20);
            this.txtPhone.TabIndex = 23;
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(91, 62);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(123, 20);
            this.txtSurname.TabIndex = 22;
            // 
            // lblOwnerAddress1
            // 
            this.lblOwnerAddress1.AutoSize = true;
            this.lblOwnerAddress1.Location = new System.Drawing.Point(6, 181);
            this.lblOwnerAddress1.Name = "lblOwnerAddress1";
            this.lblOwnerAddress1.Size = new System.Drawing.Size(80, 13);
            this.lblOwnerAddress1.TabIndex = 21;
            this.lblOwnerAddress1.Text = "Address Line 1:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 149);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 119);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 65);
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
            this.grdOwners.Location = new System.Drawing.Point(15, 70);
            this.grdOwners.MultiSelect = false;
            this.grdOwners.Name = "grdOwners";
            this.grdOwners.ReadOnly = true;
            this.grdOwners.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdOwners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdOwners.Size = new System.Drawing.Size(502, 123);
            this.grdOwners.TabIndex = 40;
            this.grdOwners.Visible = false;
            this.grdOwners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOwners_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(297, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 23);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtOwnerSearch
            // 
            this.txtOwnerSearch.Location = new System.Drawing.Point(98, 34);
            this.txtOwnerSearch.Name = "txtOwnerSearch";
            this.txtOwnerSearch.Size = new System.Drawing.Size(178, 20);
            this.txtOwnerSearch.TabIndex = 38;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 36);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(80, 13);
            this.lblSearch.TabIndex = 37;
            this.lblSearch.Text = "Enter Surname:";
            // 
            // frmPropertyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(894, 586);
            this.Controls.Add(this.grdOwners);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtOwnerSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.grpOwners);
            this.Controls.Add(this.grpProperty);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPropertyAdd";
            this.Text = "Add Property";
            this.Load += new System.EventHandler(this.frmPropertyAdd_Load);
            this.grpProperty.ResumeLayout(false);
            this.grpProperty.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpOwners.ResumeLayout(false);
            this.grpOwners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOwners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.Label lblPropID;
        private System.Windows.Forms.GroupBox grpProperty;
        private System.Windows.Forms.TextBox txtBedroom;
        private System.Windows.Forms.Label lblBedrooms;
        private System.Windows.Forms.TextBox txtBoxCounty;
        private System.Windows.Forms.Label lblPropCounty;
        private System.Windows.Forms.TextBox txtBoxAdd2;
        private System.Windows.Forms.Label lblPropAddress2;
        private System.Windows.Forms.Button btnPropertyAdd;
        private System.Windows.Forms.TextBox txtBoxAdd1;
        private System.Windows.Forms.TextBox txtBoxHouse;
        private System.Windows.Forms.TextBox txtBathroom;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label lblPropAddress1;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.Label lblBathrooms;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpOwners;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblOwnerCounty;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.Label lblOwnerAddress2;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblOwnerAddress1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.DataGridView grdOwners;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtOwnerSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.Label lblOwnerID;
    }
}