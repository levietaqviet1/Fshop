using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPLC.Assignment3
{
    internal class Department
    {
        public string DepartmentName { get; set; }

        public List<Employee> Employees { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }

        public int CountOf<T>(){ 
            return Employees.Count;
        }

        public List<T> GetEmployees<T>()
        {
            List<T > 
            return 
        }
    }
}
