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
    public partial class frmTenantUpdate : Form
    {
        frmMainMenu parent;
        public frmTenantUpdate()
        {
            InitializeComponent();
        }
        public frmTenantUpdate(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void txtTenantSearch_TextChanged(object sender, EventArgs e)
        {

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
            if (txtTenantSearch.Text == "")
            {
                MessageBox.Show("Search must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenantSearch.Focus();
                return;
            }
            if (Regex.IsMatch(txtTenantSearch.Text, @"^[a-zA-Z ]+$"))
            {
                DataSet ds = new DataSet();
                grdTenants.DataSource = PropertySysv2.Owner.getSpecificOwners(ds, txtTenantSearch.Text.ToUpper()).Tables["ss"];

                grdTenants.Visible = true;
            }
            else
            {
                MessageBox.Show("Search must be valid characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenantSearch.Focus();
                return;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // validate data
            if (txtForename.Text.Equals("") || txtSurname.Text.Equals("") || txtPhone.Text.Equals("") || txtEmail.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            String phone = txtPhone.Text;
            foreach (char c in phone)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Phone must be numeric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.Text = "";
                    return;
                }
            }


            if (txtActivity.Text.ToUpper() != "A" && txtActivity.Text.ToUpper() != "I")
            {
                MessageBox.Show("Activity must be A or I!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtActivity.Text = "";
                return;
            }

            //Display Confirmation message
            MessageBox.Show("Tenant Updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //instantiate Tenant Object
            Tenant myTenant = new Tenant();
            myTenant.setTenantId(Convert.ToInt32(txtTenantID.Text));

            if (PropertySysv2.Owner.validText(txtForename.Text))
            {
                myTenant.setForename(txtForename.Text);
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
                myTenant.setSurname(txtSurname.Text);
            }
            else
            {
                MessageBox.Show("Address Line 2 must be letters only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Text = "";
                txtSurname.Focus();
                return;
            }


            myTenant.setPhone(txtPhone.Text);
            if (PropertySysv2.Owner.validEmail(txtEmail.Text))
            {
                myTenant.setEmail(txtEmail.Text);
            }
            else
            {
                MessageBox.Show("Email must be correct format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            myTenant.setActivity(txtActivity.Text);

            //INSERT Tenant record into tenant table
            myTenant.updTenant();

            //reset UI
            txtTenantSearch.Text = "";
            txtForename.Text = "";
            txtSurname.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtActivity.Text = "";

            grpTenants.Visible = false;
            grdTenants.Visible = false;
            txtTenantSearch.Focus();
        }

        private void grdTenants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenantID.Text = grdTenants.Rows[grdTenants.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtForename.Text =  grdTenants.Rows[grdTenants.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = grdTenants.Rows[grdTenants.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = grdTenants.Rows[grdTenants.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = grdTenants.Rows[grdTenants.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtActivity.Text = grdTenants.Rows[grdTenants.CurrentCell.RowIndex].Cells[6].Value.ToString();


            grpTenants.Visible = true;
        }
    }
}
