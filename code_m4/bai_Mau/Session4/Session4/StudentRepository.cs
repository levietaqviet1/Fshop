using Session4.Data;
using Session4.Models;

namespace Session4
{
    public class StudentRepository : IStudentRepository
    {
        SchoolContext db =new SchoolContext();

        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }
        public void Create(Student student)
        {
           // student.createdDate
            //db.Entry(student).Property("CreatedDate").CurrentValue= DateTime.Now;
            //db.Entry(student).Property("UpdatedDate").CurrentValue = DateTime.Now;

            db.Students.Add(student);
            db.SaveChanges();
        }

        public void Update(Student student)
        {
            //db.Entry(student).Property("CreatedDate").CurrentValue = DateTime.Now;
            //db.Entry(student).Property("UpdatedDate").CurrentValue = DateTime.Now;

            db.Students.Update(student);
            db.SaveChanges();
        }
    }
}
