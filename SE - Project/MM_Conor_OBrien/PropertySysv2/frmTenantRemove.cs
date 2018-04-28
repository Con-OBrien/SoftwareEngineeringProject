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
            myTenant.setSurname(txtSurname.Text);
            myTenant.setPhone(Convert.ToInt32(txtPhone.Text));
            myTenant.setEmail(txtEmail.Text);

            //Set Tenant record in table as Inactive
            myTenant.rmvTenant();

            //Display Confirmation message
            MessageBox.Show("Property Removed From System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI           
            txtTenantID.Text = "";
            txtForename.Text = "";
            txtSurname.Text = "";
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
            txtSurname.Text = grdTenants.Rows[grdTenants.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtPhone.Text = grdTenants.Rows[grdTenants.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = grdTenants.Rows[grdTenants.CurrentCell.RowIndex].Cells[4].Value.ToString();

            grpTenants.Visible = true;
        }
    }
}
