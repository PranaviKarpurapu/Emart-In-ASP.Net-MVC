using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dmart.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dmart.Controllers
{
    public class SubCategoryController : Controller
    {

        public readonly SubCategoryContext _subcontext;


        public SubCategoryController(SubCategoryContext subcontext)
        {
            this._subcontext = subcontext;
        }


        public ActionResult AddCategories()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategories(SubCategories sc)
        {
            _subcontext.Add(sc);
            _subcontext.SaveChanges();
            ViewBag.message = sc.Scname + " has got successfully Added";
            return RedirectToAction("Index");
        }

        // GET: SubCategory
        public ActionResult Index()
        {
            return View();
        }

        // GET: SubCategory/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SubCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SubCategory/Create
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

        // GET: SubCategory/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubCategory/Edit/5
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

        // GET: SubCategory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubCategory/Delete/5
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