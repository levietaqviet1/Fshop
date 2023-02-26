using NPLC.Assignment11.Models;

namespace NPLC.Assignment11.Dao
{
    public interface IRepository
    {
        /// <summary>
        /// Returns departments which have >= numberOfEmployee employees
        /// </summary>
        /// <param name="numberOfEmployees"></param>
        /// <returns></returns>
        public ICollection<Department> GetDepartments(int numberOfEmployees);

        /// <summary>
        /// Prints all Languagess names and returns the number of ProgramingLanguagess
        /// </summary>
        /// <returns></returns>
        public int GetProgramingLanguagess();

        /// <summary>
        ///  Prints ProgramingLanguagessName By LanguagessId 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetProgramingLanguagessNameById(int id);

        /// <summary>
        /// Return Employees Working
        /// </summary>
        /// <returns></returns>
        public ICollection<Employee> GetEmployeesWorking();

        /// <summary>
        /// Returns a list of all employees who know a specified programming language.
        /// </summary>
        /// <param name="languageName"></param>
        /// <returns></returns>
        public ICollection<Employee> GetEmployees(string languageName);

        /// <summary>
        ///  Return list ProgramingLanguage
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public ICollection<ProgramingLanguage> GetLanguages(int employeeId);

        /// <summary>
        /// Returns employees who know multiple programming languages
        /// </summary>
        /// <returns></returns>
        public ICollection<Employee> GetSeniorEmployees();

        /// <summary>
        /// Returns a paginated list of employees based on the specified parameters
        /// </summary>
        /// <param name="pageIndex">The index of the current page (default is 1)</param>
        /// <param name="pageSize">The size of the page (default is 10)</param>
        /// <param name="employeeName">The name of the employee to search (default is null)</param>
        /// <param name="order">The order in which to return the results (default is "ASC")</param>
        /// <returns>A paginated list of employees that match the specified search criteria</returns>
        public ICollection<Employee> GetEmployeesPaging(int pageIndex = 1, int pageSize = 10, string employeeName = null, string order = "ASC");

        /// <summary>
        /// Returns  all departments with their associated employees from the repository
        /// </summary>
        /// <returns></returns>
        public ICollection<Department> GetDepartmentsWithEmployees();
    }
}