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
    public partial class frmTenantSearch : Form
    {
        frmMainMenu parent;
        public frmTenantSearch()
        {
            InitializeComponent();
        }
        public frmTenantSearch(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Search field is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Regex.IsMatch(txtSurname.Text, @"^[a-zA-Z ]+$"))
            {
                DataSet ds = new DataSet();
                grdTenants.DataSource = PropertySysv2.Owner.getSpecificOwners(ds, txtSurname.Text.ToUpper()).Tables["ss"];

                grdTenants.Visible = true;
            }
            else
            {
                MessageBox.Show("Search must be valid characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Text = "";
                txtSurname.Focus();
                return;
            }
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previousform
            parent.Show();
        }

        private void txtSearchTenant_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdTenants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
