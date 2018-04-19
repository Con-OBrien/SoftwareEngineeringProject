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
            grdTenants.DataSource = Tenant.getSurnamesTenant(ds, txtTenantSearch.Text).Tables["ss"];

            grdTenants.Visible = true;
        }
    }
}
