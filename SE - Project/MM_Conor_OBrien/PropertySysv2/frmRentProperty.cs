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
            txtBookingID.Text = PropertySysv2.Booking.getNextBookingId().ToString("00000");
            txtTenantID.Text = PropertySysv2.Tenant.getNextTenantId().ToString("00000");

            DataSet ds = new DataSet();           
            ds = Property.getProp(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cboProperty.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            DataSet rs = new DataSet();
            rs = Tenant.getTenant(rs);

            for (int u = 0; u < rs.Tables["rs"].Rows.Count; u++)
                cboTenant.Items.Add(rs.Tables[0].Rows[u][0].ToString());
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
                txtBookingID.Focus();
                return;
            }
            txtOwnerID.Text = Prop.getOwnerId().ToString("00000");
            //display Stock details
            txtPropID.Text = Prop.getPropId().ToString("00000");
            


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String dob = String.Format("{0:dd-MMM-yy}", dtpDOB.Value);
            // validate data
            if (txtSurname.Text.Equals("") || txtForename.Text.Equals("") || txtPhone.Text.Equals("") || txtEmail.Text.Equals("") || dtpDOB.Equals(""))
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
            myTenant.setDob(dob);
            myTenant.setPropID(Convert.ToInt32(txtPropID.Text));

            //INSERT Stock record into stock table
            myTenant.regTenant();

            //Booking newBooking = new Booking();
          //  newBooking.setBookingId(Convert.ToInt32(txtBookingID.Text));
            //newBooking.makeBooking();

           
            //reset UI
            txtPropID.Enabled = false;
            txtSurname.Enabled = false;
            txtForename.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            dtpDOB.Enabled = false;
            label1.Visible = true;

            grpDates.Visible = true;
                 
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            grpTenantSelect.Visible = true;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            grpTenants.Visible = true;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            String startDate = String.Format("{0:dd-MMM-yy}", dtpStart.Value);
            String endDate = String.Format("{0:dd-MMM-yy}", dtpEnd.Value);
            String dateRegistered = String.Format("{0:dd-MMM-yy}", dtpDOB.Value);

            Booking newBooking = new Booking();
            newBooking.setBookingId(Convert.ToInt32(txtBookingID.Text));
            newBooking.setDateRegistered(dateRegistered);
            newBooking.setStartOfLease(startDate);
            newBooking.setEndOfLease(endDate);
            newBooking.setPropId(Convert.ToInt32(txtPropID.Text));
            newBooking.setOwnerId(Convert.ToInt32(txtOwnerID.Text));

            newBooking.makeBooking();

            MessageBox.Show("Booking has been made and the landlord has been notified of your booking! Thank you using our service!");
        }

        private void cboTenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if resetting combo, ignore
            if (cboTenant.SelectedIndex == -1)
            {
                return;
            }
            //find stock details
            Tenant newTenant = new Tenant();
            newTenant.getTenant(Convert.ToInt32(cboTenant.Text.Substring(0, 1)));

            if (newTenant.getTenantId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Focus();
                return;
            }
            txtPropID.Text = newTenant.getPropID().ToString();
            txtTenantID.Text = newTenant.getTenantId().ToString();
            txtForename.Text = newTenant.getForename();
            txtSurname.Text = newTenant.getSurname();
            txtPhone.Text = newTenant.getPhone().ToString();
            txtEmail.Text = newTenant.getEmail();
            dtpDOB.Text = newTenant.getDOB();


        }


        private void txtOwnerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenantID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
