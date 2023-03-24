using Session4.Models;

namespace Session4
{
    public class StudentManagement
    {
        private readonly IStudentRepository repository = new StudentRepository();
        public void DisplayAllStudents()
        {
            var students = repository.GetStudents();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} \t|" +
                    $"{student.Name}\t|" +
                    $"{student.DateOfBirth.Value.ToString("dd MMMM yyyy")}");
            }
        }

        public void CreateStudent()
        {
            Console.Write("Enter student's Name: ");
            string name = Console.ReadLine();
            
            DateTime dob;
            do
            {
                Console.Write("Enter date of birth: ");
            }
            while (!DateTime.TryParse(Console.ReadLine(), out dob));

            decimal height;
            do
            {
                Console.Write("Enter student's height: ");
            } while (!decimal.TryParse(Console.ReadLine(),out height)) ;

            float weight;
            do
            {
                Console.Write("Enter student's weight: ");
            } while (!float.TryParse(Console.ReadLine(), out weight));

            repository.Create(new Student() { Name=name,
                DateOfBirth=dob,
                Height=height,
                Weight=weight}); 
        }
    }
}
