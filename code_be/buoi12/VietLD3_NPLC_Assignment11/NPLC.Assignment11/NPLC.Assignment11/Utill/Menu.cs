namespace NPLC.Assignment11.Utill
{
    public class Menu
    {
        /// <summary>
        /// 1. Return departments which have >= numberOfEmployee employees. 
        /// 2. Return employees has been working.
        /// 3. Return list all employees know languageName.
        /// 4. Return programing languages which employee has employeeId
        /// 5. Returns employees who know multiple programming languages.
        /// 6. Returns List of Employees with pageIndex, pageSize employeeName, order=”ASC” or “DESC” 
        /// 7. Return all departments including employees that belong to each department.
        /// 8. Exit
        /// </summary>
        public static int GetMenuManage()
        {
            Console.Clear();
            Console.WriteLine("\t\t Menu:");
            Console.WriteLine("\t\t 1. Return departments which have >= numberOfEmployee employees.");
            Console.WriteLine("\t\t 2. Return employees has been working.");
            Console.WriteLine("\t\t 3. Return list all employees know languageName.");
            Console.WriteLine("\t\t 4. Return programing languages which employee has employeeId");
            Console.WriteLine("\t\t 5. Returns employees who know multiple programming languages.");
            Console.WriteLine("\t\t 6. Returns List of Employees with pageIndex, pageSize employeeName, order=”ASC” or “DESC” ");
            Console.WriteLine("\t\t 7. Return all departments including employees that belong to each department.");
            Console.WriteLine("\t\t 8. Exit.\n");
            return Validation.GetInt("\n Enter option in (1,2,3,4,5,6,7,8) to execute these functions: ", 1, 8);
        }
    }
}
