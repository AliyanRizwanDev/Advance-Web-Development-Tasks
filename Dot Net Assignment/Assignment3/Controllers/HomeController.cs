using Assignment3.DB;
using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        AppDbContext ctx;
        public HomeController()
        {
            ctx = new AppDbContext();
        }
        public ActionResult Index()
        {
            var model = ctx.Products.ToList();
            return View(model);
        }
        private bool IsUserLoggedIn()
        {
            return Session["Username"] != null && Session["Password"] != null;
        }

        public ActionResult Login()
        {
            if (IsUserLoggedIn())
            {
                return RedirectToAction("Index");
            }

            return View();
        }
        [HttpPost]
        public ActionResult CheckAnswer(string Username, string Password)
        {
            var correctname = "aliyan";
            var correctpass = "12";
            if (Username == correctname && Password == correctpass)
            {
                Session["Username"] = "Aliyan";
                Session["Password"] = "12";
                return RedirectToAction("Index");

            }
            else
            {
                return View();
            }
        }
        //
        // GET: /Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create
        public ActionResult Create()
        {
            return View();
        }


        //
        // POST: /Home/Create
        [HttpPost]
        public ActionResult Create(Products cnt)
        {
            try
            {
                ctx.Products.Add(cnt);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Products cnt)
        {
            try
            {
                // TODO: Add update logic here
                ctx.Entry(cnt).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Home/Delete/5
        public ActionResult Delete(int id)
        {
            var keyid = ctx.Products.Find(id);
            return View(keyid);
        }

        //
        // POST: /Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Products cnt)
        {
            var keyid = ctx.Products.Find(id);

            try
            {
                // TODO: Add delete logic here
                ctx.Products.Remove(keyid);
                ctx.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        private List<Products> GetCart()
        {
            if (Session["Cart"] == null)
            {
                Session["Cart"] = new List<Products>();
            }

            return (List<Products>)Session["Cart"];
        }

        private void SetCart(List<Products> cart)
        {
            Session["Cart"] = cart;
        }
        public ActionResult AddToCart(int id)
        {
            if (!IsUserLoggedIn())
            {
                return RedirectToAction("Login");
            }

            var product = ctx.Products.Find(id);

            if (product != null)
            {
                var cart = GetCart();
                cart.Add(product);
                SetCart(cart);
            }

            return RedirectToAction("Index");
        }

        // GET: Home/RemoveFromCart/5
        public ActionResult RemoveFromCart(int id)
        {
            if (!IsUserLoggedIn())
            {
                return RedirectToAction("Login");
            }

            var cart = GetCart();
            var product = cart.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                cart.Remove(product);
                SetCart(cart);
            }

            return RedirectToAction("Cart");
        }

        // GET: Home/Cart
        public ActionResult Cart()
        {
            if (!IsUserLoggedIn())
            {
                return RedirectToAction("Login");
            }

            var cart = GetCart();
            return View(cart);
        }
    }
}
