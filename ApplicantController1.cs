﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hiring_Application.Controllers
{
    public class ApplicantController1 : Controller
    {
        // GET: ApplicantController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: ApplicantController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApplicantController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicantController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApplicantController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApplicantController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApplicantController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApplicantController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
