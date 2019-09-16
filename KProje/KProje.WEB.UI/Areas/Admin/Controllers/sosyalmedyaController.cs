using KProje.BLL.DataServices;
using KProje.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KProje.WEB.UI.Areas.Admin.Controllers
{
    public class sosyalmedyaController : Controller
    {
        private sosyalmedyaRepository sosyalmedyaRepo;
        public sosyalmedyaController()
        {
            sosyalmedyaRepo = new sosyalmedyaRepository();
        }
        // GET: Admin/sosyalmedya
        public ActionResult Index()
        {
            var model = sosyalmedyaRepo.GetList();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(sosyalmedya model)
        {
            sosyalmedyaRepo.Insert(model);
            ViewBag.IsSuccess = sosyalmedyaRepo.Save() > 0 ? true : false;
            ModelState.Clear();
            return View();
        }

        // GET: Admin/haberler/Delete/5
        public ActionResult Delete(int? id)
        {
            sosyalmedyaRepo.Delete(id);
            return View();
        }

        // POST: Admin/haberler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sosyalmedyaRepo.Delete(id);
            sosyalmedyaRepo.Save();
            return RedirectToAction("Index");
        }
    }
}