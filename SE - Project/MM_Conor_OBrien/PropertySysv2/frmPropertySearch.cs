﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertySysv2
{
    public partial class frmPropertySearch : Form
    {
        frmMainMenu parent;
        public frmPropertySearch()
        {
            InitializeComponent();
        }
        public frmPropertySearch(frmMainMenu Parent)
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

        private void frmPropertySearch_Load(object sender, EventArgs e)
        {
            //Populate Combo Boxes
            DataSet ds = new DataSet();
            ds = Property.getTown(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cboTown.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            for (int i = 1; i < 6; i++)
                cboBeds.Items.Add(i.ToString());
        }
  

        private void cboTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBeds.Visible = true;
            lblBeds.Visible = true;
            btnSearch.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Populate DataGrid         
            DataSet ds = new DataSet();
            if (cboBeds.SelectedItem == null)
            {
                grdProperties.DataSource = Property.getSpecificAllProps(ds, cboTown.Text).Tables["ss"];

            }
            else
            {
                grdProperties.DataSource = Property.getSpecificAllProps(ds, cboTown.Text, Convert.ToInt32(cboBeds.Text)).Tables["ss"];
            }

            grdProperties.Visible = true;

        }
    }
}
