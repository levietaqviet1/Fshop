using NPLC.Assignment3.Model;
using NPLC.Assignment3.Utill;

namespace NPLC.Assignment3.Manage
{
    internal class DepartmentManage : IDepartmentManage
    {
        private bool check = true;
        private bool checkCha = true;
        public List<Department> departments;

        public DepartmentManage()
        {
            this.departments = new List<Department>();
        }

        /// <summary>
        /// In  Employees theo nhánh con
        /// </summary>
        public void ClassifyEmployees()
        {
            GetEmployeeList();
        }
        /// <summary>
        /// Hiện thị danh sách
        /// </summary>
        public void DisplayEmployees()
        {
            Console.Clear();
            // duyệt qua từng phần tử Department
            foreach (Department department in departments)
            {
                Console.WriteLine("Department: " + department.DepartmentName);
                // duyệt qua từng phần tử Employee
                foreach (Employee employee in department.Employees)
                {
                    Console.WriteLine(employee.ToString()); // in ra
                }
                Console.WriteLine();
            }
            Validate.EnterToContinue();
        }

        /// <summary>
        ///  menu tìm kiếm Employee
        /// </summary>
        public void EmployeeSearch()
        {
            Console.Clear();
            check = true;
            do
            {
                switch (Menu.GetOptionMenuSearch())
                {
                    case 1:
                        SearchDepartmentName(); // tìm kiếm Department theo name
                        break;
                    case 2:
                        SearchEmployeeName(); // tìm kiếm Employee theo name
                        break;
                    case 3:
                        check = false;
                        break;
                }
            } while (check);
        }

