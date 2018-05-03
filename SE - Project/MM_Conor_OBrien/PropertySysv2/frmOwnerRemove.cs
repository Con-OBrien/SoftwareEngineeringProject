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

            //instantiate Owner Object
            Owner myOwners = new Owner();
            myOwners.setOwnerId(Convert.ToInt32(txtOwnerID.Text));
            myOwners.setForename(txtForename.Text);
            myOwners.setSurname(txtSurname.Text);
            myOwners.setStreet(txtBoxAdd1.Text);
            myOwners.setTown(txtBoxAdd2.Text);
            myOwners.setCounty(txtBoxCounty.Text);
            myOwners.setPhone(txtPhone.Text);
            myOwners.setEmail(txtEmail.Text);

            //Set Owner Activity as Inactive
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

            grpOwners.Visible = false;
            grdOwners.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtOwnerSearch.Text == "")
            {
                MessageBox.Show("Search must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOwnerSearch.Text = "";
                txtOwnerSearch.Focus();
                return;
            }
            //Load DataGrid with matching data
            if (Regex.IsMatch(txtOwnerSearch.Text, @"^[a-zA-Z ]+$"))
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

        private void grdOwners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load Text boxes with data from selected object

            txtOwnerID.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtForename.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtBoxAdd1.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtBoxAdd2.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtBoxCounty.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtPhone.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[6].Value.ToString();
            txtEmail.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[7].Value.ToString();

            Height = 530;

            grpOwners.Visible = true;
        }

    }
}
