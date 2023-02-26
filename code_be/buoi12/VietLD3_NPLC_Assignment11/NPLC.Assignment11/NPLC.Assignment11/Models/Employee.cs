namespace NPLC.Assignment11.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime HiredDate { get; set; }
        public int Status { get; set; } // 1|true: Working, 0|false: Off
        public int DepartmentId { get; set; }


        public virtual Department? Department { get; set; } = null;

        public virtual ICollection<ProgramingLanguage>? ProgramingLanguages { get; set; }

        public Employee()
        {
            ProgramingLanguages = new HashSet<ProgramingLanguage>();
        }

        public string GetLanguage()
        {
            string language = string.Join(", ", ProgramingLanguages.Select(item => item.LanguageName));
            return language;
        }

        public override string? ToString()
        {
            return $"EmployeeId: {EmployeeId}, EmployeeName: {EmployeeName}, Age: {Age}, Address:{Address}, HiredDate: {HiredDate}, Status: {Status}, DepartmentId: {DepartmentId}, Language: {GetLanguage()}";
        }
    }
}
