using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Seyahat_sitesi.Models.sınıflar
{
    public class Hakkımızda
    {
        [Key]
        public int ID { get; set; }
        public string Baslık { get; set; }
        public string Acıklama { get; set; }
    }
}