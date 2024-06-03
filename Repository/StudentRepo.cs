using atelier_injection_dependance.Interfaces;
using atelier_injection_dependance.Models;

namespace atelier_injection_dependance.Repository
{
    public class StudentRepo : IStudentDao
    {
        public List<Student> FindAllBdx()
        {
            var students = new List<Student> {
                new Student("Robert"),
                new Student("Gerard"),
                new Student("Mouloud")
            };

            return students;
        }

        public List<Student> FindAllTls()
        {
            var students = new List<Student> {
                new Student("Bernard"),
                new Student("Hoagie"),
                new Student("Laverne")
            };

            return students;
        }
    }
}
