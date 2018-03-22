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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpProperties = new System.Windows.Forms.GroupBox();
            this.txtOwnerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBedrooms = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.txtBathrooms = new System.Windows.Forms.TextBox();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRmv
            // 
            this.btnRmv.Location = new System.Drawing.Point(9, 298);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(97, 28);
            this.btnRmv.TabIndex = 5;
            this.btnRmv.Text = "Remove Property";
            this.btnRmv.UseVisualStyleBackColor = true;
            this.btnRmv.Visible = false;
            this.btnRmv.Click += new System.EventHandler(this.btnRmv_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(111, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(133, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter PropertyID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 24);
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
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 28);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpProperties
            // 
            this.grpProperties.Controls.Add(this.txtOwnerId);
            this.grpProperties.Controls.Add(this.label2);
            this.grpProperties.Controls.Add(this.btnRmv);
            this.grpProperties.Controls.Add(this.txtBedrooms);
            this.grpProperties.Controls.Add(this.label6);
            this.grpProperties.Controls.Add(this.txtCounty);
            this.grpProperties.Controls.Add(this.label7);
            this.grpProperties.Controls.Add(this.txtAdd2);
            this.grpProperties.Controls.Add(this.label8);
            this.grpProperties.Controls.Add(this.txtAdd1);
            this.grpProperties.Controls.Add(this.txtHouse);
            this.grpProperties.Controls.Add(this.txtBathrooms);
            this.grpProperties.Controls.Add(this.txtRent);
            this.grpProperties.Controls.Add(this.label10);
            this.grpProperties.Controls.Add(this.label11);
            this.grpProperties.Controls.Add(this.label12);
            this.grpProperties.Controls.Add(this.label13);
            this.grpProperties.Location = new System.Drawing.Point(16, 106);
            this.grpProperties.Name = "grpProperties";
            this.grpProperties.Size = new System.Drawing.Size(335, 332);
            this.grpProperties.TabIndex = 31;
            this.grpProperties.TabStop = false;
            this.grpProperties.Text = "Enter Property Details";
            this.grpProperties.Visible = false;
            // 
            // txtOwnerId
            // 
            this.txtOwnerId.Enabled = false;
            this.txtOwnerId.Location = new System.Drawing.Point(95, 257);
            this.txtOwnerId.Name = "txtOwnerId";
            this.txtOwnerId.Size = new System.Drawing.Size(122, 20);
            this.txtOwnerId.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Owner ID:";
            // 
            // txtBedrooms
            // 
            this.txtBedrooms.Enabled = false;
            this.txtBedrooms.Location = new System.Drawing.Point(95, 63);
            this.txtBedrooms.Name = "txtBedrooms";
            this.txtBedrooms.Size = new System.Drawing.Size(124, 20);
            this.txtBedrooms.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Bedrooms:";
            // 
            // txtCounty
            // 
            this.txtCounty.Enabled = false;
            this.txtCounty.Location = new System.Drawing.Point(95, 223);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(122, 20);
            this.txtCounty.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "County:";
            // 
            // txtAdd2
            // 
            this.txtAdd2.Enabled = false;
            this.txtAdd2.Location = new System.Drawing.Point(96, 193);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(123, 20);
            this.txtAdd2.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Address Line 2:";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Address Line 1:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "House Type:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Bathrooms:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Rent per month:";
            // 
            // frmPropertyRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 454);
            this.Controls.Add(this.grpProperties);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPropertyRemove";
            this.Text = "Remove Property";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpProperties.ResumeLayout(false);
            this.grpProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpProperties;
        private System.Windows.Forms.TextBox txtOwnerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBedrooms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.TextBox txtBathrooms;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}