namespace NPLC.Assignment11.Models
{
    public class DataContext
    {
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<ProgramingLanguage> ProgramingLanguages { get; set; }

        public DataContext()
        {
            this.ProgramingLanguages = new List<ProgramingLanguage>()
            {
                new ProgramingLanguage
                {
                    LanguageId= 1,
                    LanguageName = "C#"
                },
                new ProgramingLanguage
                {
                    LanguageId= 2,
                    LanguageName = "Java"
                },
                new ProgramingLanguage
                {
                    LanguageId= 3,
                    LanguageName = "PHP"
                }
            };

            this.Employees = new List<Employee>()
            {
                new Employee
                {
                    EmployeeId = 1,
                    EmployeeName = "David",
                    Address = "USA",
                    Age = 23,
                    HiredDate = DateTime.Now,
                    Status=1,
                    DepartmentId = 1,

                    ProgramingLanguages = new List<ProgramingLanguage>()
                    {
                        this.ProgramingLanguages.ElementAt(0),
                        this.ProgramingLanguages.ElementAt(1)
                    }
                },
                   new Employee
                {
                    EmployeeId = 2,
                    EmployeeName = "Kenvi",
                    Address = "USA",
                    Age = 25,
                    HiredDate = DateTime.Now,
                    Status=1,
                    DepartmentId = 2,

                    ProgramingLanguages = new List<ProgramingLanguage>()
                    {
                        this.ProgramingLanguages.ElementAt(1),
                        this.ProgramingLanguages.ElementAt(2)
                    }
                },
                    new Employee
                {
                    EmployeeId = 3,
                    EmployeeName = "kinder",
                    Address = "USA",
                    Age = 25,
                    HiredDate = DateTime.Now,
                    Status=1,
                    DepartmentId = 2,

                    ProgramingLanguages = new List<ProgramingLanguage>()
                    {
                        this.ProgramingLanguages.ElementAt(1),
                    }
                },
                    new Employee
                    {
                    EmployeeId = 4,
                    EmployeeName = "queen",
                    Address = "USA",
                    Age = 25,
                    HiredDate = DateTime.Now,
                    Status=1,
                    DepartmentId = 2,

                    ProgramingLanguages = new List<ProgramingLanguage>()
                    {
                        this.ProgramingLanguages.ElementAt(1),
                    }
                },

            };

            this.Departments = new List<Department>()
            {
                new Department
                {
                    DepartmentId = 1,
                    DepartmentName = "IT"
                },
                new Department
                {
                    DepartmentId = 2,
                    DepartmentName = "Tester"
                },
                new Department
                {
                    DepartmentId = 3,
                    DepartmentName = "Intern"
                }
            };


        }
    }
}
