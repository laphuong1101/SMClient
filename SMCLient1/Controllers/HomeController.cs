using SMCLient1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMCLient1.Controllers
{
    public class HomeController : Controller
    {
        private ServiceReference1.ServiceClient obj = new ServiceReference1.ServiceClient();
        public ActionResult Index()
        {
           
            var student = new ServiceReference1.Student()
            {
                StudentId = "D00638",
                Name = "La Phuong",
                BirthDay = DateTime.Now,
                Email = "phuong@gmail.com",
                Desciption = "meo dep trai",
                Gender = "Male"
            };

            obj.Add(student);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";


            return View(obj.GetStudents().ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var student = new ServiceReference1.Student()
            {
                StudentId = "D00636",
                Name = "meomeo",
                BirthDay = DateTime.Now,
                Email = "phuong@gmail.com",
                Desciption = "meo dep trai",
                Gender = "Male"
            };

            obj.Update(student.StudentId, student.Name, student.BirthDay, student.Gender, student.Email, student.Desciption);
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(Student student)
        {
            obj.Update(student.StudentId, student.Name, student.BirthDay, student.Gender, student.Email, student.Desciption);
            return Redirect("About");
        }


    }
}