using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DCL_Project_LeninAguiar.Controllers
{
    public class TelecommunicationController : Controller
    {
        // GET: Telecommunication
        public ActionResult Index()
        {
            return View();
        }

        // GET: Telecommunication/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Telecommunication/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Telecommunication/Create
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

        // GET: Telecommunication/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Telecommunication/Edit/5
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

        // GET: Telecommunication/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Telecommunication/Delete/5
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
