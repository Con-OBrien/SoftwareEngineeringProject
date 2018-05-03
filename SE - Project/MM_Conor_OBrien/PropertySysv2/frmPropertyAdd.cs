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
            //Load PropertyID

            txtPropertyID.Text = Property.getNextPropId().ToString("00000");
        }
       
        private void btnPropertyAdd_Click(object sender, EventArgs e)
        {

            //Validate Data
            if (txtRent.Text.Equals("") || txtBedroom.Text.Equals("") || txtBathroom.Text.Equals("") || txtBoxHouse.Text.Equals("") || txtBoxAdd1.Text.Equals("") || txtBoxAdd2.Text.Equals("") || txtBoxCounty.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            String rent = txtRent.Text;
            foreach (char c in rent)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Rent must be numeric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRent.Text = "";
                    return;
                }
            }

            //Instantiate Property
            Property myProps = new Property();
            myProps.setPropId(Convert.ToInt32(txtPropertyID.Text));

            if (PropertySysv2.Owner.validNumbers(txtRent.Text))
            {
                myProps.setRentPerMonth(Convert.ToInt32(txtRent.Text));
            }
            else
            {
                MessageBox.Show("Rent must be numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRent.Text = "";
                txtRent.Focus();
                return;
            }


            if (PropertySysv2.Owner.validNumbers(txtBedroom.Text))
            {
                myProps.setBedrooms(Convert.ToInt32(txtBedroom.Text));
            }
            else
            {
                MessageBox.Show("Bedrooms must be numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBedroom.Text = "";
                txtBedroom.Focus();
                return;
            }


            if (PropertySysv2.Owner.validNumbers(txtBathroom.Text))
            {
                myProps.setBathrooms(Convert.ToInt32(txtBathroom.Text));
            }
            else
            {
                MessageBox.Show("Bathrooms must be numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBathroom.Text = "";
                txtBathroom.Focus();
                return;
            }


            if (PropertySysv2.Owner.validText(txtBoxHouse.Text))
            {
                myProps.setHouseType(txtBoxHouse.Text);
            }
            else
            {
                MessageBox.Show("House Type must be letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxHouse.Text = "";
                txtBoxHouse.Focus();
                return;
            }


            if (PropertySysv2.Owner.validText(txtBoxAdd1.Text))
            {
                myProps.setStreet(txtBoxAdd1.Text);
            }
            else
            {
                MessageBox.Show("Address Line 1 must be letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxAdd1.Text = "";
                txtBoxAdd1.Focus();
                return;
            }

            if (PropertySysv2.Owner.validText(txtBoxAdd2.Text))
            {
                myProps.setTown(txtBoxAdd2.Text);
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
                myProps.setCounty(txtBoxCounty.Text);
            }
            else
            {
                MessageBox.Show("County must be letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxCounty.Text = "";
                txtBoxCounty.Focus();
                return;
            }


            
            myProps.setActivity("A");
            myProps.setOwnerId(Convert.ToInt32(txtOwnerID.Text));

            //INSERT Property into Properties Table
            myProps.regProp();

            //Display Confirmation Message
            MessageBox.Show("Property Added to System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtRent.Text = "";
            txtBedroom.Text = "";
            txtBathroom.Text = "";
            txtBoxHouse.Text = "";
            txtBoxAdd1.Text = "";
            txtBoxAdd2.Text = "";
            txtBoxCounty.Text = "";
            txtOwnerSearch.Text = "";

            grpOwners.Visible = false;
            grpProperty.Visible = false;
            grdOwners.Visible = false;

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
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Populate text boxes with selected data from DataGrid

            txtOwnerID.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtForename.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtAdd1.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtAdd2.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtCounty.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtPhone.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[6].Value.ToString();
            txtEmail.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[7].Value.ToString();

            grpOwners.Visible = true;
            grpProperty.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtOwnerSearch.Text == "")
            {
                MessageBox.Show("Search must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOwnerSearch.Focus();
                return;
            }

            //Populate DataGrid
            if (Regex.IsMatch(txtOwnerSearch.Text, @"^[a-zA-Z]+$"))
            {
                DataSet ds = new DataSet();
                grdOwners.DataSource = PropertySysv2.Owner.getSpecificOwners(ds, txtOwnerSearch.Text.ToUpper()).Tables["ss"];

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
    }
}
