using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelStudent;
namespace MVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Student()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Student(ModelStudent.Student obj)
        {

            return View();
        }
    }
}