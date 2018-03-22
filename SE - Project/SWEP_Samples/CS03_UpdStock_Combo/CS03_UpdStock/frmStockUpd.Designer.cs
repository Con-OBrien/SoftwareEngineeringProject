namespace CS03_UpdStock
{
    partial class frmStockUpd
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
            this.grpStock = new System.Windows.Forms.GroupBox();
            this.btnUpd = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStockNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStock = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStock
            // 
            this.grpStock.Controls.Add(this.txtStockNo);
            this.grpStock.Controls.Add(this.label1);
            this.grpStock.Controls.Add(this.btnUpd);
            this.grpStock.Controls.Add(this.txtQty);
            this.grpStock.Controls.Add(this.label5);
            this.grpStock.Controls.Add(this.txtSalePrice);
            this.grpStock.Controls.Add(this.label4);
            this.grpStock.Controls.Add(this.txtCostPrice);
            this.grpStock.Controls.Add(this.label3);
            this.grpStock.Controls.Add(this.txtDescription);
            this.grpStock.Controls.Add(this.label2);
            this.grpStock.Location = new System.Drawing.Point(25, 138);
            this.grpStock.Name = "grpStock";
            this.grpStock.Size = new System.Drawing.Size(408, 250);
            this.grpStock.TabIndex = 2;
            this.grpStock.TabStop = false;
            this.grpStock.Text = "Edit Stock Details";
            this.grpStock.Visible = false;
            // 
            // btnUpd
            // 
            this.btnUpd.ForeColor = System.Drawing.Color.Red;
            this.btnUpd.Location = new System.Drawing.Point(90, 216);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(76, 26);
            this.btnUpd.TabIndex = 8;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(90, 169);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(55, 20);
            this.txtQty.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(90, 131);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(55, 20);
            this.txtSalePrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sale Price";
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(85, 96);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(55, 20);
            this.txtCostPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(85, 54);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(136, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // txtStockNo
            // 
            this.txtStockNo.Enabled = false;
            this.txtStockNo.Location = new System.Drawing.Point(85, 19);
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.Size = new System.Drawing.Size(57, 20);
            this.txtStockNo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "StockNo:";
            // 
            // cboStock
            // 
            this.cboStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStock.FormattingEnabled = true;
            this.cboStock.Location = new System.Drawing.Point(124, 60);
            this.cboStock.Name = "cboStock";
            this.cboStock.Size = new System.Drawing.Size(285, 21);
            this.cboStock.TabIndex = 3;
            this.cboStock.SelectedIndexChanged += new System.EventHandler(this.cboStock_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Select Stock";
            // 
            // frmStockUpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 414);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboStock);
            this.Controls.Add(this.grpStock);
            this.Name = "frmStockUpd";
            this.Text = "Update Stock - By Description";
            this.Load += new System.EventHandler(this.frmStockReg_Load);
            this.grpStock.ResumeLayout(false);
            this.grpStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.TextBox txtStockNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStock;
        private System.Windows.Forms.Label label6;
    }
}