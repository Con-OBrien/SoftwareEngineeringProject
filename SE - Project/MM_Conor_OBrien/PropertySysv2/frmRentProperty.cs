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
            //Load ID's
            txtBookingID.Text = PropertySysv2.Booking.getNextBookingId().ToString("00000");
            txtTenantID.Text = PropertySysv2.Tenant.getNextTenantId().ToString("00000");

            //Fill combo boxes with options
            DataSet ds = new DataSet();
            ds = Property.getTown(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cboTown.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            DataSet ts = new DataSet();
            ts = Tenant.getTenant(ts);

            for (int i = 0; i < ts.Tables["ss"].Rows.Count; i++)
                cboTenant.Items.Add(ts.Tables[0].Rows[i][0].ToString());

            for (int i = 1; i <= 6; i++)
                cboBeds.Items.Add(i.ToString());
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String activity = "A";
            String dob = String.Format("{0:dd-MMM-yy}", dtpDOB.Value);
            //Validate Data
            if (txtSurname.Text.Equals("") || txtForename.Text.Equals("") || txtPhone.Text.Equals("") || txtEmail.Text.Equals("") || dtpDOB.Equals(""))
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

            //Instantiate Tenant Object
            Tenant myTenant = new Tenant();
            myTenant.setTenantId(Convert.ToInt32(txtTenantID.Text));
            myTenant.setForename(txtForename.Text);
            myTenant.setSurname(txtSurname.Text);          
            myTenant.setPhone(Convert.ToInt32(txtPhone.Text));
            myTenant.setEmail(txtEmail.Text);
            myTenant.setDob(dob);
            myTenant.setActivity(activity);
            myTenant.setPropID(Convert.ToInt32(txtPropID.Text));

            Tenant total = new Tenant();
            int totalTenants = total.getSumTenants(Convert.ToInt32(txtPropID.Text));
            txtTotal.Text = totalTenants.ToString();

            
            //INSERT Tenant Record Into Tenant Table
            myTenant.regTenant();
          
            //Reset UI
            txtPropID.Enabled = false;
            txtSurname.Enabled = false;
            txtForename.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            dtpDOB.Enabled = false;
            lblMsg.Visible = true;

            grpDates.Visible = true;
                 
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            //Hides Alternative Options
            grpTenants.Visible = false;
            grpTenantSelect.Visible = true;

            txtForename.Enabled = false;
            txtSurname.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //Hides Alternative Options
            grpTenants.Visible = true;
            grpTenantSelect.Visible = false;
            grpDates.Visible = false;
            btnExisting.Visible = false;
            btnAdd.Visible = true;

            txtForename.Text = "";
            txtSurname.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtForename.Enabled = true;
            txtSurname.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            dtpDOB.Enabled = true;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            //Sets dates as string values
            dtpEnd.Value = dtpStart.Value.AddYears(1);
            String startDate = String.Format("{0:dd-MMM-yy}", dtpStart.Value);
            String endDate =     String.Format("{0:dd-MMM-yy}", dtpEnd.Value);
            String dateRegistered = String.Format("{0:dd-MMM-yy}", DateTime.Now);
            
            //Instantiate Booking Object
            Booking newBooking = new Booking();
            newBooking.setBookingId(Convert.ToInt32(txtBookingID.Text));
            newBooking.setDateRegistered(dateRegistered);
            newBooking.setStartOfLease(startDate);
            newBooking.setEndOfLease(endDate);
            newBooking.setPropId(Convert.ToInt32(txtPropID.Text));        

            //INSERT Bookings record into Bookings table
            newBooking.makeBooking();

            //Show Confirmation Message
            MessageBox.Show("Booking has been made and the landlord has been notified of your booking! Thank you using our service!");

            //Reset UI
            cboTown.SelectedIndex = -1;
            cboBeds.SelectedIndex = -1;
            grdProperties.Visible = false;
            grpDates.Visible = false;
            grpTenants.Visible = false;
            grpTenantSelect.Visible = false;
            lblTenant.Visible = false;
            btnYes.Visible = false;
            btnNo.Visible = false;

            txtPropID.Text = "";
            txtTenantID.Text = "";
            txtForename.Text = "";
            txtSurname.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            dtpDOB.ResetText();
            dtpStart.ResetText();
            dtpEnd.ResetText();
            txtBookingID.Text = PropertySysv2.Booking.getNextBookingId().ToString("00000");
            txtTenantID.Text = PropertySysv2.Tenant.getNextTenantId().ToString("00000");
            lblMsg.Visible = false;
        }

        private void cboTenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if resetting combo, ignore
            if (cboTenant.SelectedIndex == -1)
            {
                return;
            }
            //Instantiate Tenant Objects
            Tenant newTenant = new Tenant();
            newTenant.getTenant(Convert.ToInt32(cboTenant.Text.Substring(0, 1)));
            

            if (newTenant.getTenantId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Focus();
                return;
            }
            
            //Populate Text Boxes 
            txtTenantID.Text = newTenant.getTenantId().ToString();
            txtForename.Text = newTenant.getForename();
            txtSurname.Text = newTenant.getSurname();
            txtPhone.Text = newTenant.getPhone().ToString();
            txtEmail.Text = newTenant.getEmail();
            dtpDOB.Text = newTenant.getDOB();

            //Reset UI
            grpTenants.Visible = true;
            txtPropID.Enabled = false;
            txtTenantID.Enabled = false;
            txtForename.Enabled = false;
            txtSurname.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            dtpDOB.Enabled = false;
            btnExisting.Visible = true;
            btnAdd.Visible = false;
        }
        private void btnExisting_Click(object sender, EventArgs e)
        {
            grpDates.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Populate DataGrid
            DataSet ds = new DataSet();
            grdProperties.DataSource = Property.getSpecificProps(ds, cboTown.Text, Convert.ToInt32(cboBeds.Text)).Tables["ss"];
           
            grdProperties.Visible = true;

        }

        private void grdProperties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPropID.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtRooms.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[2].Value.ToString();

           

            lblTenant.Visible = true;
            btnYes.Visible = true;
            btnNo.Visible = true;

        }

        private void txtRooms_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdProperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
