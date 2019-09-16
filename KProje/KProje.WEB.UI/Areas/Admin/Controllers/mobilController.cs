using KProje.BLL.DataServices;
using KProje.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KProje.WEB.UI.Areas.Admin.Controllers
{
    
    public class mobilController : Controller
    {
        private mobilRepository mobilRepo;
        public mobilController()
        {
            mobilRepo = new mobilRepository();
        }
        // GET: Admin/mobil
        public ActionResult Index()
        {
            var model = mobilRepo.GetList();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(mobil model)
        {
            mobilRepo.Insert(model);
            ViewBag.IsSuccess = mobilRepo.Save() > 0 ? true : false;
            ModelState.Clear();
            return View();
        }

        // GET: Admin/haberler/Delete/5
        public ActionResult Delete(int? id)
        {
            mobilRepo.Delete(id);
            return View();
        }

        // POST: Admin/haberler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            mobilRepo.Delete(id);
            mobilRepo.Save();
            return RedirectToAction("Index");
        }
    }
}