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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStockNo = new System.Windows.Forms.TextBox();
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
            this.btnSrh = new System.Windows.Forms.Button();
            this.grpStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "StockNo:";
            // 
            // txtStockNo
            // 
            this.txtStockNo.Location = new System.Drawing.Point(92, 19);
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.Size = new System.Drawing.Size(57, 20);
            this.txtStockNo.TabIndex = 1;
            // 
            // grpStock
            // 
            this.grpStock.Controls.Add(this.btnUpd);
            this.grpStock.Controls.Add(this.txtQty);
            this.grpStock.Controls.Add(this.label5);
            this.grpStock.Controls.Add(this.txtSalePrice);
            this.grpStock.Controls.Add(this.label4);
            this.grpStock.Controls.Add(this.txtCostPrice);
            this.grpStock.Controls.Add(this.label3);
            this.grpStock.Controls.Add(this.txtDescription);
            this.grpStock.Controls.Add(this.label2);
            this.grpStock.Location = new System.Drawing.Point(28, 71);
            this.grpStock.Name = "grpStock";
            this.grpStock.Size = new System.Drawing.Size(408, 205);
            this.grpStock.TabIndex = 2;
            this.grpStock.TabStop = false;
            this.grpStock.Text = "Edit Stock Details";
            this.grpStock.Visible = false;
            // 
            // btnUpd
            // 
            this.btnUpd.ForeColor = System.Drawing.Color.Red;
            this.btnUpd.Location = new System.Drawing.Point(169, 159);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(76, 26);
            this.btnUpd.TabIndex = 8;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(94, 157);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(55, 20);
            this.txtQty.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(94, 119);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(55, 20);
            this.txtSalePrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sale Price";
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(89, 84);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(55, 20);
            this.txtCostPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(89, 42);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(136, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // btnSrh
            // 
            this.btnSrh.Location = new System.Drawing.Point(173, 20);
            this.btnSrh.Name = "btnSrh";
            this.btnSrh.Size = new System.Drawing.Size(69, 19);
            this.btnSrh.TabIndex = 3;
            this.btnSrh.Text = "Search";
            this.btnSrh.UseVisualStyleBackColor = true;
            this.btnSrh.Click += new System.EventHandler(this.btnSrh_Click);
            // 
            // frmStockUpd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 315);
            this.Controls.Add(this.btnSrh);
            this.Controls.Add(this.grpStock);
            this.Controls.Add(this.txtStockNo);
            this.Controls.Add(this.label1);
            this.Name = "frmStockUpd";
            this.Text = "Update Stock - By StockNo";
            this.Load += new System.EventHandler(this.frmStockReg_Load);
            this.grpStock.ResumeLayout(false);
            this.grpStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStockNo;
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
        private System.Windows.Forms.Button btnSrh;
    }
}