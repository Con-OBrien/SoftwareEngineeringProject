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
            if (txtSurname.Text == "")
            {
                MessageBox.Show("Search must be entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Text = "";
                txtSurname.Focus();
                return;
            }

            if (Regex.IsMatch(txtSurname.Text, @"^[a-zA-Z ]+$"))
            {
                DataSet ds = new DataSet();
                grdOwners.DataSource = PropertySysv2.Owner.getSpecificOwners(ds, txtSurname.Text.ToUpper()).Tables["ss"];

                grdOwners.Visible = true;
            }
            else
            {
                MessageBox.Show("Search must be valid characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Text = "";
                txtSurname.Focus();
                return;
            }
        }

        private void frmOwnerSearch_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
