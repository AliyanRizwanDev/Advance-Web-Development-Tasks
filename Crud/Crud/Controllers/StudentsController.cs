using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Crud.Models;
using Crud.DB;

namespace Crud.Controllers
{
    public class StudentsController : Controller
    {
        AppDbContext dbcontext;
        public StudentsController()
        {
            dbcontext = new AppDbContext();
        }

        // GET: /Students/
        public ActionResult Index()
        {
            var model = dbcontext.Students.ToList();
            return View(model);
        }

        // GET: /Students/Details/5
        public ActionResult Details(int id)
        {
            var model = dbcontext.Students.Find(id);
            return View(model);
        }

        // GET: /Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Students/Create
        [HttpPost]
        public ActionResult Create(Student std)
        {
            try
            {
                dbcontext.Students.Add(std);
                dbcontext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: /Students/Edit/5
        public ActionResult Edit(int id)
        {
            var model = dbcontext.Students.Find(id);
            return View(model);
        }

        // POST: /Students/Edit/5
        [HttpPost]
        public ActionResult Edit(Student std)
        {
            try
            {
                dbcontext.Entry(std).State = System.Data.Entity.EntityState.Modified;
                dbcontext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: /Students/Delete/5
        public ActionResult Delete(int id)
        {
            var model = dbcontext.Students.Find(id);
            return View(model);
        }

        // POST: /Students/Delete/5
        [HttpPost]
        public ActionResult Delete(Student std)
        {
            try
            {
                dbcontext.Students.Remove(std);
                dbcontext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}