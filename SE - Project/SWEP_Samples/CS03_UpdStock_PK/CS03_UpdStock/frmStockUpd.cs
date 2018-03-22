using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS03_UpdStock
{
    public partial class frmStockUpd : Form
    {
        public frmStockUpd()
        {
            InitializeComponent();
        }

        private void frmStockReg_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            //validate data


            //instantiate Stock Object
            Stock myStock = new Stock();
            myStock.setStockNo(Convert.ToInt32(txtStockNo.Text));
            myStock.setDescription(txtDescription.Text);
            myStock.setCostPrice(Convert.ToDecimal(txtCostPrice.Text));
            myStock.setSalePrice(Convert.ToDecimal(txtSalePrice.Text));
            myStock.setQty(Convert.ToInt32(txtQty.Text));
            

            //INSERT Stock record into stock table
            myStock.updStock();

            //Display Confirmation Message
            MessageBox.Show("Stock " + txtStockNo.Text + " Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            grpStock.Visible = false;

            txtStockNo.Text = "";
            txtStockNo.Focus();

        }

        private void btnSrh_Click(object sender, EventArgs e)
        {
            //check that stoock number is entered
            if(txtStockNo.Text.Equals(""))
            {
                MessageBox.Show("StockNo must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockNo.Focus();
                return;
            }

            //find stock details
            Stock updStock = new Stock();
            updStock.getStock(Convert.ToInt32(txtStockNo.Text));

            if(updStock.getStockNo().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockNo.Focus();
                return;
            }

            //display Stock details
            txtDescription.Text = updStock.getDescription();
            txtCostPrice.Text = updStock.getCostPrice().ToString();
            txtSalePrice.Text = updStock.getSalePrice().ToString();
            txtQty.Text = updStock.getQty().ToString();

            //display details
            grpStock.Visible = true;
        }
    }
}
