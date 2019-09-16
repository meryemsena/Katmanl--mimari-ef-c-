using KProje.BLL.DataServices;
using KProje.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KProje.WEB.UI.Controllers
{
    public class HomeController : Controller
    {
        private bilimRepository bilimRepo;
        private haberlerRepository haberlerRepo;
        private mobilRepository mobilRepo;
        private sosyalmedyaRepository sosyalmedyaRepo;
        private iletisimRepository iletisimRepo;
        public HomeController()
        {
            bilimRepo = new bilimRepository();
            haberlerRepo = new haberlerRepository();
            mobilRepo = new mobilRepository();
            sosyalmedyaRepo = new sosyalmedyaRepository();
            iletisimRepo = new iletisimRepository();
        }
        // GET: Home
        public ActionResult Index()
        {
            var model = bilimRepo.GetList();
            return View(model);
        }
        public ActionResult Haberler()
        {
            var model = haberlerRepo.GetList();
            return View(model);
        }
        public ActionResult Mobil()
        {
            var model = mobilRepo.GetList();
            return View(model);
        }
        public ActionResult Sosyalmedya()
        {
            var model = sosyalmedyaRepo.GetList();
            return View(model);
        }
        [HttpGet]
        public ActionResult Iletisim()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Iletisim(iletisim model)
        {
            if (ModelState.IsValid)
            {
                iletisimRepo.Insert(model);
                iletisimRepo.Save();
            }
            ModelState.Clear();
            ViewBag.Mesaj = "Mesajınız iletildi";
            return View();
        }
    }
}