using Session4.Models;

namespace Session4
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
        void Create(Student student);
        void Update(Student student);
    }
}
