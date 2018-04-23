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
    public partial class frmPropertyUpdate : Form
    {
        frmMainMenu parent;
        public frmPropertyUpdate()
        {
            InitializeComponent();
        }
        public frmPropertyUpdate(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previousform
            parent.Show();
        }

        private void updProperty_Click(object sender, EventArgs e)
        {
            // validate data
            if (txtRent.Text.Equals("") || txtBedrooms.Text.Equals("") || txtBathrooms.Text.Equals("") || txtHouse.Text.Equals("") || txtAdd1.Text.Equals("") || txtAdd2.Text.Equals("") || txtCounty.Text.Equals("") || txtOwnerId.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            // Save data in Owners File

            //Display Confirmation message
            MessageBox.Show("Owner Updated In System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //instantiate Stock Object
            Property myProps = new Property();
            myProps.setRentPerMonth(Convert.ToInt32(txtRent.Text));
            myProps.setBedrooms(Convert.ToInt32(txtBedrooms.Text));
            myProps.setBathrooms(Convert.ToInt32(txtBathrooms.Text));
            myProps.setHouseType(txtHouse.Text);
            myProps.setStreet(txtAdd1.Text);
            myProps.setTown(txtAdd2.Text);
            myProps.setCounty(txtCounty.Text);
            myProps.setOwnerId(Convert.ToInt32(txtOwnerId.Text));

            //INSERT Stock record into stock table
            myProps.updProp();

            //reset UI
            txtRent.Text = "";
            txtBedrooms.Text = "";
            txtBathrooms.Text = "";
            txtHouse.Text = "";
            txtAdd1.Text = "";
            txtAdd2.Text = "";
            txtCounty.Text = "";
            txtOwnerId.Text = "";
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            grdOwners.DataSource = PropertySysv2.Property.getSpecificProps(ds, cboTown.Text, Convert.ToInt32(cboBeds.Text)).Tables["ss"];

            grdOwners.Visible = true;
            grpProperties.Visible = true;
        }

        private void frmPropertyUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
