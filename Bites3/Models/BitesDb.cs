using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Bites3.Models
{
    
   
         public class BitesDb : DbContext
        {
            //public BitesDb() : base("name=DefaultConnection")
            //{

            //}

            public DbSet<Game> Games { get; set; }
            public DbSet<Review> Reviews { get; set; }

        public System.Data.Entity.DbSet<Bites3.Models.Discussion> Discussions { get; set; }
    }
   
}