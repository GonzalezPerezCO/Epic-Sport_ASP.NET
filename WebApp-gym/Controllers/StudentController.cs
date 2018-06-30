using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_gym.Models;

namespace WebApp_gym.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Student()
        {
            Student student = new Student();
            student.name = "Manuel Sergio";
            student.lastname = "Perez Espitia";
            student.code = 2095112;
            student.career = "Ing Sistemas";
            student.enabled = true;

            String[] list1 = new String[2] { "Lunes", "8" };
            String[] list2 = new String[2] { "Jueves", "4"};
            String[] list3 = new String[2] { "Viernes", "1"};

            String[][] lists = new String[][] { list1, list2, list3 };


            student.calendar = lists;


            return View(student);
        }
    }
}