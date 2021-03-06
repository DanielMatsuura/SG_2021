using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prueba2.Models
{
   
        public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
        {
            public ApplicationDbContext()
                : base("DefaultConnection", throwIfV1Schema: false)
            {
            }
       
            public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }

            public DbSet<Product> Productos { get; set; }
        }   
}