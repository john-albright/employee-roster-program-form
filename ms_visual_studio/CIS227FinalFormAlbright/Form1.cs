using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *
 * CIS 227 Final Project (Form)
 * 
 * Description: This project manages a employee roster list. The program 
 * is based on an Employee class with 8 instance variables:
 * - first name (string)
 * - last name (string)
 * - gender (char: M, F)
 * - birth date (DateTime object)
 * - hire date (DateTime object)
 * - job code (A, D, T, W)
 * - job (actor/actress, doctor, teacher, waiter/waitress)
 * - hourly rate
 * The class also contains two static methods: CalculateAge() and ToString().
 * The constructor for the class accepts all parameters except the job and 
 * automatically assigns the job value based on the job code (through the 
 * constructor and the setter). 
 * 
 * The form contains the following buttons:
 * - Search
 * - Remove Employee
 * - Add Employee
 * - Reset List 
 * - Show Full List
 * 
 * The Add Employee button launches an AddEmployeeForm, which alters the 
 * list of employees given that valid information is entered in each field.
 * The Search button finds the employees with a specific job code after the
 * user selects the job from a combo box to the left of the button. The Reset
 * List button undoes all the changes made in the session and puts the original
 * 7 employees back in the currentEmployees array. The Show Full List button
 * is to be used after the Search button is pressed (to see all the members of 
 * the list). It should also be used after an employee is successfull added
 * in the AddEmployeeForm.
 * 
 * File Name: CIS227FinalFormAlbright > Form1.cs
 * Programmer: John Albright
 * Date: May 15, 2021
 *
*/

namespace CIS227FinalFormAlbright
{
    public partial class Form1 : Form
    {

        // Declare global variables for the methods of the program
        public static Employee[] currentEmployees = new Employee[100];
        public static int employeeCount = 0;
        static object[] jobs = { "actor/actress", "doctor", "teacher", "waiter/waitress" };

        // Create the primary class for the program
        public class Employee
        {
            private string firstName;
            private string lastName;
            private char gender;
            private DateTime birthDate;
            private DateTime hireDate;
            private char jobCode;
            private string job;
            private double hourlyRate;

            public string FirstName
            {
                get { return this.firstName; }
                set { this.firstName = value; }
            }

            public string LastName
            {
                get { return this.lastName; }
                set { this.lastName = value; }
            }

            public char Gender
            {
                get { return this.gender; }
                set
                {
                    if (value == 'M' || value == 'F')
                        this.gender = value;
                    else
                        this.gender = 'X';
                }
            }

            public DateTime BirthDate
            {
                get { return this.birthDate; }
                set { this.birthDate = value; }
            }

            public DateTime HireDate
            {
                get { return this.hireDate; }
                set { this.hireDate = value; }
            }

            public char JobCode
            {
                get { return this.jobCode; }
                set
                {
                    this.jobCode = value;



                    if (value == 'D' || value == 'T' || value == 'W' || value == 'A')
                    {
                        this.jobCode = value;

                        if (value == 'D')
                            this.job = "Doctor";
                        else if (value == 'T')
                            this.job = "Teacher";
                        else if (value == 'W')
                        {
                            if (Gender == 'M')
                                this.job = "Waiter";
                            else if (Gender == 'F')
                                this.job = "Waitress";
                            else
                                this.job = "Waiter/waitress";
                        }
                        else
                        {
                            if (Gender == 'M')
                                this.job = "Actor";
                            else if (Gender == 'F')
                                this.job = "Actress";
                            else
                                this.job = "Actor/actress";
                        }
                    }
                    else
                    {
                        this.jobCode = 'X';
                        this.job = "invalid job code";
                    }
                }
            }

            public string Job
            {
                get { return this.job; }
                set { this.job = value; }
            }

            public double HourlyRate
            {
                get { return this.hourlyRate; }
                set { this.hourlyRate = value; }
            }

            // Declare the constructor
            public Employee(string firstName, string lastName, char gender, DateTime birthDate, DateTime hireDate, char jobCode, double hourlyRate)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.gender = gender;
                this.birthDate = birthDate;
                this.hireDate = hireDate;
                this.jobCode = jobCode;
                this.hourlyRate = hourlyRate;

                // Set the job variable to the correct job based on the job code
                // This must be done since the constructor doesn't accept 
                // a job as an argument (only a job code). 
                if (jobCode == 'D' || jobCode == 'T' || jobCode == 'W' || jobCode == 'A')
                {
                    if (jobCode == 'D')
                        this.job = "Doctor";
                    else if (jobCode == 'T')
                        this.job = "Teacher";
                    else if (jobCode == 'W')
                    {
                        if (Gender == 'M')
                            this.job = "Waiter";
                        else if (Gender == 'F')
                            this.job = "Waitress";
                        else
                            this.job = "Waiter/waitress";
                    }
                    else
                    {
                        if (Gender == 'M')
                            this.job = "Actor";
                        else if (Gender == 'F')
                            this.job = "Actress";
                        else
                            this.job = "Actor/actress";
                    }
                }
                else
                {
                    this.jobCode = 'X';
                    this.job = "invalid job code";
                }
            }

            // Static methods for the Employee class
            // 1. Method to calculate the age of the employee
            public static int CalculateAge(DateTime birthDate)
            {
                // Calculate the difference in days, months, and years
                int age = DateTime.Today.Year - birthDate.Year;
                int monthDiff = DateTime.Today.Month - birthDate.Month;
                int dayDiff = DateTime.Today.Day - birthDate.Day;

                // Check to see if the birth date has happened yet this year
                if (monthDiff < 0 || dayDiff < 0)
                    age--;

                // Return the age
                return age;
            }

