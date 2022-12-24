using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Seyahat_sitesi.Models.sınıflar
{
    public class İletişim
    {
        [Key]
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string Mesaj  { get; set; }
        public int MyProperty { get; set; }
    }
}