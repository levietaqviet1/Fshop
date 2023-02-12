using NPLC.Assignment3.Utill;

namespace NPLC.Assignment3.Manage
{
    internal class Menu
    {
        /// <summary>
        /// 1. Add Employee  2. Add Department 3. Get Employee Count 4. Get Employee List 5. Exit
        /// </summary>
        /// <returns></returns>
        public static int GetOptionMenuAddAndGet()
        {
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Add Department");
            Console.WriteLine("3. Get Employee Count");
            Console.WriteLine("4. Get Employee List");
            Console.WriteLine("5. Exit");
            int option = Validate.GetIntInputOption("Choose an option: ", 1, 5);

            return option;
        }

        /// <summary>
        /// 1. Salaried Employee 2. Hourly Employee 3. Exit
        /// </summary>
        /// <returns></returns>
        public static int GetOptionMenuAddEmployee()
        {
            Console.WriteLine("Add Employee");
            Console.WriteLine("1. Salaried Employee");
            Console.WriteLine("2. Hourly Employee");
            Console.WriteLine("3. Exit");
            int option = Validate.GetIntInputOption("Choose an option: ", 1, 3);

            return option;
        }

        /// <summary>
        /// 1. Salaried Employee 2. Hourly Employee 3. Exit
        /// </summary>
        /// <returns></returns>
        public static int GetOptionMenuGetCountEmployee()
        {
            Console.WriteLine("Get Employee Count");
            Console.WriteLine("1. Salaried Employee");
            Console.WriteLine("2. Hourly Employee");
            Console.WriteLine("3. Exit");
            int option = Validate.GetIntInputOption("Choose an option: ", 1, 3);

            return option;
        }

        /// <summary>
        /// 1. Salaried Employee   2. Hourly Employee   3. Exit
        /// </summary>
        /// <returns></returns>
        public static int GetOptionMenuGetEmployee()
        {
            Console.WriteLine("Get Employee List");
            Console.WriteLine("1. Salaried Employee");
            Console.WriteLine("2. Hourly Employee");
            Console.WriteLine("3. Exit");
            int option = Validate.GetIntInputOption("Choose an option: ", 1, 3);

            return option;
        }
        /// <summary>
        /// 1. Input data from the keyboard    2. Display employees   3. Classify employees   4. Employee Search   5. Report
        /// </summary>
        /// <returns></returns>
        public static int GetOptionMenu()
        {
            Console.Clear();
            Console.WriteLine("Munu Function");
            Console.WriteLine("0. Input data auto");
            Console.WriteLine("1. Input data from the keyboard");
            Console.WriteLine("2. Display employees");
            Console.WriteLine("3. Classify employees");
            Console.WriteLine("4. Employee Search");
            Console.WriteLine("5. Report");
            int option = Validate.GetIntInputOption("Choose an option: ", 0, 5);

            return option;
        }

        /// <summary>
        /// 1. Search by department name   2. Search by employee name  3. Exit
        /// </summary>
        /// <returns></returns>
        public static int GetOptionMenuSearch()
        {
            Console.WriteLine("1. Search by department name");
            Console.WriteLine("2. Search by employee name");
            Console.WriteLine("3. Exit");
            int option = Validate.GetIntInputOption("Choose an option: ", 1, 3);

            return option;
        }
    }
}
