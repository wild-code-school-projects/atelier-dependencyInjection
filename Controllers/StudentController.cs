using atelier_injection_dependance.Interfaces;
using atelier_injection_dependance.Models;
using Microsoft.AspNetCore.Mvc;

namespace atelier_injection_dependance.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {

        private IStudentDao _studentDao;

        public StudentController(IStudentDao studentDao)
        {
            _studentDao = studentDao;
        }

        [HttpGet("/students")]
        public List<Student> GetStudents()
        {
            return _studentDao.FindAllTls();
        }

        [HttpGet("/students_bdx")]
        public List<Student> GetStudentsBdx()
        {
            return _studentDao.FindAllBdx();
        }


    }
}
