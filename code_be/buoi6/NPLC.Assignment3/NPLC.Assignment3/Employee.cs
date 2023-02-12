using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPLC.Assignment3
{
    internal abstract class Employee : IInterface
    {
        public string Ssn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Employee() { }

        protected Employee(string ssn, string firstName, string lastName, string birthDate, string phone, string email)
        {
            this.Ssn = ssn;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Phone = phone;
            this.Email = email;
        }

        public double GetPaymentAmount()
        {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return $"Ssn: {this.Ssn}, First Name: {this.FirstName}, Last Name: {this.LastName}, BirthDate: {this.BirthDate}, Phone: {this.Phone}, Email: {this.Email}";
        }
    }
}
