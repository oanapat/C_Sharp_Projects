using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            //this is the number the user inputs to be converted, thus we created a variable for that particular number
            double userInput = double.Parse(this.inputTextBox.Text);
            
            int measureInput = fromDistanceListBox.SelectedIndex;
            int measureOutput = toDistanceListBox.SelectedIndex;

            switch (measureInput)
            {
                    //Inches
                case 0:
                    switch (measureOutput)
                    {
                        case 0:
                           resultTextBox.Text  = userInput.ToString();
                            break;
                        case 1:
                            resultTextBox.Text = (userInput / 12).ToString();
                            break;
                        case 2:
                            resultTextBox.Text = (userInput / 12 / 3).ToString();
                            break;
                    }
                    break;

                //Feet
                case 1:
                    switch (measureOutput)
                    {
                        case 0:
                            resultTextBox.Text = (userInput * 12).ToString();
                            break;
                        case 1:
                            resultTextBox.Text = userInput.ToString();
                            break;
                        case 2:
                            resultTextBox.Text = (userInput / 3).ToString();
                            break;
                    }
                    break;
                //Yards
                case 2:
                    switch (measureOutput)
                    {
                        case 0:
                            resultTextBox.Text = (userInput * 36).ToString();
                            break;
                        case 1:
                            resultTextBox.Text = (userInput * 3).ToString();
                            break;
                        case 2:
                            resultTextBox.Text = userInput.ToString();
                            break;
                    }
                    break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

