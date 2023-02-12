namespace NPLC.Assignment3.Model
{
    internal class SalaryEmployee : Employee
    {
        public double CommisstionRate { get; set; }
        public double GrossSales { get; set; }
        public double BasicSalary { get; set; }

        public SalaryEmployee()
        {
        }

        public SalaryEmployee(string ssn, string firstName, string lastName, DateTime birthDate, string phone, string email, double commissionRate, double grossSale, double basicSalary) : base(ssn, firstName, lastName, birthDate, phone, email)
        {
            CommisstionRate = commissionRate;
            GrossSales = grossSale;
            BasicSalary = basicSalary;
        }

        public override string? ToString()
        {
            return $"{base.ToString()}, CommissionRate: {CommisstionRate}, GrossSale: {GrossSales}, BasicSalary: {BasicSalary}";
        }
    }
}
