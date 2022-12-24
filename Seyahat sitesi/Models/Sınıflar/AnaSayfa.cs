using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Seyahat_sitesi.Models.sınıflar
{
    public class AnaSayfa
    {
        [Key]          //using System.ComponentModel.DataAnnotations; key eklemek icin bu kütüphaneyi dahil ettim..
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Acıklama { get; set; }
        public string FotoURL { get; set; }
    }
}