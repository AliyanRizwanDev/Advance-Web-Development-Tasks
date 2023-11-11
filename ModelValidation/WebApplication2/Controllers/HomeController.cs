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

        public ActionResult Edit(int id)
        {
            var model = mystds.FirstOrDefault(x => x.Id == id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if(ModelState.IsValid)
            {
                var model = mystds.FirstOrDefault(x => x.Id == student.Id);
                model.Id = student.Id;
                model.Name = student.Name;
                return RedirectToAction("Index");
            }
            else
            {
                return View(student);

            }
          
        }

        public ActionResult Sample()
        {
            return View();

        }
        [ChildActionOnly]
        public ActionResult _Demo2()
        {
            return View();

        }

	}
}