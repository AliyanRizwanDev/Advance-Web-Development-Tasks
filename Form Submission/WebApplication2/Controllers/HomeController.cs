using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        List<Student> mystds;
        public HomeController()
        {
            mystds = new List<Student>();
            mystds.Add(new Student { Id = 1, Name = "asad" });
            mystds.Add(new Student { Id = 2, Name = "Kamal" });
            mystds.Add(new Student { Id = 3, Name = "Ali" });
        }
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View(mystds);
        }
        [HttpPost]
        public ActionResult Index(Student std)
        {
            mystds.Add(std);
            return View(mystds);
        }
	}
}