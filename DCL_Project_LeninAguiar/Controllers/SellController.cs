using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DCL_Project_LeninAguiar.Controllers
{
    public class SellController : Controller
    {
        // GET: Sell
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sell/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sell/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sell/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sell/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sell/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sell/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sell/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
