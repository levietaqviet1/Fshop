using NPLC.Assignment11.Dao;
using NPLC.Assignment11.Utill;

namespace NPLC.Assignment11.Controller
{
    public class Management
    {
        private readonly IRepository repository;
        public Management()
        {
            repository = new Repository();
        }

        /// <summary>
        /// Manage
        /// </summary>
        public void Manage()
        {
            while (true)
            {
                int option = Menu.GetMenuManage();
                switch (option)
                {
                    case 1:
                        GetDepartments();
                        break;
                    case 2:
                        GetEmployeesWorking();
                        break;
                    case 3:
                        GetEmployees();
                        break;
                    case 4:
                        GetLanguages();
                        break;
                    case 5:
                        GetSeniorEmployees();
                        break;
                    case 6:
                        GetEmployeesByName();
                        break;
                    case 7:
                        GetDepartmentsWithEmployees();
                        break;
                    case 8:
                        Console.WriteLine("\n\n\t\t ----------------- EXIT PROGRAM ---------------");

                        return;
                }
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Display all departments that has employees >= numberOfEmployee
        /// </summary>
        private void GetDepartments()
        {
            // Prompt the user to enter the number of employees using a do-while loop until a valid input is received (a positive integer).
            int numberOfEmployee = Validation.GetInt("\n Enter the number of employees: ", 0, int.MaxValue);

            // Display a message indicating that departments with the specified number of employees will be returned.
            Console.WriteLine($"\n  Return departments which have >= {numberOfEmployee} employees: ");

            // Get the departments that have at least the specified number of employees using the repository method GetDepartments()
            var departments = repository.GetDepartments(numberOfEmployee);

            // Check if there are any departments to display
            if (departments.Count == 0)
            {
                Console.WriteLine("\n\t --> There are no departments!");
            }
            else
            {
                // Display the departments
                departments.ToList().ForEach(x => Console.WriteLine(x));
            }
        }

        /// <summary>
        /// Display all employees who are currently working.
        /// </summary>
        private void GetEmployeesWorking()
        {
            // Print a message indicating that employees who are working will be returned
            Console.WriteLine("\n 2. Return all employees who are working: ");

            // Get the employees who are currently working
            var employees = repository.GetEmployeesWorking();

            // Check if there are any employees to display
            if (employees.Count == 0)
            {
                Console.WriteLine("\n\t --> There are no employees currently working!");
            }
            else
            {
                // Display the employees
                employees.ToList().ForEach(x => Console.WriteLine(x));
            }
        }


        /// <summary>
        /// Display all employees who know a specific programming language.
        /// </summary>
        private void GetEmployees()
        {
            // Prints all Languagess names and returns the number of ProgramingLanguagess
            int max = repository.GetProgramingLanguagess();
            int languageId = Validation.GetInt("Input choice: ", 1, max);

            string languageName = repository.GetProgramingLanguagessNameById(languageId);

            // Print a message indicating that employees who know the specified programming language will be returned
            Console.WriteLine($"\nReturn employees who know {languageName}: ");

            // Get the employees who know the specified programming language
            var employees = repository.GetEmployees(languageName);

            // Check if there are any employees to display
            if (employees.Count == 0)
            {
                Console.WriteLine("\n\t --> There are no employees who know the specified programming language!");
            }
            else
            {
                // Display the employees
                employees.ToList().ForEach(x => Console.WriteLine(x));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void GetLanguages()
        {
            // Prompt the user to enter the employee ID
            int employeeId = Validation.GetInt("\n Enter the employee ID: ", 1, int.MaxValue);

            // Print a message indicating that the employee's programming languages will be returned
            Console.WriteLine($"\n  Return programming languages of employee with ID {employeeId}: ");

            // Get the programming languages of the employee with the specified ID
            var languages = repository.GetLanguages(employeeId);

            // Check if the employee knows any programming languages
            if (languages.Count == 0)
            {
                Console.WriteLine("\n\t --> The employee doesn't know any programming languages!");
            }
            else
            {
                // Display the programming languages
                languages.ToList().ForEach(x => Console.WriteLine(x.LanguageName));
            }
        }


        /// <summary>
        /// Display all employees who know multiple programming languages
        /// </summary>
        private void GetSeniorEmployees()
        {
            // Print a message indicating that senior employees will be returned
            Console.WriteLine($"\n Return employees who know multiple programming languages: ");

            // Get the senior employees
            var employees = repository.GetSeniorEmployees();

            // Check if there are any senior employees to display
            if (employees.Count == 0)
            {
                Console.WriteLine("\n\t --> There are no senior employees!");
            }
            else
            {
                // Display the senior employees
                employees.ToList().ForEach(x => Console.WriteLine(x));
            }
        }

        private void GetEmployeesByName()
        {
            int pageIndex = 1;
            bool checkInput;

            string employeeNameInput = Validation.GetString("Input Employee Name: ", @"^.{2,}$", "-->  Input again: Name must be 2 or more characters");
            Console.WriteLine("1. Order ascending\n2. Order descending");
            int choice = Validation.GetInt("Choice: ", 1, 2);
            GetEmployeesPaging(pageIndex: pageIndex, employeeName: employeeNameInput, order: choice == 1 ? "ASC" : "DESC");
        }


        /// <summary>
        /// Returns a paginated list of employees based on the specified parameters
        /// </summary>
        /// <param name="pageIndex">The index of the current page (default is 1)</param>
        /// <param name="pageSize">The size of the page (default is 10)</param>
        /// <param name="employeeName">The name of the employee to search (default is null)</param>
        /// <param name="order">The order in which to return the results (default is "ASC")</param>
        private void GetEmployeesPaging(int pageIndex = 1, int pageSize = 10, string employeeName = null, string order = "ASC")
        {
            // Print a message indicating the parameters used for the search
            Console.WriteLine($"\n  Return a paginated list of employees (Page {pageIndex}, Page Size {pageSize}, Employee Name {employeeName}, Order {order}):");

            // Get the employees that match the specified search criteria
            var employees = repository.GetEmployeesPaging(pageIndex, pageSize, employeeName, order);

            // Check if there are any employees to display
            if (employees.Count == 0)
            {
                Console.WriteLine("\n\t --> There are no employees!");
            }
            else
            {
                // Display the employees
                employees.ToList().ForEach(x => Console.WriteLine(x));
            }
        }

        /// <summary>
        /// Returns all departments including employees that belong to each department.
        /// </summary>
        private void GetDepartmentsWithEmployees()
        {
            // Retrieve all departments including employees
            var departments = repository.GetDepartmentsWithEmployees();

            // Check if there are any departments to display
            if (departments.Count == 0)
            {
                Console.WriteLine("\n\t --> There are no departments!");
            }
            else
            {
                var query = from department in departments
                            select new
                            {
                                department.DepartmentName,
                                Employees = department.Employees.Select(e => e.EmployeeName)
                            };

                foreach (var result in query)
                {
                    Console.WriteLine($"\n\t {result.DepartmentName}:");
                    foreach (var employeeName in result.Employees)
                    {
                        Console.WriteLine($"\t\t - {employeeName}");
                    }
                }

            }
        }



    }

}