using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Seyahat_sitesi.Models.sınıflar;

namespace Seyahat_sitesi.Models.Sınıflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; }     //bir view sayfasından 2 farklı tablodan veri çekebilmek için interface tanımladık
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3  { get; set; }  

    }
}