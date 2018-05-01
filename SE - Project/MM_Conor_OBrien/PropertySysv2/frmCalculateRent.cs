using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PropertySysv2
{
    public partial class frmCalculateRent : Form
    {
        frmMainMenu parent;
        public frmCalculateRent()
        {
            InitializeComponent();
        }
        public frmCalculateRent(frmMainMenu Parent)
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

        private void frmCalculateRent_Load(object sender, EventArgs e)
        {
            //Populate Combo Boxes
            DataSet ds = new DataSet();
            ds = Property.getTown(ds);
            

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cboTown.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            DataSet cs = new DataSet();
            cs = Property.getCounty(cs);

            for (int q = 0; q < cs.Tables["ss"].Rows.Count; q++)
                cboCounty.Items.Add(cs.Tables[0].Rows[q][0].ToString());

        }

        private void cboCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTown.Visible = true;
            cboTown.Visible = true;
            btnSearch.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int locationSum;
            String county = cboCounty.SelectedItem.ToString();


            if (cboTown.SelectedItem == null)
            {
                locationSum = Booking.getMonthlyData(county);

                txtTotal.Text = locationSum.ToString();
                lblTotal.Visible = true;
                txtTotal.Visible = true;
            }
            else
            {
                String town = cboTown.SelectedItem.ToString();

                locationSum = Booking.getMonthlyData(county, town);

                txtTotal.Text = locationSum.ToString();
                lblTotal.Visible = true;
                txtTotal.Visible = true;
            }           
        }
    }
}
