using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dmart.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dmart.Controllers
{
    public class BuyerController : Controller
    {
        private readonly BuyerContext _bcontext;

        public BuyerController(BuyerContext bcontext)
        {
            _bcontext = bcontext;
        }

        [HttpGet]
        public ActionResult RegisterBuyer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterBuyer(Buyer b)
        {
            try
            {
                _bcontext.Add(b);
                _bcontext.SaveChanges();
                ViewBag.message = b.Name + " has successfully registered";
                return RedirectToAction("");

            }
            catch (Exception e)
            {
                ViewBag.message = b.Name + "Registration failed";
            }
            return View();
        }



        [HttpGet]
        public ActionResult BuyerLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BuyerLogin(Buyer b)
        {
            var loguser = _bcontext.buyerdata.Where(e => e.Name == b.Name && e.Password == b.Password).ToList();
            if (loguser.Count == 0)
            {
                ViewBag.message = "Not a valid user";
                return View();

            }
            else
            {
                ////to store session values
                //HttpContext.Session.SetString("name", uc.name);
                ////Response.Cookies.Append("lastlogin", DateTime.Now.ToString());
                ////HttpContext.Session.SetString("LastLogin", DateTime.Now.ToString());
                return RedirectToAction("BDashBoard");
            }
        }

        public ActionResult BDashBoard()
        {
            return View();
        }
        // GET: Buyer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Buyer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Buyer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Buyer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Buyer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Buyer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Buyer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Buyer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}