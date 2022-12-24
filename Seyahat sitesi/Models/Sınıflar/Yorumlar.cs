using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Seyahat_sitesi.Models.sınıflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }   //En önemli yer burası bu yorum hangi bloğa yapıldığını tuttuk.Bir bloğun birden cok yorumu olabilir fakat bir yorum bir blog için geçerli olur.
    }
}