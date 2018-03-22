namespace PropertySysv2
{
    partial class frmPropertySearch
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpProperty = new System.Windows.Forms.GroupBox();
            this.txtBedroom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdd2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdd1 = new System.Windows.Forms.TextBox();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.txtBathroom = new System.Windows.Forms.TextBox();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpProperty.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 27);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search:";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(115, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(124, 20);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearchProperty_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search for Prop ID: ";
            // 
            // grpProperty
            // 
            this.grpProperty.Controls.Add(this.txtBedroom);
            this.grpProperty.Controls.Add(this.label9);
            this.grpProperty.Controls.Add(this.txtCounty);
            this.grpProperty.Controls.Add(this.label7);
            this.grpProperty.Controls.Add(this.txtAdd2);
            this.grpProperty.Controls.Add(this.label6);
            this.grpProperty.Controls.Add(this.txtAdd1);
            this.grpProperty.Controls.Add(this.txtHouse);
            this.grpProperty.Controls.Add(this.txtBathroom);
            this.grpProperty.Controls.Add(this.txtRent);
            this.grpProperty.Controls.Add(this.label4);
            this.grpProperty.Controls.Add(this.label3);
            this.grpProperty.Controls.Add(this.label2);
            this.grpProperty.Controls.Add(this.label5);
            this.grpProperty.Location = new System.Drawing.Point(15, 103);
            this.grpProperty.Name = "grpProperty";
            this.grpProperty.Size = new System.Drawing.Size(317, 239);
            this.grpProperty.TabIndex = 30;
            this.grpProperty.TabStop = false;
            this.grpProperty.Visible = false;
            // 
            // txtBedroom
            // 
            this.txtBedroom.Enabled = false;
            this.txtBedroom.Location = new System.Drawing.Point(100, 59);
            this.txtBedroom.Name = "txtBedroom";
            this.txtBedroom.Size = new System.Drawing.Size(124, 20);
            this.txtBedroom.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Bedrooms:";
            // 
            // txtCounty
            // 
            this.txtCounty.Enabled = false;
            this.txtCounty.Location = new System.Drawing.Point(100, 197);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(122, 20);
            this.txtCounty.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "County";
            // 
            // txtAdd2
            // 
            this.txtAdd2.Enabled = false;
            this.txtAdd2.Location = new System.Drawing.Point(101, 171);
            this.txtAdd2.Name = "txtAdd2";
            this.txtAdd2.Size = new System.Drawing.Size(123, 20);
            this.txtAdd2.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Address Line 2:";
            // 
            // txtAdd1
            // 
            this.txtAdd1.Enabled = false;
            this.txtAdd1.Location = new System.Drawing.Point(100, 144);
            this.txtAdd1.Name = "txtAdd1";
            this.txtAdd1.Size = new System.Drawing.Size(123, 20);
            this.txtAdd1.TabIndex = 25;
            // 
            // txtHouse
            // 
            this.txtHouse.Enabled = false;
            this.txtHouse.Location = new System.Drawing.Point(100, 118);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(123, 20);
            this.txtHouse.TabIndex = 24;
            // 
            // txtBathroom
            // 
            this.txtBathroom.Enabled = false;
            this.txtBathroom.Location = new System.Drawing.Point(100, 89);
            this.txtBathroom.Name = "txtBathroom";
            this.txtBathroom.Size = new System.Drawing.Size(124, 20);
            this.txtBathroom.TabIndex = 23;
            // 
            // txtRent
            // 
            this.txtRent.Enabled = false;
            this.txtRent.Location = new System.Drawing.Point(100, 33);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(124, 20);
            this.txtRent.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Address Line 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "House Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bathrooms:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Rent per month:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(409, 24);
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
            // frmPropertySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 377);
            this.Controls.Add(this.grpProperty);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPropertySearch";
            this.Text = "Search Property";
            this.grpProperty.ResumeLayout(false);
            this.grpProperty.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpProperty;
        private System.Windows.Forms.TextBox txtBedroom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdd2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdd1;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.TextBox txtBathroom;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
    }
}