        /// <summary>
        /// Tìm kiếm theo Employee
        /// </summary>
        private void SearchEmployeeName()
        {
            Console.Clear();
            int count = 0; // dùng để hỗ trợ kiểm tra xem có hay ko
            string employeeName = Validate.GetStringInput("Enter employee name: ");
            foreach (var item in departments)
            {
                Employee employee = item.Employees.Find(x => x.FirstName.Equals(employeeName) || x.LastName.Equals(employeeName));
                if (employee != null)
                {
                    Console.WriteLine(employee.ToString());
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Employee not found");
            }
            Validate.EnterToContinue();
        }

        /// <summary>
        /// tìm kiếm phòng ban theo tên
        /// </summary>
        private void SearchDepartmentName()
        {
            Console.Clear();
            string departmentName = Validate.GetStringInput("Enter department name: ");
            // tìm kiếm department theo name
            Department department = departments.Find(d => d.DepartmentName.Equals(departmentName));
            if (department != null)
            {
                Console.WriteLine("Salaried Employees:");
                // hiện thị SalaryEmployee
                foreach (SalaryEmployee employee in department.GetEmployees<SalaryEmployee>())
                {
                    if (employee != null)
                    {
                        Console.WriteLine(employee.ToString());
                    }
                }
                Console.WriteLine("Hourly Employees:");
                // hiện thị HourlyEmployee
                foreach (HourlyEmployee employee in department.GetEmployees<HourlyEmployee>())
                {
                    if (employee != null)
                    {
                        Console.WriteLine(employee.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("Department not found");
            }
            Validate.EnterToContinue();
        }

        /// <summary>
        /// Nhập dữ liệu sẵn
        /// </summary>
        public void InputAutoData()
        {
            // truyền data sẵn
            departments.Add(new Department("PRO", new List<Employee>()
            {
                new SalaryEmployee("s1","cao","nguyen",DateTime.Parse("02/02/2005"),"1234567","abc@gmail.com",5,5,1),
                new SalaryEmployee("s2","cao2","nguyen2",DateTime.Parse("02/02/2003"),"1222222","abc2@gmail.com",2,5,2),
                new HourlyEmployee("s3","cao3","nguyen3",DateTime.Parse("03/03/2005"),"1222233","abc3@gmail.com",6,2)
            }));
            departments.Add(new Department("Lap", new List<Employee>()
            {
                new SalaryEmployee("s4","cao4","nguyen4",DateTime.Parse("04/02/2005"),"1234544","abc4@gmail.com",4,5,4),
                new SalaryEmployee("s5","cao5","nguyen5",DateTime.Parse("05/05/2005"),"1225552","abc5@gmail.com",5,5,5),
                new HourlyEmployee("s6","cao6","nguyen6",DateTime.Parse("06/06/2006"),"6622662","abc6@gmail.com",6,6)
            }));
            Console.Clear();
            Console.WriteLine("Input Auto Success ");
            Validate.EnterToContinue();
        }
        /// <summary>
        /// nhập dữ liệu
        /// </summary>
        public void InputData()
        {
            check = true;
            checkCha = true;
            do
            {
                Console.Clear();
                switch (Menu.GetOptionMenuAddAndGet())
                {
                    case 1:
                        AddEmployee(); // thêm Employee
                        break;
                    case 2:
                        AddDepartment();// thêm Department
                        break;
                    case 3:
                        GetEmployeeCount(); // trả về số lượng Employee
                        break;
                    case 4:
                        GetEmployeeList(); // trả về danh sách Employee
                        break;
                    case 5:
                        checkCha = false; // thoát vòng lặp
                        break;
                }
            } while (checkCha);
        }

        /// <summary>
        /// hiện thị số lượng nhân viên trong 1 phòng ban
        /// </summary>
        public void Report()
        {
            Console.Clear();
            Console.WriteLine("List of departments and the number of employees for each:");
            foreach (Department item in departments)
            {
                // hiện thị số nhân viên trong 1 phòng ban
                Console.WriteLine(item.DepartmentName + ": " + item.Employees.Count());
            }
            Validate.EnterToContinue();
        }

        /// <summary>
        /// trả về danh sách Employee
        /// </summary>
        private void GetEmployeeList()
        {
            check = true;
            do
            {
                Console.Clear();
                switch (Menu.GetOptionMenuGetEmployee())
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("SalaryEmployee:");
                        GetEmployees<SalaryEmployee>(); // in ra SalaryEmployee
                        Validate.EnterToContinue();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("HourlyEmployee:");
                        GetEmployees<HourlyEmployee>(); // in ra HourlyEmployee
                        Validate.EnterToContinue();
                        break;
                    case 3:
                        check = false;
                        break;
                }
            } while (check);
        }

        /// <summary>
        /// trả về số lượng Employee theo Employee con
        /// </summary>
        private void GetEmployeeCount()
        {
            check = true;
            do
            {
                Console.Clear();
                switch (Menu.GetOptionMenuGetCountEmployee())
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Count of Salaried Employees: " + CountOf<SalaryEmployee>());
                        Validate.EnterToContinue();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Count of Hourly Employees: " + CountOf<HourlyEmployee>());
                        Validate.EnterToContinue();
                        break;
                    case 3:
                        check = false;
                        break;
                }
            } while (check);
        }

        /// <summary>
        /// thêm Employee
        /// </summary>
        private void AddEmployee()
        {
            if (departments.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Input Department first");
                Validate.EnterToContinue();
            }
            else
            {
                check = true;
                do
                {
                    Console.Clear();
                    switch (Menu.GetOptionMenuAddEmployee())
                    {
                        case 1:
                            Console.Clear();
                            AddSalariedEmployee();
                            break;
                        case 2:
                            Console.Clear();
                            AddHourlyEmployee();
                            break;
                        case 3:
                            check = false;
                            break;
                    }
                } while (check);
            }
        }

        /// <summary>
        /// In ra nhưng Employee theo Employee con
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private void GetEmployees<T>() where T : Employee
        {
            if (CountOf<T>() > 0)
            {
                foreach (Department item in departments)
                {
                    foreach (T employee in item.GetEmployees<T>())
                    {
                        if (employee != null)
                        {
                            Console.WriteLine(employee.ToString());
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("null");
            }
        }

        /// <summary>
        /// In ra số Employee con 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private int CountOf<T>() where T : Employee
        {
            int count = 0;
            foreach (Department item in departments)
            {
                count += item.CountOf<T>();
            }
            return count;
        }

        /// <summary>
        /// thêm Department
        /// </summary>
        private void AddDepartment()
        {
            Console.Clear();
            Console.WriteLine("Add Department");
            Department department = new Department();
            department.DepartmentName = Validate.GetStringInput("Department Name: ");
            department.Employees = new List<Employee>();
            departments.Add(department);
        }

        /// <summary>
        /// Thêm AddHourlyEmployee
        /// </summary>
        private void AddHourlyEmployee()
        {
            Console.WriteLine("Enter the information of the Hourly Employee:");
            HourlyEmployee employee = InputEmployeeSubClass<HourlyEmployee>();
            employee.Rate = Validate.GetPositiveDoubleInput("Rate: ");
            employee.WorkingHours = Validate.GetPositiveDoubleInput("WorkingHours: ");
            AddEmployeesToDepartments(employee);
        }

        /// <summary>
        /// Thêm SalariedEmployee
        /// </summary>
        private void AddSalariedEmployee()
        {
            Console.WriteLine("Enter the information of the Salaried Employee:");
            SalaryEmployee employee = InputEmployeeSubClass<SalaryEmployee>();
            employee.BasicSalary = Validate.GetPositiveDoubleInput("Basic Salary: ");
            employee.GrossSales = Validate.GetPositiveDoubleInput("Gross Sales: ");
            employee.CommisstionRate = Validate.GetPositiveDoubleInput("Commission Rate: ");
            AddEmployeesToDepartments(employee);
        }

        /// <summary>
        /// Nhập Employee tiện hơn
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T InputEmployeeSubClass<T>() where T : Employee, new()
        {
            T employee = new T(); // Khởi tạo đối tượng
            employee.Ssn = Validate.GetStringInput("Social Security Number (SSN): ");
            employee.FirstName = Validate.GetStringInput("First Name: ");
            employee.LastName = Validate.GetStringInput("Last Name: ");
            string birthDateString = Validate.GetStringInput("Birth Date (dd/MM/yyyy): ");
            do
            {
                try
                {
                    employee.BirthDate = Validate.GetDateTimeInput("Birth Date (dd/MM/yyyy): ");
                    check = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    check = true; // nếu nhập sai thì nhập lại
                }
            } while (check);
            while (String.IsNullOrEmpty(employee.Phone))
            {
                try
                {
                    employee.Phone = Validate.GetStringInput("Phone: ");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (String.IsNullOrEmpty(employee.Email))
            {
                try
                {
                    employee.Email = Validate.GetStringInput("Email: ");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return employee;
        }

        /// <summary>
        /// Thêm Employees vào Departments
        /// </summary>
        /// <param name="employee"></param>
        public void AddEmployeesToDepartments(Employee employee)
        {
            Console.WriteLine("----");
            for (int i = 0; i < departments.Count; i++)
            {
                // hiện thị phòng ban để chọn
                Console.WriteLine($"{i + 1}: Department Name {departments[i].DepartmentName}");
            }
            int choice = Validate.GetIntInputOption("Choice departments: ", 1, departments.Count);
            // thêm nhân viên vào phòng ban
            departments[choice - 1].Employees.Add(employee);
        }

    }
}
