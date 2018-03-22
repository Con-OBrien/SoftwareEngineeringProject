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
            MessageBox.Show("Tenant removed from the System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previousform
            parent.Show();
        }
    }
}
