using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyCloset2.Models
{
    public class MyCloset2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MyCloset2Context() : base("name=MyCloset2Context")
        {
        }

        public System.Data.Entity.DbSet<MyClosetApp.Models.Tops> Tops { get; set; }

        public System.Data.Entity.DbSet<MyClosetApp.Models.Bottoms> Bottoms { get; set; }

        public System.Data.Entity.DbSet<MyClosetApp.Models.Shoes> Shoes { get; set; }

        public System.Data.Entity.DbSet<MyClosetApp.Models.Accessories> Accessories { get; set; }
    }
}
