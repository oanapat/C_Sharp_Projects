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
//Entering employee Information

namespace EmployeeInfo
{
    public partial class Form1 : Form
    {
        //List to hold the Employee Inputs
        List<Employee> employeeList = new List<Employee>();


        public Form1()
        {
            InitializeComponent();
        }

        //The method assigns the data entered by the user to the object's properties.
        private void GetEmployeeInfo(Employee employeeInfo)
        {
            //temporary variable to hold the ID
            int employeeID;

            //Get the Employee Name
            employeeInfo.Name = nameTextBox.Text;

            //get the Employee ID number

            if (int.TryParse(idNumberTextBox.Text, out employeeID))
            {
                employeeInfo.IdNumber = employeeID;
            }

            else
            {
                MessageBox.Show("The employee ID you entered is invalid");
            }

            //get the Employee Department
            employeeInfo.Department = departmentTextBox.Text;

            //get the Employee Position
            employeeInfo.Position = positionTextBox.Text;

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void informationButton_Click(object sender, EventArgs e)
        {
            //Create a Employee object
            Employee infoEmployee = new Employee();

            GetEmployeeInfo(infoEmployee);

            //adding the object to the list
            employeeList.Add(infoEmployee);

            //adding an entry to the list box
            employeelistBox.Items.Add(infoEmployee.Name + " " + infoEmployee.Department + " " +
                infoEmployee.Position + " " + infoEmployee.IdNumber);

            //Clear the Text boxes
            nameTextBox.Clear();
            idNumberTextBox.Clear();
            departmentTextBox.Clear();
            positionTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
