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
    public partial class frmRentProperty : Form
    {
        frmMainMenu parent;
        public frmRentProperty()
        {
            InitializeComponent();
        }
        public frmRentProperty(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void grdTenants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grpTenants.Visible = true;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previousform
            parent.Show();
        }

        private void frmRentProperty_Load(object sender, EventArgs e)
        {
            txtTenantID.Text = PropertySysv2.Tenant.getNextTenantId().ToString("00000");

            DataSet ds = new DataSet();           
            ds = Property.getProp(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cboProperty.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        }

        private void cboProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if resetting combo, ignore
            if (cboProperty.SelectedIndex == -1)
            {
                return;
            }
            //find stock details
            Property Prop = new Property();
            Prop.getProperty(Convert.ToInt32(cboProperty.Text.Substring(0, 1)));

            if (Prop.getPropId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenantID.Focus();
                return;
            }

            //display Stock details
            txtPropID.Text = Prop.getPropId().ToString("000");

            grpTenants.Visible = true;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // validate data
            if (txtSurname.Text.Equals("") || txtForename.Text.Equals("") || txtPhone.Text.Equals("") || txtEmail.Text.Equals("") || txtDOB.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
  
            //instantiate Stock Object
            Tenant myTenant = new Tenant();
            myTenant.setTenantId(Convert.ToInt32(txtTenantID.Text));
            myTenant.setForename(txtForename.Text);
            myTenant.setSurname(txtSurname.Text);          
            myTenant.setPhone(Convert.ToInt32(txtPhone.Text));
            myTenant.setEmail(txtEmail.Text);
            myTenant.setDob(txtDOB.Text);

            //INSERT Stock record into stock table
            myTenant.regTenant();


            myTenant.makeBooking();

            //Display Confirmation Message
            MessageBox.Show("tenant " + txtTenantID.Text + " Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtPropID.Text = "";
            txtSurname.Text = "";
            txtForename.Text = "";          
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtDOB.Text = "";



            txtTenantID.Text = PropertySysv2.Tenant.getNextTenantId().ToString("00000");
            txtSurname.Focus();

        }
    }
}
