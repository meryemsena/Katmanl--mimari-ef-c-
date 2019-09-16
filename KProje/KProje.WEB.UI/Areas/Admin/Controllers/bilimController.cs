using KProje.BLL.DataServices;
using KProje.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KProje.WEB.UI.Areas.Admin.Controllers
{
    public class bilimController : Controller
    {
        private bilimRepository bilimRepo;
        public bilimController()
        {
            bilimRepo = new bilimRepository();
        }
        // GET: Admin/bilim
        public ActionResult Index()
        {
            var model = bilimRepo.GetList();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(bilim model)
        {
            bilimRepo.Insert(model);
            ViewBag.IsSuccess = bilimRepo.Save() > 0 ? true : false;
            ModelState.Clear();
            return View();
        }

        // GET: Admin/haberler/Delete/5
        public ActionResult Delete(int? id)
        {
            bilimRepo.Delete(id);
            return View();
        }

        // POST: Admin/haberler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bilimRepo.Delete(id);
            bilimRepo.Save();
            return RedirectToAction("Index");
        }
    }
}