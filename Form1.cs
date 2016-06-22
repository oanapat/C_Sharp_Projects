using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeProductionWorker
{
    public partial class Form1 : Form
    {
       // list to hold the info
        
        List<ProductionWorker> employeeList = new List<ProductionWorker>();
        public Form1()
        {
            InitializeComponent();
        }


        private void infoButton_Click(object sender, EventArgs e)
        {

            ProductionWorker employeeInfo = new ProductionWorker(int.Parse(shiftTextBox.Text), double.Parse(payRateTextBox.Text));
             
            //this belongs to the base class
            employeeInfo.employeeName = nameTextBox.Text;
            employeeInfo.employeeNumber = int.Parse(numTextBox.Text);

               
                
        //declaring a shift variable to be used in the list and if/else statement
            string shift = "Day";

            if (employeeInfo._shift == 1)
            {
                shift = "Day";
            }

            else
            {
                shift = "Night";
            }

            //adding the information to the list
            listBox1.Items.Add(shift + "         " + employeeInfo._hourlyRate + "           " +
                employeeInfo._employeeName + "           " + employeeInfo._employeeNumber);
        
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the Text boxes
            nameTextBox.Clear();
            numTextBox.Clear();
            shiftTextBox.Clear();
            payRateTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
        
    }
}
