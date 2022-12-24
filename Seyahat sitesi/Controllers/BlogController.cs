using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Seyahat_sitesi.Models.sınıflar;
using Seyahat_sitesi.Models.Sınıflar;

namespace Seyahat_sitesi.Controllers
{
    public class BlogController : Controller
    {
        Context ctx = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Blog()
        {   
            //var bloglar=ctx.Blogs.ToList();    normalde bu şekilde yapıyoduk fakat alttaki satırın amacı 
            by.Deger1 = ctx.Blogs.ToList();     //blog yorum ismindeki sınıfımızdan blogları listeleyebiliyomuyuz ona bakıcaz burada.
                                                //1 tane değeri alıp getiricek.. 
            return View(by);
        }
        
        public ActionResult BlogDetay(int id)
        {

            // var blogdetay = ctx.Blogs.Where(x => x.ID == id).ToList();   //blogtaki bilgileri getiriceğimiz için blogtaki bilgileri çektik.
            by.Deger1 = ctx.Blogs.Where(x => x.ID == id).ToList();

            by.Deger3 = ctx.Blogs.Take(2).ToList();     //son 3 adet yorumun başlığını getiricek
            by.Deger2 = ctx.Yorumlars.Where(x => x.Blogid == id).ToList();   //x.blogid dememizin sebebi o id deki bloğa yapılan yorumları getirmesi gerekiyo..
            return View(by);
        }
    }
    
}