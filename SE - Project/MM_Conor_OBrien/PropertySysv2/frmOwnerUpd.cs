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


        private void grdOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpOwners.Visible = true;
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
            myOwners.setOwnerId(Convert.ToInt32(txtOwnerID.Text));
            myOwners.setForename(txtForename.Text);
            myOwners.setSurname(txtSurname.Text);
            myOwners.setStreet(txtBoxAdd1.Text);
            myOwners.setTown(txtBoxAdd2.Text);
            myOwners.setCounty(txtBoxCounty.Text);
            myOwners.setPhone(Convert.ToInt32(txtPhone.Text));
            myOwners.setEmail(txtEmail.Text);
            myOwners.setActivity(txtActivity.Text);

            //INSERT Stock record into stock table
            myOwners.updOwner();

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
            DataSet ds = new DataSet();
            grdOwners.DataSource = PropertySysv2.Owner.getSpecificOwners(ds, txtOwnerSearch.Text.ToUpper()).Tables["ss"];

            grdOwners.Visible = true;
        }

        private void grdOwners_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
