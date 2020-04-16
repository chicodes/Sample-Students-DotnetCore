using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COOLAPI.Models;

namespace COOLAPI.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private StudentContext _studentContext;

        public StudentController(StudentContext context)
        {
            _studentContext = context;
        }

        ~StudentController()
        {
            _studentContext.Dispose();
        }


        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return _studentContext.Students.ToList();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}