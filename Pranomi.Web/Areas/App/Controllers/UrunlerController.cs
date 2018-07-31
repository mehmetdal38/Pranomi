using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pranomi.Web.Areas.App.Controllers
{
    public class UrunlerController : Controller
    {
        // GET: App/Urunler
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ekle()
        {
            return View();
        }

    }
}