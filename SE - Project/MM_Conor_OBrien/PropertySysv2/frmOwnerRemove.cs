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
    public partial class frmOwnerRemove : Form
    {
        frmMainMenu parent;
        public frmOwnerRemove()
        {
            InitializeComponent();
        }
        public frmOwnerRemove(frmMainMenu Parent)
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

        private void txtSearch_Click(object sender, EventArgs e)
        {
            //check that owner number is entered
            if (txtOwnerSearch.Text.Equals(""))
            {
                MessageBox.Show("OwnerID must be Entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOwnerSearch.Focus();
                return;
            }

            //find owner details
            Owner rmvOwner = new Owner();
            rmvOwner.getOwner(Convert.ToInt32(txtOwnerSearch.Text));

            if (rmvOwner.getOwnerId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOwnerSearch.Focus();
                return;
            }

            //display Owner details
            txtForename.Text = rmvOwner.getForename();
            txtSurname.Text = rmvOwner.getSurname();
            txtBoxAdd1.Text = rmvOwner.getStreet();
            txtBoxAdd2.Text = rmvOwner.getTown();
            txtBoxCounty.Text = rmvOwner.getCounty();
            txtPhone.Text = rmvOwner.getPhone().ToString();
            txtEmail.Text = rmvOwner.getEmail();


            //display details
            grpOwner.Visible = true;
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            // validate data
            if (txtSurname.Text.Equals("") || txtForename.Text.Equals("") || txtPhone.Text.Equals("") || txtEmail.Text.Equals("") || txtBoxAdd1.Text.Equals("") || txtBoxAdd2.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            // Save data in Owners File

            //Display Confirmation message
            MessageBox.Show("Owner Removed From System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //instantiate Stock Object
            Owner myOwners = new Owner();
            myOwners.setOwnerId(Convert.ToInt32(txtOwnerSearch.Text));
            myOwners.setForename(txtForename.Text);
            myOwners.setSurname(txtSurname.Text);
            myOwners.setStreet(txtBoxAdd1.Text);
            myOwners.setTown(txtBoxAdd2.Text);
            myOwners.setCounty(txtBoxCounty.Text);
            myOwners.setPhone(Convert.ToInt32(txtPhone.Text));
            myOwners.setEmail(txtEmail.Text);

            //DELETE Stock record into stock table
            myOwners.rmvOwner();

            //reset UI
            txtOwnerSearch.Text = "";
            txtSurname.Text = "";
            txtForename.Text = "";
            txtBoxAdd1.Text = "";
            txtBoxAdd2.Text = "";
            txtBoxCounty.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";

            txtOwnerSearch.Focus();
        }
    }
}
