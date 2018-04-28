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

        private void button1_Click(object sender, EventArgs e)
        {
            grdTenants2.Visible = true;
            button2.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
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

        }
    }
}
