using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web.Mvc;
using Seyahat_sitesi.Models.sınıflar;
using Context = Seyahat_sitesi.Models.sınıflar.Context;

namespace Seyahat_sitesi.Controllers
{
    public class HomeController : Controller
    {

        Context ctx = new Context();
        public ActionResult Anasayfa()
        {
            var degerler = ctx.AnaSayfas.ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = ctx.AnaSayfas.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = ctx.AnaSayfas.Where(x => x.ID == 1).ToList(); // içerisi boş bir partial doldurmadık içerisini
            return PartialView(deger);
        }

    }
}