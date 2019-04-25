using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Employee
    {
        private int employeeNumber { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string dateOfHire { get; set; }
        private string jobDescription { get; set; }
        private string department { get; set; }
        private double monthlySalary;
        private string jobTitle;

        public Employee(string FirstName,string Lastname)
        {
            firstName = FirstName;
            lastName = Lastname;
        }
        public Employee(int EmployeeNumber,string FirstName,string LastName,string DateOfHire,string JobDescription, string Department, double Salary)
        {
            employeeNumber = EmployeeNumber;
            firstName = FirstName;
            lastName = LastName;
            dateOfHire = DateOfHire;
            jobDescription = JobDescription;
            department = Department;
            MonthlySalary = Salary;  
        }

        public Employee(string FirstName,string L)

        public double MonthlySalary
        {
            get
            {
                return monthlySalary;
            }

            set
            {
                if (value >= 100)
                {
                    monthlySalary = value;
                }
                else
                {
                    throw new ArgumentException("value is too low for monthly salary");
                }
            }
        }

        public string ReturnFullName()
        {
            return firstName + " " + lastName;
            
        }
        public string ReturnFullNameForSorting()
        {
            return lastName + "," + " " + firstName;
        }
        
    }
}
