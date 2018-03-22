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
    public partial class frmOwnerUpd : Form
    {
        frmMainMenu parent;
        public frmOwnerUpd()
        {
            InitializeComponent();
        }
        public frmOwnerUpd(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //check that owner number is entered
            if (txtSrhName.Text.Equals(""))
            {
                MessageBox.Show("OwnerID must be Entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSrhName.Focus();
                return;
            }

            //find owner details
            Owner updOwner = new Owner();
            updOwner.getOwner(Convert.ToInt32(txtSrhName.Text));

            if (updOwner.getOwnerId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSrhName.Focus();
                return;
            }

            //display Owner details
            txtForename.Text = updOwner.getForename();
            txtSurname.Text = updOwner.getSurname();
            txtBoxAdd1.Text = updOwner.getStreet();
            txtBoxAdd2.Text = updOwner.getTown();
            txtBoxCounty.Text = updOwner.getCounty();
            txtPhone.Text = updOwner.getPhone().ToString();
            txtEmail.Text = updOwner.getEmail();
             

            //display details
            grpOwner.Visible = true;
        }

        private void grdOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpOwner.Visible = true;
        }

        private void frmOwnerUpd_Load(object sender, EventArgs e)
        {

        }

       

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if(txtSurname.Text.Equals("") || txtForename.Text.Equals("") || txtPhone.Text.Equals("") || txtEmail.Text.Equals("") || txtBoxAdd1.Text.Equals("") || txtBoxAdd2.Text.Equals("") || txtBoxCounty.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered to update!");
                return;
            }

            MessageBox.Show("Owner was updated!");

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previousform
            parent.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // validate data
            if (txtSurname.Text.Equals("") || txtForename.Text.Equals("") || txtPhone.Text.Equals("") || txtEmail.Text.Equals("") || txtBoxAdd1.Text.Equals("") || txtBoxAdd2.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            // Save data in Owners File

            //Display Confirmation message
            MessageBox.Show("Owner Updated In System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //instantiate Stock Object
            Owner myOwners = new Owner();
            myOwners.setOwnerId(Convert.ToInt32(txtSrhName.Text));
            myOwners.setForename(txtForename.Text);
            myOwners.setSurname(txtSurname.Text);
            myOwners.setStreet(txtBoxAdd1.Text);
            myOwners.setTown(txtBoxAdd2.Text);
            myOwners.setCounty(txtBoxCounty.Text);
            myOwners.setPhone(Convert.ToInt32(txtPhone.Text));
            myOwners.setEmail(txtEmail.Text);

            //INSERT Stock record into stock table
            myOwners.updOwner();

            //reset UI
            txtSrhName.Text = "";
            txtSurname.Text = "";
            txtForename.Text = "";
            txtBoxAdd1.Text = "";
            txtBoxAdd2.Text = "";
            txtBoxCounty.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
         
            txtSrhName.Focus();
        }
    }
}
