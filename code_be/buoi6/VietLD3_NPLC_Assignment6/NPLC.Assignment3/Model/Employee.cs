using System.Text.RegularExpressions;

namespace NPLC.Assignment3.Model
{
    internal abstract class Employee : IInterface
    {
        private string ssn;
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string phone;
        private string email;

        public Employee() { }

        protected Employee(string ssn, string firstName, string lastName, DateTime birthDate, string phone, string email)
        {
            Ssn = ssn;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
        }

        public string Ssn { get => ssn; set => ssn = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime BirthDate
        {
            get => this.birthDate;
            set
            {
                if (value >= DateTime.Now)
                {
                    throw new Exception("Invalid birthdate");
                }
                this.birthDate = value;
            }
        }
        public string Phone
        {
            get => this.phone;
            set
            {
                if (!Regex.IsMatch(value, @"^\d{7,}$"))
                {
                    throw new Exception("Invalid phone number");
                }
                this.phone = value;
            }
        }
        public string Email
        {
            get => this.email;
            set
            {
                if (!Regex.IsMatch(value, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
                {
                    throw new Exception("Invalid email address");
                }
                this.email = value;
            }
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
