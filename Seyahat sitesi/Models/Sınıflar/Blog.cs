using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Seyahat_sitesi.Models.sınıflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string BlogResim { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }   //yorumlar ile ilişkili olduğu için ınterface kullandık 
    }
}