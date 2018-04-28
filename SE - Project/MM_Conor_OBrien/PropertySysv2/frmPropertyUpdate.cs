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
    public partial class frmPropertyUpdate : Form
    {
        frmMainMenu parent;
        public frmPropertyUpdate()
        {
            InitializeComponent();
        }
        public frmPropertyUpdate(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previousform
            parent.Show();
        }

        private void updProperty_Click(object sender, EventArgs e)
        {
            //Validate Data
            if (txtRent.Text.Equals("") || txtBedrooms.Text.Equals("") || txtBathrooms.Text.Equals("") || txtHouse.Text.Equals("") || txtAdd1.Text.Equals("") || txtAdd2.Text.Equals("") || txtCounty.Text.Equals("") || txtActivity.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }        

            //Display Confirmation message
            MessageBox.Show("Owner Updated In System", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Instantiate Property Object
            Property myProps = new Property();
            myProps.setRentPerMonth(Convert.ToInt32(txtRent.Text));
            myProps.setBedrooms(Convert.ToInt32(txtBedrooms.Text));
            myProps.setBathrooms(Convert.ToInt32(txtBathrooms.Text));
            myProps.setHouseType(txtHouse.Text);
            myProps.setStreet(txtAdd1.Text);
            myProps.setTown(txtAdd2.Text);
            myProps.setCounty(txtCounty.Text);
            myProps.setActivity(txtActivity.Text);
            myProps.setOwnerId(Convert.ToInt32(txtOwnerID.Text));

            //INSERT Property record into Property Table
            myProps.updProp();

            //Reset UI
            txtRent.Text = "";
            txtBedrooms.Text = "";
            txtBathrooms.Text = "";
            txtHouse.Text = "";
            txtAdd1.Text = "";
            txtAdd2.Text = "";
            txtCounty.Text = "";
            txtActivity.Text = "";
            txtOwnerID.Text = "";

            grdProperties.Visible = false;
            grpProperties.Visible = false;
            cboBeds.SelectedIndex = -1;
            cboTown.SelectedIndex = -1;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Populate DataGrid
            DataSet ds = new DataSet();
            grdProperties.DataSource = Property.getSpecificProps(ds, cboTown.Text, Convert.ToInt32(cboBeds.Text)).Tables["ss"];

            grdProperties.Visible = true;
            grpProperties.Visible = true;
        }

        private void frmPropertyUpdate_Load(object sender, EventArgs e)
        {
            //Fill combo boxes with options
            DataSet ds = new DataSet();
            ds = Property.getTown(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cboTown.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            for (int i = 1; i <= 6; i++)
                cboBeds.Items.Add(i.ToString());
        }

        private void grdProperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Populate Text boxes with selected data from DataGrid 
            txtRent.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtBedrooms.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtBathrooms.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtHouse.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtAdd1.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtAdd2.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[6].Value.ToString();
            txtCounty.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[7].Value.ToString();
            txtActivity.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[8].Value.ToString();
            txtOwnerID.Text = grdProperties.Rows[grdProperties.CurrentCell.RowIndex].Cells[9].Value.ToString();

            grpProperties.Visible = true;
        }
    }
}
