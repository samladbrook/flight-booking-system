using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace flightBooking
{
    
    public partial class Form1 : Form
    {
        bool isUserTA = false;
        int ecoSeats = 100;
        int FCSeats = 15;
        int FCPSeats = 5;
        int amtOwing = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //ask if the  user is a travel agent
            if (MessageBox.Show("Are you purchasing as a travel agent?", "Tickets", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //set the bool vairblae to true to show buyer is a travel agent
                isUserTA = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); //open new form
        }
    }
}
