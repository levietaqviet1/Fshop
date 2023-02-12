namespace NPLC.Assignment3.Model
{
    internal class Department
    {
        public string DepartmentName { get; set; }

        public List<Employee> Employees { get; set; }
        public Department()
        {
        }

        public Department(string departmentName, List<Employee> employees)
        {
            this.DepartmentName = departmentName;
            this.Employees = employees;
        }

        /// <summary>
        /// Trả về thông tin 
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            string result = $"Department Name: {DepartmentName}\n Employees: ";
            foreach (Employee employee in Employees)
            {
                result += employee.ToString() + "\n";
            }

            return result + "------------------";
        }

        /// <summary>
        /// Trả về số lượng T trong List Employee khi T là SalariedEmployee hoặc HourlyEmployee.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns> 
        public int CountOf<T>() where T : Employee
        {
            int count = 0;
            foreach (var e in Employees)
            {
                if (e is T)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Lấy ra danh sách T trong List Employee khi T là SalariedEmployee hoặc HourlyEmployee.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns> 
        public IEnumerable<Employee> GetEmployees<T>() where T : Employee
        {
            List<Employee> employees = new List<Employee>();
            foreach (var e in Employees)
            {
                employees.Add(e as T);
            }

            return employees;
        }
    }
}
