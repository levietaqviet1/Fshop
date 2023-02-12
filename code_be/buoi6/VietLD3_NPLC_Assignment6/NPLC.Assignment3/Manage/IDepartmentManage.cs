using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPLC.Assignment3.Manage
{
    internal interface IDepartmentManage
    {
        public void InputAutoData();
        public void InputData();
        public void DisplayEmployees();
        public void ClassifyEmployees();
        public void EmployeeSearch();
        public void Report();
    }
}
