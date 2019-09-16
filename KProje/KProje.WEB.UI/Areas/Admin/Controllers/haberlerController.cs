using KProje.BLL.DataServices;
using KProje.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace KProje.WEB.UI.Areas.Admin.Controllers
{
    public class haberlerController : Controller
    {
        private haberlerRepository haberlerRepo;
        public haberlerController()
        {
            haberlerRepo = new haberlerRepository();
        }
        // GET: Admin/haberler
        public ActionResult Index()
        {
            var model = haberlerRepo.GetList();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(haberler model)
        {
            haberlerRepo.Insert(model);
            ViewBag.IsSuccess = haberlerRepo.Save() > 0 ? true : false;
            ModelState.Clear();
            return View();
        }

        // GET: Admin/haberler/Delete/5
        public ActionResult Delete(int? id)
        {
            haberlerRepo.Delete(id);
            return View();
        }

        // POST: Admin/haberler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            haberlerRepo.Delete(id);
            haberlerRepo.Save();
            return RedirectToAction("Index");
        }
        
    }
}