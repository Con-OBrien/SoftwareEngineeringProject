﻿using System;
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
    public partial class frmOwnerAdd : Form
    {
        frmMainMenu parent;

        public frmOwnerAdd()
        {
            InitializeComponent();
        }

        public frmOwnerAdd(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // validate data
            if (txtSurname.Text.Equals("") || txtForename.Text.Equals("") || txtPhone.Text.Equals("") || txtEmail.Text.Equals("") || txtBoxAdd1.Text.Equals("") || txtBoxAdd2.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

          
      
            //instantiate Stock Object
            Owner myOwners = new Owner();
            myOwners.setOwnerId(Convert.ToInt32(txtOwnerID.Text));
            myOwners.setForename(txtForename.Text);
            myOwners.setSurname(txtSurname.Text);
            myOwners.setStreet(txtBoxAdd1.Text);
            myOwners.setTown(txtBoxAdd2.Text);
            myOwners.setCounty(txtBoxCounty.Text);
            myOwners.setPhone(Convert.ToInt32(txtPhone.Text));
            myOwners.setEmail(txtEmail.Text);

            //INSERT Stock record into stock table
            myOwners.regOwner();

            //Display Confirmation Message
            MessageBox.Show("Owner " + txtOwnerID.Text + " Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtSurname.Text = "";
            txtForename.Text = "";
            txtBoxAdd1.Text = "";
            txtBoxAdd2.Text = "";
            txtBoxCounty.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";


            txtOwnerID.Text = PropertySysv2.Owner.getNextOwnerId().ToString("00000");
            txtSurname.Focus();

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close current form
            this.Close();

            //go back to previousform
            parent.Show();
                                         

        }

        private void frmOwnerAdd_Load(object sender, EventArgs e)
        {
            //get the next OwnerId

           
            txtOwnerID.Text = PropertySysv2.Owner.getNextOwnerId().ToString("00000");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpOwner_Enter(object sender, EventArgs e)
        {

        }
    }
}
