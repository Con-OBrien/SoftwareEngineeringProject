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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnuAddOwner_Click(object sender, EventArgs e)
        {
            //hide themain menu
            this.Hide();

            //create an instance of the class frmOwnerAdd
            frmOwnerAdd nextForm = new frmOwnerAdd(this);
            nextForm.Show();
        }

        private void mnuUpdateOwner_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmOwnerUpd nextForm = new frmOwnerUpd(this);
            nextForm.Show();
        }

        private void mnuRemoveOwner_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmOwnerRemove nextForm = new frmOwnerRemove(this);
            nextForm.Show();
        }

        private void mnuSearchOwner_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmOwnerSearch nextForm = new frmOwnerSearch(this);
            nextForm.Show();
        }

        private void mnuAddProperty_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmPropertyAdd nextForm = new frmPropertyAdd(this);
            nextForm.Show();
        }

        private void mnuUpdateProperty_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmPropertyUpdate nextForm = new frmPropertyUpdate(this);
            nextForm.Show();
        }

        private void mnuRemoveProperty_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmPropertyRemove nextForm = new frmPropertyRemove(this);
            nextForm.Show();
        }

        private void mnuSearchProperty_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmPropertySearch nextForm = new frmPropertySearch(this);
            nextForm.Show();
        }

        private void mnuRentProperty_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRentProperty nextForm = new frmRentProperty(this);
            nextForm.Show();
        }

        private void mnuUpdateTenant_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmTenantUpdate nextForm = new frmTenantUpdate(this);
            nextForm.Show();
        }

        private void mnuRemoveTenant_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmTenantRemove nextForm = new frmTenantRemove(this);
            nextForm.Show();
        }

        private void mnuSearchTenant_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmTenantSearch nextForm = new frmTenantSearch(this);
            nextForm.Show();
        }

        private void mnuCalculateRent_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCalculateRent nextForm = new frmCalculateRent(this);
            nextForm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
