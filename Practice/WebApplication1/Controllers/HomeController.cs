using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        List<Student> StdList;
        public HomeController()
        {
            StdList = new List<Student>();
        }
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student std)
        {
            StdList.Add(std);
            return View();
        }


        public ActionResult AdminDashBoard()
        {
            return View();
        }
	}
}