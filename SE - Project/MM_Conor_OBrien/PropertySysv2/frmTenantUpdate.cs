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

            DataSet ds = new DataSet();
            grdTenants.DataSource = Tenant.getSurnamesTenant(ds, txtTenantSearch.Text).Tables["rs"];

            grdTenants.Visible = true;
        }

        private void grdTenants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                
            
        }

        private void grdTenants_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            grpTenants.Visible = true;

            String forename = grdTenants.SelectedRows[0].Cells[1].Value + string.Empty;
            String surname = grdTenants.SelectedRows[0].Cells[2].Value + string.Empty;
            String phone = grdTenants.SelectedRows[0].Cells[3].Value + string.Empty;
            String email = grdTenants.SelectedRows[0].Cells[4].Value + string.Empty;

            txtForename.Text = forename;
            txtSurname.Text = surname;
            txtPhone.Text = phone;
            txtEmail.Text = email;

        }

        private void grdTenants_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
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
                    return;
                }
            }

            //Display Confirmation message
            MessageBox.Show("Tenant Updated!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //instantiate Tenant Object
            Tenant myTenant = new Tenant();
            myTenant.setTenantId(Convert.ToInt32(txtTenantID.Text));
            myTenant.setForename(txtForename.Text);
            myTenant.setSurname(txtSurname.Text);
            myTenant.setPhone(Convert.ToInt32(txtPhone.Text));
            myTenant.setEmail(txtEmail.Text);

            //INSERT Tenant record into tenant table
            myTenant.updTenant();

            //reset UI
            txtTenantSearch.Text = "";
            txtForename.Text = "";
            txtSurname.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";

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
            
          
            grpTenants.Visible = true;
        }

        private void grpTenants_Enter(object sender, EventArgs e)
        {

        }

        private void frmTenantUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
