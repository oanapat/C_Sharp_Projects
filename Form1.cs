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

namespace OrganismPopulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            //local variables
            double numOrganism;     //the number of organisms
            double dailyIncrease;  //daily increase
            int numDays;          //number of months
            int count = 1;        //counter variable

            
            //this loop will convert numOrganismsTextBox to a double.
            //if the conversion is succesfull the result is stored in the numOrganism 
            //variable and the program continues executing
            //if the conversion is not succesfull the program jumps to the else clause
            if (double.TryParse(numOrganismsTextBox.Text, out numOrganism)
                && double.TryParse(dailyIncreaseTextBox.Text, out dailyIncrease)
                && int.TryParse(numDaysTextBox.Text, out numDays))
            {
                resultsList.Items.Add("Day             Approximate Population");
                //this statement ensures that the dailyIncrease is considered as a %
                dailyIncrease /= 100;
               
                while (count <= numDays)
                {
                   
                    //this prints out the initial value (cout is 1 and organism is 2) 
                    //and then it starts incrementing and calculating
                    resultsList.Items.Add(count + "                       " + numOrganism);

                    //add one to the loop counter
                    count = count + 1;
                    //calculating the Organism number
                    numOrganism += numOrganism * dailyIncrease;
                }

            }
            else
            {
                MessageBox.Show("Invalid input. Please try again.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultsList.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

