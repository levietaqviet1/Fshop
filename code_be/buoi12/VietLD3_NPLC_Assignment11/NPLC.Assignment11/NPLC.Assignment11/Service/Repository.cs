using NPLC.Assignment11.Models;

namespace NPLC.Assignment11.Dao
{
    public class Repository : IRepository
    {
        private DataContext context;

        public Repository()
        {
            context = new DataContext();
        }

        /// <summary>
        /// Returns departments which have >= numberOfEmployee employees
        /// </summary>
        /// <param name="numberOfEmployees"></param>
        /// <returns></returns>
        public ICollection<Department> GetDepartments(int numberOfEmployees)
        {
            // Join the Departments and Employees tables based on the DepartmentId field
            var departments = context.Departments.Join(context.Employees, d => d.DepartmentId, e => e.DepartmentId, (d, e) => d)

            // Group the departments by themselves, and select only those with a count of employees greater than or equal to the given numberOfEmployees
            .GroupBy(d => d)
            .Where(g => g.Count() >= numberOfEmployees)
            .Select(d => d.Key);

            // Convert the departments to a list and return it
            return departments.ToList();
        }

        /// <summary>
        /// Prints all Languagess names and returns the number of ProgramingLanguagess
        /// </summary>
        /// <returns></returns>
        public int GetProgramingLanguagess()
        {
            List<ProgramingLanguage> programingLanguagesList = context.ProgramingLanguages.ToList();
            int count = programingLanguagesList.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {programingLanguagesList[i].LanguageName}");
            }

            return count;
        }

        /// <summary>
        /// Prints ProgramingLanguagessName By LanguagessId 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetProgramingLanguagessNameById(int id)
        {

            return context.ProgramingLanguages.FirstOrDefault(x => x.LanguageId == id).LanguageName.ToString();
        }

        /// <summary>
        /// Return Employees Working
        /// </summary>
        /// <returns></returns>
        public ICollection<Employee> GetEmployeesWorking()
        {
            // Get all employees whose Status property is set to 1 (working)
            var employees = context.Employees.Where(e => e.Status == 1).ToList();

            return employees.ToList();
        }

        /// <summary>
        /// Returns a list of all employees who know a specified programming language.
        /// </summary>
        /// <param name="languageName">The name of the programming language.</param>
        /// <returns></returns>
        public ICollection<Employee> GetEmployees(string languageName)
        {
            var employees = (
                from e in context.Employees
                join d in context.Departments on e.DepartmentId equals d.DepartmentId
                where e.ProgramingLanguages.Any(x => x.LanguageName.Equals(languageName))
                select new Employee()
                {
                    EmployeeId = e.EmployeeId,
                    EmployeeName = e.EmployeeName,
                    Age = e.Age,
                    Address = e.Address,
                    HiredDate = e.HiredDate,
                    Status = e.Status,
                    DepartmentId = e.DepartmentId,
                    Department = d,
                    ProgramingLanguages = e.ProgramingLanguages.ToList(),
                }
                ).OrderBy(x => x.EmployeeId);

            return employees.ToList();
        }

        /// <summary>
        ///  Return list ProgramingLanguage
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public ICollection<ProgramingLanguage> GetLanguages(int employeeId)
        {

            var languages = context.Employees
                        .Where(e => e.EmployeeId == employeeId)
                        .SelectMany(e => e.ProgramingLanguages)
                        .ToList();

            return languages;
        }

        /// <summary>
        /// Returns employees who know multiple programming languages
        /// </summary>
        /// <returns></returns>
        public ICollection<Employee> GetSeniorEmployees()
        {
            var seniorEmployees = context.Employees
                .Where(e => e.ProgramingLanguages.Count > 1)
                .ToList();

            return seniorEmployees;
        }

        /// <summary>
        /// Returns a paginated list of employees based on the specified parameters
        /// </summary>
        /// <param name="pageIndex">The index of the current page (default is 1)</param>
        /// <param name="pageSize">The size of the page (default is 10)</param>
        /// <param name="employeeName">The name of the employee to search (default is null)</param>
        /// <param name="order">The order in which to return the results (default is "ASC")</param>
        /// <returns>A paginated list of employees that match the specified search criteria</returns>
        public ICollection<Employee> GetEmployeesPaging(int pageIndex = 1, int pageSize = 10, string employeeName = null, string order = "ASC")
        {
            // Set the starting index of the employees to retrieve
            int startIndex = (pageIndex - 1) * pageSize;

            // Get a list of employees that match the specified search criteria
            var employees = context.Employees
                .Where(e => employeeName == null || e.EmployeeName.Contains(employeeName))
                .OrderBy(e => order == "ASC" ? e.EmployeeName : "")
                .ThenByDescending(e => order == "DESC" ? e.EmployeeName : "")
                .Skip(startIndex)
                .Take(pageSize)
                .ToList();

            // Return the list of employees
            return employees;
        }

        /// <summary>
        /// Returns  all departments with their associated employees from the repository
        /// </summary>
        /// <returns></returns>
        public ICollection<Department> GetDepartmentsWithEmployees()
        {
            var departments = (
                                from d in context.Departments
                                join e in context.Employees on d.DepartmentId equals e.DepartmentId
                                group e by d into g
                                select new Department()
                                {
                                    DepartmentId = g.Key.DepartmentId,
                                    DepartmentName = g.Key.DepartmentName,
                                    Employees = g.ToList()
                                }).ToList();

            return departments;
        }


    }
}