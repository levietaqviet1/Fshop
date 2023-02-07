using Net.M.A011.Exercise2;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee= new Employee("F","Shop",-1);  // truyền dữ liệu vào contructor
        Console.WriteLine(employee.ToString()); // in dữ liệu của Employee ra màn hình 

    }
}