using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using Session4;
using Session4.Data;

var manage = new StudentManagement();

do
{
    Console.WriteLine("1. Display All Students");
    Console.WriteLine("2. Create Student");
    Console.WriteLine("3. Raw Sql query.");

    int choice;
    do
    {
        Console.Write("Enter your choice: ");
    } while (!int.TryParse(Console.ReadLine(), out choice));

    switch (choice)
    {
        case 1:
            try
            {
                manage.DisplayAllStudents();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            break;
        case 2:
            try
            {
                manage.CreateStudent();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            break;

        case 3:
            var db = new SchoolContext();

            var students = db.Students.FromSqlRaw(
                "SELECT * FROM Students",Format.Native).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} \t|" +
                    $"{student.Name}\t|" +
                    $"{student.DateOfBirth.Value.ToString("dd MMMM yyyy")}");
            }
            break;
        default:
            Console.WriteLine("Wrong choice!");
            break;
    }
} while (true);