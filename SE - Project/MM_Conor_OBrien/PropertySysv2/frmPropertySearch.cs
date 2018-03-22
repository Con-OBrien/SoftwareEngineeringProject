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
    public partial class frmPropertySearch : Form
    {
        frmMainMenu parent;
        public frmPropertySearch()
        {
            InitializeComponent();
        }
        public frmPropertySearch(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void txtSearchProperty_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //check that owner number is entered
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("PropID must be Entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            //find owner details
            Property srhProp = new Property();
            srhProp.getProperty(Convert.ToInt32(txtSearch.Text));

            if (srhProp.getPropId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            //display Owner details
            txtRent.Text = srhProp.getRentPerMonth().ToString();
            txtBedroom.Text = srhProp.getBedrooms().ToString();
            txtBathroom.Text = srhProp.getBathrooms().ToString();
            txtHouse.Text = srhProp.getHouseType();
            txtAdd1.Text = srhProp.getStreet();
            txtAdd2.Text = srhProp.getTown();
            txtCounty.Text = srhProp.getCounty();



            //display details
            grpProperty.Visible = true;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previousform
            parent.Show();
        }
    }
}
