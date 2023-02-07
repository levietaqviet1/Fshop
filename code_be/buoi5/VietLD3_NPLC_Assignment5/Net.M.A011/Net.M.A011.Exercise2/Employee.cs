using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011.Exercise2
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private double monthlySalary;

        public double MonthlySalary
        {
            get { return this.monthlySalary; }
            set { this.monthlySalary = value < 0 ? 0.0 : value; }
        }

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, double monthlySalary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MonthlySalary = monthlySalary < 0 ? 0.0 : monthlySalary;
        }

        public override string? ToString()
        {
            return $"First Name: {this.FirstName}, Last Name: {this.LastName}, Monthly Salary: {this.MonthlySalary}";
        }
    }
}
