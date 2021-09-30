using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static CIS227FinalFormAlbright.Form1;

/*
 *
 * CIS 227 Final Project (Form)
 * 
 * Description: This form is launched when a user presses the
 * "Add Employee" button on the main form Form1. It creates 
 * an employee object using the public Employee class of Form1.
 * In doing so, it handles all exceptions and makes sure that 
 * each field contains a valid value. 
 * 
 * The public array currentEmployees and integer employeeCount
 * are updated after the user presses the "Add Employee" button 
 * (without any message boxes for errors showing up). The user
 * can press the reset button to remove all values in the 
 * text boxes, list boxes, and combo boxes of the form.
 * 
 * In order to see the new employee on the list box in Form1,
 * the user must press the "Show Full List" button. 
 * 
 * File Name: CIS227FinalFormAlbright > AddEmployeeForm.cs
 * Programmer: John Albright
 * Date: May 15, 2021
 *
*/


namespace CIS227FinalFormAlbright
{
    public partial class AddEmployeeForm : Form
    {
        // Declare global arrays to be filled in the load method
        static object[] days = new object[31];
        static object[] months = new object[12];
        static object[] yearsBirth = new object[DateTime.Today.Year - 18 - 1945 + 1];
        static object[] yearsHire = new object[DateTime.Today.Year - 1945];
        static object[] jobs = { "actor/actress", "doctor", "teacher", "waiter/waitress" };

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        // Method containing actions to perform once the AddEmployeeForm is loaded
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            // Populate the days array
            for (int i = 0; i < days.Length; ++i)
            {
                days[i] = i + 1;
            }
            
            // Populate the months array
            for (int i = 0; i < months.Length; ++i)
            {
                months[i] = i + 1;
            }

            // Populate the years birth array
            for (int i = 0; i < yearsBirth.Length; ++i)
            {
                yearsBirth[i] = i + 1945;
            }

            // Populate the years hire array
            for (int i = 0; i < yearsHire.Length; ++i)
            {
                yearsHire[i] = i + 1945;
            }

            // Load list box values
            listBoxGender.Items.AddRange(new object[]{ 'M', 'F' });
            comboBoxHireDateDay.Items.AddRange(days);
            comboBoxHireDateMonth.Items.AddRange(months);
            comboBoxHireDateYear.Items.AddRange(yearsHire);
            comboBoxBirthDateDay.Items.AddRange(days);
            comboBoxBirthDateMonth.Items.AddRange(months);
            comboBoxBirthDateYear.Items.AddRange(yearsBirth);
            comboBoxJobs.Items.AddRange(jobs);
        }

        // Method containing actions to perform for the "Add Employee" button
        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            // Declare variables to store values from form
            int birthDateMonth;
            int birthDateDay;
            int birthDateYear;
            DateTime birthDate;
            int hireDateMonth;
            int hireDateDay;
            int hireDateYear;
            DateTime hireDate;

            string firstName;
            string lastName;
            char gender;
            string job;
            double hourlyRate;

            // Extract general information
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            gender = (char)listBoxGender.SelectedItem;
            job = (string)comboBoxJobs.SelectedItem;

            // Convert the job to a job code
            char jobCode = job.ToUpper()[0];

            // Extract date information from buttons 
            birthDateMonth = (int)comboBoxBirthDateMonth.SelectedItem;
            birthDateDay = (int)comboBoxBirthDateDay.SelectedItem;
            birthDateYear = (int)comboBoxBirthDateYear.SelectedItem;
            hireDateMonth = (int)comboBoxHireDateMonth.SelectedItem;
            hireDateDay = (int)comboBoxHireDateDay.SelectedItem;
            hireDateYear = (int)comboBoxHireDateYear.SelectedItem;

            // Check for the validity of the hourly rate
            try
            {
                hourlyRate = Convert.ToDouble(txtHourlyRate.Text);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message + " Please enter a valid double.", "Hourly Rate Input Error", MessageBoxButtons.OK);
                return;
            }

            // Check for the validity of the birth date
            try
            {
                birthDate = new DateTime(birthDateYear, birthDateMonth, birthDateDay);
            }
            catch (ArgumentOutOfRangeException error)
            {
                MessageBox.Show(error.Message + " Please enter a valid birth date.", "Date Time Error", MessageBoxButtons.OK);
                return;
            }

            // Check for the validity of the hire date
            try
            {
                hireDate = new DateTime(hireDateYear, hireDateMonth, hireDateDay);
            }
            catch (ArgumentOutOfRangeException error)
            {
                MessageBox.Show(error.Message + " Please enter a valid hire date.", "Date Time Error", MessageBoxButtons.OK);
                return;
            }

            // Make sure the dates are at least 18 years apart
            if (hireDate.Year - birthDate.Year < 18)
            {
                MessageBox.Show("The hire date must be at least 18 years after the birth date", "Dates Error", MessageBoxButtons.OK);
                return;
            }

            // Declare instance of new employee
            Employee newEmployee = new Employee(firstName, lastName, gender, birthDate, hireDate, jobCode, hourlyRate);

            // Add employee object to Form1 and increment the employee count
            currentEmployees[employeeCount] = newEmployee;
            ++employeeCount;

            // Note: In order to see the new entries, the "Show Full List" button on Form1 must be clicked 
            // after closing this form
        }

        // Method to clear the form when the user presses the "Reset" button
        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Clear all text fields
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtHourlyRate.Text = "";

            // Deselect all list and combo boxes
            comboBoxBirthDateDay.ResetText();
            comboBoxBirthDateMonth.ResetText();
            comboBoxBirthDateYear.ResetText();
            comboBoxHireDateDay.ResetText();
            comboBoxHireDateMonth.ResetText();
            comboBoxHireDateYear.ResetText();
            comboBoxJobs.ResetText();
            listBoxGender.SelectedIndex = -1;
        }
    }
}
