using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace flightBooking
{
    public partial class Form2 : Form
    {
        string bookingRef;
        StreamReader reader;
        StreamWriter writer;
        bool isUserTA = false;
        int ecoSeats = 100;
        int FCSeats = 15;
        int FCPSeats = 5;
        int amtOwing = 0;
        int ecoMealAmt = 0;
        int FCMealAmt = 0;
        int FCPMealAmt = 0;
        int ecoSeatsAmt = 0;
        int FCSeatsAmt = 0;
        int FCPSeatAmt = 0;
        int ecoAmtOwing = 0;
        int FCAmtOwing = 0;
        int FCPAmtOwing = 0;
        int totalSeatNum = 0;
        int totalMealNum = 0;
        int totalAmtOwing = 0;
        int bookingRefNum;
        StreamWriter writer2;
        string[] seatLocationArray = new string[99];
        bool[] mealYVNArray = new bool[99];
        bool mealYVN = false;
        int linePrice = 0;
        int[] linePriceArray = new int[99];
        


        public Form2()
        {
            InitializeComponent();
        }

        private void buttonEcoAddCart_Click(object sender, EventArgs e)
        {
            string seatLocation = Interaction.InputBox("What is your prefferred seat location?", "Seat Selection");
            if (MessageBox.Show("Do you want a meal with that ticket at a futher charge of $15", "Meal", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //set the bool vairblae to true to show buyer is a travel agent
                mealYVN = true;
                ecoMealAmt++;
                ecoAmtOwing += 15;
                linePrice += 15;
            }

            //add one to seat count
            ecoSeats--;
            ecoSeatsAmt++;
            ecoAmtOwing += 150;
            linePrice += 150;
            updateVaribales();

            mealYVNArray[ecoSeatsAmt - 1] = mealYVN; 
            seatLocationArray[ecoSeatsAmt - 1] = seatLocation;
            linePriceArray[ecoSeatsAmt - 1] = linePrice;

            linePrice = 0;
            ////////add other add to cart seat buttons now
        }

        private void updateVaribales()
        {
            labelEcoSeat.Text = ecoSeats.ToString();
            labelEcoCartNum.Text = ecoSeatsAmt.ToString();
            labelEcoAmtOwing.Text = ecoAmtOwing.ToString();
            labelMealAmtEco.Text = ecoMealAmt.ToString();

            labelFCSeat.Text = FCSeats.ToString();
            labelFCCartNum.Text = FCSeatsAmt.ToString();
            labelFCAmtOwing.Text = FCAmtOwing.ToString();
            labelMealAmtFC.Text = FCMealAmt.ToString();

            labelFCPSeat.Text = FCPSeats.ToString();
            labelFCPCartNum.Text = FCPSeatAmt.ToString();
            labelFCPAmtOwing.Text = FCPAmtOwing.ToString();
            labelMealAmtFCP.Text = FCPMealAmt.ToString();




            //get total
            totalSeatNum = ecoSeatsAmt + FCPSeatAmt + FCSeatsAmt;
            totalMealNum = ecoMealAmt + FCMealAmt + FCPMealAmt;
            totalAmtOwing = ecoAmtOwing + FCAmtOwing + FCPAmtOwing;

            labelTicketAmtTotal.Text = totalSeatNum.ToString();
            labelMealAmtTotal.Text = totalMealNum.ToString();
            labelPriceTotal.Text = totalAmtOwing.ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            reader = File.OpenText("bookingRefNum.txt");
            bookingRefNum = int.Parse(reader.ReadLine());
            bookingRef = "booking" + bookingRefNum.ToString();
            labelBookingRef.Text = bookingRef;
            writer = File.AppendText(bookingRef + ".txt");
            reader.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            bookingRefNum++;
            File.WriteAllText("bookingRefNum.txt", String.Empty);
            using (writer2 = File.AppendText("bookingRefNum.txt"))
            { 
                writer2.WriteLine(bookingRefNum);
            }
            writer2.Close();

            

            using (writer = File.AppendText(bookingRef + ".txt"))
            {
                for(int i = 0; i < totalSeatNum; i++)
                {
                    for(int p = 0; p < ecoSeatsAmt; p++)
                    {
                        //writer.WriteLine(seatLocation,);
                    }
                }
            }

            this.Close();
        }
    }
}
