using Phu.Model.Models;
using Phu.Service.Interfaces;
using System.Collections.Generic;
using System.Web.Http;

namespace Phu.WebAPI.Controllers
{
    public class StudentController : ApiController
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        public IEnumerable<Student> GetAll()
        {
            var a = _studentService.GetAll();
            return a;
        }
    }
}