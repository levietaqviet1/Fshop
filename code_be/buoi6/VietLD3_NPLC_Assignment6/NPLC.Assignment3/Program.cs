using NPLC.Assignment3.Manage;

internal class Program
{
    private static void Main(string[] args)
    {
        IDepartmentManage departmentManage = new DepartmentManage();
        do
        {
            switch (Menu.GetOptionMenu())
            {
                case 0:
                    departmentManage.InputAutoData(); // gọi hàm InputAutoData
                    break;
                case 1:
                    departmentManage.InputData(); // gọi hàm InputData
                    break;
                case 2:
                    departmentManage.DisplayEmployees(); // gọi hàm DisplayEmployees
                    break;
                case 3:
                    departmentManage.ClassifyEmployees(); // gọi hàm ClassifyEmployees
                    break;
                case 4:
                    departmentManage.EmployeeSearch(); // gọi hàm EmployeeSearch
                    break;
                case 5:
                    departmentManage.Report(); // gọi hàm Report
                    break;
            }
        } while (true);

    }
}