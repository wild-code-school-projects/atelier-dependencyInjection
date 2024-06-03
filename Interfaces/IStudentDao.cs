using atelier_injection_dependance.Models;

namespace atelier_injection_dependance.Interfaces
{
    public interface IStudentDao
    {
        public List<Student> FindAllTls(); // TLS = Toulouse
        public List<Student> FindAllBdx(); // BDX = Bordeaux
    }
}
