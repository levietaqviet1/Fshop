namespace NPLC_Assignment12.Excercise.Excercise3
{
    /// <summary>
    /// Interface for storage operations related to employees
    /// </summary>
    public interface IEmployeeStorage
    {
        /// <summary>
        /// Deletes an employee with the specified id
        /// </summary>
        /// <param name="id">The id of the employee to delete</param>
        void DeleteEmployee(int id);
    }

    /// <summary>
    /// Implementation of IEmployeeStorage that uses an EmployeeContext to access a database
    /// </summary>
    public class EmployeeStorage : IEmployeeStorage
    {
        private EmployeeContext _db;

        public EmployeeStorage()
        {
            _db = new EmployeeContext();
        }

        /// <summary>
        /// Deletes an employee with the specified id from the database
        /// </summary>
        /// <param name="id">The id of the employee to delete</param>
        public void DeleteEmployee(int id)
        {
            var employee = _db.Employees.Find(id);
            if (employee is null) return;
            _db.Employees.Remove(employee);
            _db.SaveChanges();
        }
    }
}
