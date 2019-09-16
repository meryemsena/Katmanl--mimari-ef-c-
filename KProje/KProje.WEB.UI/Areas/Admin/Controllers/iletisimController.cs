using KProje.BLL.DataServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KProje.WEB.UI.Areas.Admin.Controllers
{
    public class iletisimController : Controller
    {
        private iletisimRepository iletisimRepo;
        public iletisimController()
        {
            iletisimRepo = new iletisimRepository();
        }
        // GET: Admin/iletisim
        public ActionResult Index()
        {
            var model = iletisimRepo.GetList();
            return View(model);
        }
        

        // GET: Admin/haberler/Delete/5
        public ActionResult Delete(int? id)
        {
            iletisimRepo.Delete(id);
            return View();
        }

        // POST: Admin/haberler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            iletisimRepo.Delete(id);
            iletisimRepo.Save();
            return RedirectToAction("Index");
        }
    }
}