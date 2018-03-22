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
           

            //instantiate Stock Object
            Property myProperty = new Property();
            myProperty.setPropId(Convert.ToInt32(txtSearch.Text));
            myProperty.setRentPerMonth(Convert.ToInt32(txtRent.Text));
            myProperty.setBedrooms(Convert.ToInt32(txtBedrooms.Text));
            myProperty.setStreet(txtAdd1.Text);
            myProperty.setTown(txtAdd2.Text);
            myProperty.setCounty(txtCounty.Text);
            myProperty.setHouseType(txtHouse.Text);
            myProperty.setOwnerId(Convert.ToInt32(txtOwnerId.Text));

            //DELETE Stock record into stock table
            myProperty.rmvProperty();

            //Display Confirmation message
            MessageBox.Show("Property Removed From System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtSearch.Text = "";
            txtRent.Text = "";
            txtBedrooms.Text = "";
            txtBathrooms.Text = "";
            txtAdd1.Text = "";
            txtAdd2.Text = "";
            txtCounty.Text = "";
            txtHouse.Text = "";
            txtOwnerId.Text = "";

            txtSearch.Focus();
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
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Search field is empty!");
                return;
            }
           
            

            //check that owner number is entered
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("OwnerID must be Entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            //find owner details
            Property updProp = new Property();
            updProp.getProperty(Convert.ToInt32(txtSearch.Text));

            if (updProp.getPropId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            //display Owner details
            txtRent.Text = updProp.getRentPerMonth().ToString();
            txtBedrooms.Text = updProp.getBedrooms().ToString();
            txtBathrooms.Text = updProp.getBathrooms().ToString();
            txtHouse.Text = updProp.getHouseType();
            txtAdd1.Text = updProp.getStreet();
            txtAdd2.Text = updProp.getTown();
            txtCounty.Text = updProp.getCounty();
            txtOwnerId.Text = updProp.getOwnerId().ToString();


            //display details
            grpProperties.Visible = true;
            btnRmv.Visible = true;
        }
    }
}
