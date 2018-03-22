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
    public partial class frmPropertyAdd : Form
    {
        frmMainMenu parent;
        public frmPropertyAdd()
        {
            InitializeComponent();
        }
        public frmPropertyAdd(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void frmPropertyAdd_Load(object sender, EventArgs e)
        {
            txtPropertyID.Text = PropertySysv2.Property.getNextPropId().ToString("00000");
        }
       
        private void btnPropertyAdd_Click(object sender, EventArgs e)
        {
            if (txtRent.Text.Equals("") || txtBedroom.Text.Equals("") || txtBathroom.Text.Equals("") || txtBoxHouse.Text.Equals("") || txtBoxAdd1.Text.Equals("") || txtBoxAdd2.Text.Equals("") || txtBoxCounty.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            Property myProps = new Property();
            myProps.setPropId(Convert.ToInt32(txtPropertyID.Text));
            myProps.setRentPerMonth(Convert.ToInt32(txtRent.Text));
            myProps.setBedrooms(Convert.ToInt32(txtBedroom.Text));
            myProps.setBathrooms(Convert.ToInt32(txtBathroom.Text));
            myProps.setHouseType(txtBoxHouse.Text);
            myProps.setStreet(txtBoxAdd1.Text);
            myProps.setTown(txtBoxAdd2.Text);
            myProps.setCounty(txtBoxCounty.Text);
            myProps.setOwnerId(Convert.ToInt32(txtSearch.Text));

            myProps.regProp();

            MessageBox.Show("Property Added to System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtRent.Text = "";
            txtBedroom.Text = "";
            txtBathroom.Text = "";
            txtBoxHouse.Text = "";
            txtBoxAdd1.Text = "";
            txtBoxAdd2.Text = "";
            txtBoxCounty.Text = "";
            txtSearch.Text = "";

            grpOwner.Visible = false;
            grpProperty.Visible = false;

            txtPropertyID.Text = PropertySysv2.Property.getNextPropId().ToString("00000");
            txtRent.Focus();
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
            //check that owner number is entered
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("OwnerID must be Entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            //find owner details
            Owner srhOwner = new Owner();
            srhOwner.getOwner(Convert.ToInt32(txtSearch.Text));

            if (srhOwner.getOwnerId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            //display Owner details
            txtForename.Text = srhOwner.getForename();
            txtSurname.Text = srhOwner.getSurname();
            txtAdd1.Text = srhOwner.getStreet();
            txtAdd2.Text = srhOwner.getTown();
            txtCounty.Text = srhOwner.getCounty();
            txtPhone.Text = srhOwner.getPhone().ToString();
            txtEmail.Text = srhOwner.getEmail();


            //display details
            grpOwner.Visible = true;
            grpProperty.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
