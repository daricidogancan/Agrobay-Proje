using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Seyahat_sitesi.Models.sınıflar
{
    public class Context : DbContext

    {
       
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdresBlog> AdresBlogs { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Hakkımızda> Hakkımızda { get; set; }
        public DbSet<İletişim> İletişim { get; set; }
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public object Hakkımızdas { get; internal set; }
        public object Blog { get; internal set; }
    }
}