            // 2. Method to format how Employee objects are printed
            public override string ToString()
            {
                return $"{LastName}, {FirstName} | birth date: {BirthDate.ToString("d")} | "
                    + $"hire date: {HireDate.ToString("d")} | job: {Job.ToLower()}";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        // Method containing actions to perform once Form1 is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the currentEmployees array 
            Employee davisIndia = new Employee("India", "Davis", 'F', new DateTime(1979, 3, 1), new DateTime(2001, 4, 5), 'D', 57.52);
            davisIndia.JobCode = 'T';
            currentEmployees[employeeCount] = davisIndia;
            ++employeeCount;

            Employee larsonKyle = new Employee("Kyle", "Larson", 'M', new DateTime(1995, 5, 13), new DateTime(2015, 12, 29), 'A', 25.18);
            currentEmployees[employeeCount] = larsonKyle;
            ++employeeCount;

            Employee suarezOwen = new Employee("Owen", "Suarez", 'M', new DateTime(1995, 5, 16), new DateTime(2018, 1, 19), 'D', 55.67);
            currentEmployees[employeeCount] = suarezOwen;
            ++employeeCount;

            Employee arellanoAlejandra = new Employee("Alejandra", "Arellano", 'F', new DateTime(2001, 11, 15), new DateTime(2020, 10, 5), 'W', 5.25);
            currentEmployees[employeeCount] = arellanoAlejandra;
            ++employeeCount;

            Employee tranSimeon = new Employee("Simeon", "Tran", 'M', new DateTime(1998, 1, 11), new DateTime(2019, 12, 2), 'W', 5.65);
            currentEmployees[employeeCount] = tranSimeon;
            ++employeeCount;

            Employee papatonisAlex = new Employee("Alexandra", "Papatonis", 'F', new DateTime(1995, 8, 10), new DateTime(2012, 6, 7), 'A', 35.89);
            currentEmployees[employeeCount] = papatonisAlex;
            ++employeeCount;

            Employee basharAaliyah = new Employee("Aaliyah", "Bashar", 'F', new DateTime(1965, 7, 25), new DateTime(1995, 4, 2), 'T', 17.95);
            currentEmployees[employeeCount] = basharAaliyah;
            ++employeeCount;

            // Load the list box with employee information
            listBoxEmployees.Items.AddRange(currentEmployees[0..employeeCount]);
            comboBoxJobs.Items.AddRange(jobs);
        }

        // Method containing actions to perform once the "Remove Employee" button is selected
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            // Obtain the items selected
            int selectedIndex = listBoxEmployees.SelectedIndex;
            Employee selectedEmployee = currentEmployees[selectedIndex];

            string messageBoxMsg = $"Would you like to remove the employee with the last name " +
                $"{selectedEmployee.LastName}?";

            var selectedOption = MessageBox.Show(messageBoxMsg, "Approve Removal", MessageBoxButtons.YesNo);

            if (selectedOption == DialogResult.Yes)
            {
                // Call method to remove the employee
                RemoveEmployee(selectedIndex);

                // Clear the current list box
                listBoxEmployees.Items.Clear();

                // Reload the list box with the modified employee array
                listBoxEmployees.Items.AddRange(currentEmployees[0..employeeCount]);
            }
        }

        // Helper method for the "Remove Employee" button
        private void RemoveEmployee(int indexOfEmployee)
        {
            // Set the employee's position in the array to null 
            currentEmployees[indexOfEmployee] = null;

            // Readjust the values in the array
            for (int j = indexOfEmployee; j < employeeCount - 1; ++j)
            {
                currentEmployees[j] = currentEmployees[j + 1];
            }

            // Eliminate the final employee (double) and update the employee count
            currentEmployees[employeeCount] = null;
            --employeeCount;
        }

        // Method to return the employee roster to its original state
        // Calls the Form1_Load() method, which has all the original 
        // employee values and loads them into the list box. 
        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Clear the list box
            listBoxEmployees.Items.Clear();

            // Erase the values of in the global employees array
            for (int i = 0; i < employeeCount; ++i)
            {
                currentEmployees[i] = null;
            }

            // Reset the employeeCount global int
            employeeCount = 0;

            // Call the form's load method to return it to its original state
            Form1_Load(sender, e);
        }

        // Method containing actions to perform once the "Search" button is pressed
        // The user must select a value from the comboBoxJobs.
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Initialize counter
            int matches = 0;
            
            // Convert job to job code
            string job = (string)comboBoxJobs.SelectedItem;
            char jobCode = job.ToUpper()[0];

            // Empty the contents of the list box
            listBoxEmployees.Items.Clear();

            // Instantiate a new array
            Employee[] empSubset = new Employee[employeeCount];

            // Add the items that have the job code to the new array
            for (int i = 0; i < employeeCount; ++i)
            {
                if (currentEmployees[i].JobCode == jobCode)
                {
                    empSubset[matches] = currentEmployees[i];
                    matches++;
                }
            }

            // Update the list box
            listBoxEmployees.Items.AddRange(empSubset[0..matches]);
        }

        // Method to launch an instance of an AddEmployeeForm
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Launch Add Employee Form
            AddEmployeeForm addNewEmployee = new AddEmployeeForm();
            addNewEmployee.Show();
        }

        // Method to display the full list that's currently stored
        // The values of the currentEmployees array are shown in the list box.
        private void BtnFullList_Click(object sender, EventArgs e)
        {
            // Clear the current contents of the list box
            listBoxEmployees.Items.Clear();

            // Add the current employees of the global array to the list box
            listBoxEmployees.Items.AddRange(currentEmployees[0..employeeCount]);
        }
    }
}
