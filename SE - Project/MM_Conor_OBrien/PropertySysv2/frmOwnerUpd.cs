using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private void frmOwnerUpd_Load(object sender, EventArgs e)
        {

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
            if (txtSurname.Text.Equals("") || txtForename.Text.Equals("") || txtPhone.Text.Equals("") || txtEmail.Text.Equals("") || txtBoxAdd1.Text.Equals("") || txtBoxAdd2.Text.Equals("") || txtActivity.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            String phone = txtPhone.Text;
            foreach (char c in phone)
            {
                if (c <= '0' || c >= '9')
                {
                    MessageBox.Show("Phone must be numeric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if(txtActivity.Text.ToUpper() != "A" && txtActivity.Text.ToUpper() != "I")
            {
                MessageBox.Show("Activity must be A or I!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            //instantiate Owner Object
            Owner myOwners = new Owner();
            myOwners.setOwnerId(Convert.ToInt32(txtOwnerID.Text));
            if (PropertySysv2.Owner.validText(txtForename.Text))
            {
                myOwners.setForename(txtForename.Text);
            }
            else
            {
                MessageBox.Show("Forename must be letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Text = "";
                txtForename.Focus();
                return;
            }

            if (PropertySysv2.Owner.validText(txtSurname.Text))
            {
                myOwners.setSurname(txtSurname.Text);
            }
            else
            {
                MessageBox.Show("Surname must be letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Text = "";
                txtSurname.Focus();
                return;
            }


            if (PropertySysv2.Owner.validTextWithNumbers(txtBoxAdd1.Text))
            {
                myOwners.setStreet(txtBoxAdd1.Text);
            }
            else
            {
                MessageBox.Show("Address Line 1 must be numbers and letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxAdd1.Text = "";
                txtBoxAdd1.Focus();
                return;
            }

            if (PropertySysv2.Owner.validText(txtBoxAdd2.Text))
            {
                myOwners.setTown(txtBoxAdd2.Text);
            }
            else
            {
                MessageBox.Show("Address Line 2 must be letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxAdd2.Text = "";
                txtBoxAdd2.Focus();
                return;
            }

            if (PropertySysv2.Owner.validText(txtBoxCounty.Text))
            {
                myOwners.setCounty(txtBoxCounty.Text);
            }
            else
            {
                MessageBox.Show("County must be letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxCounty.Text = "";
                txtBoxCounty.Focus();
                return;
            }

            myOwners.setPhone(txtPhone.Text);

            if (PropertySysv2.Owner.validEmail(txtEmail.Text))
            {
                myOwners.setEmail(txtEmail.Text);
            }
            else
            {
                MessageBox.Show("Email must be correct format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }        
            myOwners.setActivity(txtActivity.Text);

            //UPDATE Owner record in Owner table
            myOwners.updOwner();

            //Display Confirmation message
            MessageBox.Show("Owner Updated In System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtOwnerSearch.Text = "";
            txtSurname.Text = "";
            txtForename.Text = "";
            txtBoxAdd1.Text = "";
            txtBoxAdd2.Text = "";
            txtBoxCounty.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";

            grpOwners.Visible = false;
            grdOwners.Visible = false;
            txtOwnerSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtOwnerSearch.Text == "")
            {
                MessageBox.Show("Search must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                txtOwnerSearch.Focus();
                return;
            }
            if(Regex.IsMatch(txtOwnerSearch.Text, @"^[a-zA-Z ]+$"))
            {
                DataSet ds = new DataSet();
                grdOwners.DataSource = PropertySysv2.Owner.getSpecificAllOwners(ds, txtOwnerSearch.Text.ToUpper()).Tables["ss"];

                grdOwners.Visible = true;
            }
            else
            {
                MessageBox.Show("Search must be valid characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOwnerSearch.Text = "";
                txtOwnerSearch.Focus();
                return;
            }




            
        }

        private void grdOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOwnerID.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtForename.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtBoxAdd1.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtBoxAdd2.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtBoxCounty.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtPhone.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[6].Value.ToString();
            txtEmail.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[7].Value.ToString();
            txtActivity.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[8].Value.ToString();

            grpOwners.Visible = true;
        }
    }
}
