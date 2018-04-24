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
    public partial class frmPropertyAdd : Form
    {
        frmMainMenu parent;
        public frmPropertyAdd()
        {
            InitializeComponent();
        }
        public frmPropertyAdd(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void frmPropertyAdd_Load(object sender, EventArgs e)
        {
            txtPropertyID.Text = PropertySysv2.Property.getNextPropId().ToString("00000");
        }
       
        private void btnPropertyAdd_Click(object sender, EventArgs e)
        {
            if (txtRent.Text.Equals("") || txtBedroom.Text.Equals("") || txtBathroom.Text.Equals("") || txtBoxHouse.Text.Equals("") || txtBoxAdd1.Text.Equals("") || txtBoxAdd2.Text.Equals("") || txtBoxCounty.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            Property myProps = new Property();
            myProps.setPropId(Convert.ToInt32(txtPropertyID.Text));
            myProps.setRentPerMonth(Convert.ToInt32(txtRent.Text));
            myProps.setBedrooms(Convert.ToInt32(txtBedroom.Text));
            myProps.setBathrooms(Convert.ToInt32(txtBathroom.Text));
            myProps.setHouseType(txtBoxHouse.Text);
            myProps.setStreet(txtBoxAdd1.Text);
            myProps.setTown(txtBoxAdd2.Text);
            myProps.setCounty(txtBoxCounty.Text);
            myProps.setOwnerId(Convert.ToInt32(txtOwnerID.Text));

            myProps.regProp();

            MessageBox.Show("Property Added to System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtRent.Text = "";
            txtBedroom.Text = "";
            txtBathroom.Text = "";
            txtBoxHouse.Text = "";
            txtBoxAdd1.Text = "";
            txtBoxAdd2.Text = "";
            txtBoxCounty.Text = "";
            txtOwnerSearch.Text = "";

            grpOwners.Visible = false;
            grpProperty.Visible = false;
            grdOwners.Visible = false;

            txtPropertyID.Text = PropertySysv2.Property.getNextPropId().ToString("00000");
            txtRent.Focus();
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previousform
            parent.Show();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdOwners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOwnerID.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtForename.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtAdd1.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtAdd2.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtCounty.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtPhone.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[6].Value.ToString();
            txtEmail.Text = grdOwners.Rows[grdOwners.CurrentCell.RowIndex].Cells[7].Value.ToString();

            grpOwners.Visible = true;
            grpProperty.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            grdOwners.DataSource = PropertySysv2.Owner.getSpecificOwners(ds, txtOwnerSearch.Text.ToUpper()).Tables["ss"];   //(ds, txtSurname.Text).Tables["ss"];
            grdOwners.AllowUserToAddRows = false;
            grdOwners.Visible = true;
        }
    }
}
