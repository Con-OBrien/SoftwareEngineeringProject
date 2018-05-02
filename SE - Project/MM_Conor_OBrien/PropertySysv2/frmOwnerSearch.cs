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
            DataSet ds = new DataSet();
            
            grdOwners.DataSource = PropertySysv2.Owner.getSpecificAllOwners(ds, txtSurname.Text.ToUpper()).Tables["ss"];   //(ds, txtSurname.Text).Tables["ss"];
            grdOwners.AllowUserToAddRows = false;
            grdOwners.Visible = true;
        }

        private void frmOwnerSearch_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
