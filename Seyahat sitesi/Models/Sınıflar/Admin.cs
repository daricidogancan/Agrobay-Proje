using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Seyahat_sitesi.Models.sınıflar
{
    public class Admin
    {

        [Key]

        public int ID { get; set; }
        public string Kullanıcı { get; set; }
        public string Sifre { get; set; }
       
    }
}