using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Seyahat_sitesi.Models.sınıflar;          //burada model.sınıfları dahil ettim. 

namespace Seyahat_sitesi.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        Context ctx = new Context();   //verileri çekebilmek için context e ctx adında bir nesne tanımladım
        public ActionResult About()
        {
            var degerler = ctx.Hakkımızda.ToList();   //ctx yardımıyla contexte bağlı olan sınıflar içerisinde hakkımızda tablosuna ulaşıp listele dedik...
            return View(degerler);                   
        }
        public PartialViewResult Partialhakkımızda()
        {
            var acıklama = ctx.Hakkımızda.ToList();
            return PartialView(acıklama);
        }
        public PartialViewResult PartialHakkımızda2()
        {
            var ilkacıklama = ctx.Hakkımızda.ToList();
            return PartialView(ilkacıklama);
        }
    }
}