namespace NPLC.Assignment3.Model
{
    internal class HourlyEmployee : Employee
    {
        public double Rate { get; set; }
        public double WorkingHours { get; set; }

        public HourlyEmployee()
        {
        }

        public HourlyEmployee(string ssn, string firstName, string lastName, DateTime birthDate, string phone, string email, double wage, double workingHours) : base(ssn, firstName, lastName, birthDate, phone, email)
        {
            this.Rate = wage;
            this.WorkingHours = workingHours;
        }

        public override string? ToString()
        {
            return $"{base.ToString()}, Wage: {this.Rate}, WorkingHours: {this.WorkingHours}";
        }
    }
}
