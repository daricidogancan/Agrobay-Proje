using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using Seyahat_sitesi.Models.sınıflar;
using Context = Seyahat_sitesi.Models.sınıflar.Context;

namespace Seyahat_sitesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context ctx = new Context();
        public ActionResult AdminPanel()

        {
            var degerler = ctx.Blogs.ToList();
            return View(degerler);
        }
        [HttpGet]  //sayfa yüklendiği zaman çalışıcak ve sayfayı yükleyip hiç bir işlem yapmıcak parametre göndermeme rağmen sayfa yüklendiği anda verileri kaydetmesinin önüne geçilmesi icin kullanılır
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            ctx.Blogs.Add(p);
            ctx.SaveChanges();
            return RedirectToAction("AdminPanel");
        } 
        public ActionResult BlogSil(int id)
        {
            var bloglar = ctx.Blogs.Find(id);
            ctx.Blogs.Remove(bloglar);
            ctx.SaveChanges();
            return RedirectToAction("AdminPanel");
            
        }

    }
}