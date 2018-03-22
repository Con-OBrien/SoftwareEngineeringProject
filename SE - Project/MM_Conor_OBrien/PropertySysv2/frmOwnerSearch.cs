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
    public partial class frmOwnerSearch : Form
    {
        frmMainMenu parent;
        public frmOwnerSearch()
        {
            InitializeComponent();
        }
        public frmOwnerSearch(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void grdOwners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previousform
            parent.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //check that owner number is entered
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("OwnerID must be Entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            //find owner details
            Owner srhOwner = new Owner();
            srhOwner.getOwner(Convert.ToInt32(txtSearch.Text));

            if (srhOwner.getOwnerId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            //display Owner details
            txtForename.Text = srhOwner.getForename();
            txtSurname.Text = srhOwner.getSurname();
            txtAdd1.Text = srhOwner.getStreet();
            txtAdd2.Text = srhOwner.getTown();
            txtCounty.Text = srhOwner.getCounty();
            txtPhone.Text = srhOwner.getPhone().ToString();
            txtEmail.Text = srhOwner.getEmail();


            //display details
            grpOwner.Visible = true;
        }

        private void frmOwnerSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
