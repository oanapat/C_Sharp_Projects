using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Oana Patrascu

//There are three seating categories at an athletic stadium. For a baseball game, Class
//A seats cost $15 each, Class B seats cost $12 each, and Class C seats cost $9 each.
//This program allows the user to enter the number of tickets sold for
//each class and display the amount of income generated from each class of ticket sales 
//as well as the total revenue generated.

namespace op_assignment2
{
    public partial class stadium : Form
    {
        public stadium()
        {
            InitializeComponent();
        }

        private void revenueCalc_Click(object sender, EventArgs e)
        {
            //This is where we declare our variables

            int outputA;
            int outputB;
            int outputC;
            int Total;

            //This is where we do our calculations
            outputA = int.Parse(textBoxA.Text) * 15;
            outputB = int.Parse(textBoxC.Text) * 12;
            outputC = int.Parse(textBoxB.Text) * 9;
            Total = outputA + outputB + outputC;
            
            //This is where we display our result
            labelA.Text = outputA.ToString("c");
            labelB.Text = outputB.ToString("c");
            labelC.Text = outputC.ToString("c");
            totalLabel.Text = Total.ToString("c");
            
        }

        //This is where we clear our boxes and labels
        private void clear_Click(object sender, EventArgs e)
        {
            textBoxA.Text = " ";
            textBoxB.Text = " ";
            textBoxC.Text = " ";

            labelA.Text = " ";
            labelB.Text = " ";
            labelC.Text = " ";
            totalLabel.Text = " ";

        }

        //This is where we exit our program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
