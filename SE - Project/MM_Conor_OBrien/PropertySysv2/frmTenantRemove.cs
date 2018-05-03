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
    public partial class frmTenantRemove : Form
    {
        frmMainMenu parent;
        public frmTenantRemove()
        {
            InitializeComponent();
        }
        public frmTenantRemove(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void btnRmv_Click(object sender, EventArgs e)
        {
            //Show Confirmation Message
            MessageBox.Show("Tenant removed from the System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //instantiate Tenant Object
            Tenant myTenant = new Tenant();
            myTenant.setTenantId(Convert.ToInt32(txtTenantID.Text));
            myTenant.setForename(txtForename.Text);
            myTenant.setSurname(txtTenantSearch.Text);
            myTenant.setPhone(txtPhone.Text);
            myTenant.setEmail(txtEmail.Text);

            //Set Tenant record in table as Inactive
            myTenant.rmvTenant();

            //Display Confirmation message
            MessageBox.Show("Property Removed From System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI           
            txtTenantID.Text = "";
            txtForename.Text = "";
            txtTenantSearch.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";         

            grpTenants.Visible = false;
            grdTenants.Visible = false;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previousform
            parent.Show();
        }

        private void frmTenantRemove_Load(object sender, EventArgs e)
        {

        }

        private void grdOwners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Populate Text boxes with data from selected object from GridView
            txtForename.Text = grdTenants.Rows[grdTenants.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtTenantSearch.Text = grdTenants.Rows[grdTenants.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = grdTenants.Rows[grdTenants.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = grdTenants.Rows[grdTenants.CurrentCell.RowIndex].Cells[4].Value.ToString();

            grpTenants.Visible = true;
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
                txtTenantSearch.Text = "";
                txtTenantSearch.Focus();
                return;
            }
        }
    }
}
