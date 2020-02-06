using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dmart.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dmart.Controllers
{
    public class SellerController : Controller
    {
        public readonly SellerContext _scontext;
        


        public SellerController(SellerContext scontext)
        {
            this._scontext = scontext;
        }



        [HttpGet]
        public ActionResult RegisterSeller()

        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterSeller(Seller s)
        {
            try
            {
                _scontext.Add(s);
                _scontext.SaveChanges();
                ViewBag.message = s.Name + " has got successfully Registered";
                return RedirectToAction("Login");
            }
            catch (Exception e)
            {
                ViewBag.message = s.Name + " Registration Failed!!!";
                return View();
            }

        }




        [HttpGet]
        public ActionResult SellerLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SellerLogin(Seller s)
        {
            var logUser = _scontext.sellerdata.Where(e => e.Name == s.Name && e.Password == s.Password).ToList();
            if (logUser.Count == 0)
            {
                ViewBag.message = "Not a valid User";
                return View();
            }
            else
            {
                //To store Sessoin Values
                //HttpContext.Session.SetString("Name", s.Name);
                //HttpContext.Session.SetString("LastLogin", DateTime.Now.ToString());
                return RedirectToAction("SDashBoard");
                
            }
        }
        public ActionResult LogOut()
        {
            Response.Cookies.Append("LastLogin", DateTime.Now.ToString());
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }


        public ActionResult SDashBoard()
        {
            return View();
        }
       

    
      


        // GET: Seller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Seller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Seller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seller/Create
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

        // GET: Seller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seller/Edit/5
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

        // GET: Seller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seller/Delete/5
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