using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Seyahat_sitesi.Models.sınıflar
{
    public class AdresBlog   //bu oluşturduğumuz sınıfı iletişim sayfasının içinde bi bölüm
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Konum { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }

    }
}
