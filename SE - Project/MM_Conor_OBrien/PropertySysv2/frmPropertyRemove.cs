using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertySysv2
{
    public partial class frmPropertyRemove : Form
    {
        frmMainMenu parent;
        public frmPropertyRemove()
        {
            InitializeComponent();
        }
        public frmPropertyRemove(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void btnRmv_Click(object sender, EventArgs e)
        {         
            //instantiate Property Object
            Property myProperty = new Property();
            myProperty.setPropId(Convert.ToInt32(txtPropID.Text));
            myProperty.setRentPerMonth(Convert.ToInt32(txtRent.Text));
            myProperty.setBedrooms(Convert.ToInt32(txtBedrooms.Text));
            myProperty.setStreet(txtAdd1.Text);
            myProperty.setTown(txtAdd2.Text);
            myProperty.setCounty(txtCounty.Text);
            myProperty.setHouseType(txtHouse.Text);
            myProperty.setOwnerId(Convert.ToInt32(txtOwnerId.Text));

            //Set Property record in table as Inactive
            myProperty.rmvProperty();

            //Display Confirmation message
            MessageBox.Show("Property Removed From System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI           
            txtRent.Text = "";
            txtBedrooms.Text = "";
            txtBathrooms.Text = "";
            txtAdd1.Text = "";
            txtAdd2.Text = "";
            txtCounty.Text = "";
            txtHouse.Text = "";
            txtOwnerId.Text = "";

        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previousform
            parent.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Populate DataGrid
            DataSet ds = new DataSet();
            if (cboBeds.SelectedItem == null)
            {
                grdProperties.DataSource = Property.getSpecificProps(ds, cboTown.Text).Tables["ss"];

            }
            else
            {
                grdProperties.DataSource = Property.getSpecificProps(ds, cboTown.Text, Convert.ToInt32(cboBeds.Text)).Tables["ss"];
            }

            grdProperties.Visible = true;              
        }

        private void grdProperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Populate Text boxes with data from selected object from GridView
            txtRent.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtBedrooms.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtBathrooms.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtHouse.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtAdd1.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtAdd2.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[6].Value.ToString();
            txtCounty.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[7].Value.ToString();
            txtActivity.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[8].Value.ToString();
            txtOwnerId.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[9].Value.ToString();

            grpProperties.Visible = true;
        }

        private void frmPropertyRemove_Load(object sender, EventArgs e)
        {

        }
    }
}
