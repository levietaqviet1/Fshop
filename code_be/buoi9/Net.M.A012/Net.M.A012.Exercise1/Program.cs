using Net.M.A012.Exercise1;

internal class Program
{
    private static void Main(string[] args)
    {
        // Initialization using optional arguments
        var student1 = new Student("Viet", "HE", "Male");
        Console.WriteLine(student1.ToString());
        student1.Graduate();
        Console.WriteLine(student1.ToString());

        // Initialization using named arguments
        var student2 = new Student(name: "Le", gender: "Male", age: 22, mark: 93.2m,
                                   @class: "Engineering", relationship: "Single",
                                   entryDate: new DateTime(2021, 9, 1), address: "123 Ha Noi.",
                                   grade: "A");

        Console.WriteLine(student2.ToString());
        student2.Graduate(3.3);
        Console.WriteLine(student2.ToString());
    }
}