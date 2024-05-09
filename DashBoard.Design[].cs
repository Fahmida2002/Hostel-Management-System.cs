using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSTEL_MANAGEMENT_SYSTEM__.cs
{
    public partial class Dashboard_Design_ : Form
    {
        public Dashboard_Design_()
        {
            InitializeComponent();
        }

       
       
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        Boolean labelVisible = true;

        private void timer1_Tick(object sender, EventArgs e)
        { 
            if(labelVisible==true)
            {
                hmsLabel.Visible = true;
                labelVisible = false;
            } 

            else
            {
                hmsLabel.Visible = false;
                labelVisible = true;
            }

        }

        private void Dashboard_Design__Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

       // private void radioButton1_CheckedChanged(object sender, EventArgs e)
       // {
           // AddNewRoom_Design.AN = new AddNewRoom_Design();
        //}
    }
}
