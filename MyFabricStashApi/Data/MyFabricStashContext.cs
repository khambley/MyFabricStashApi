using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFabricStashApi.Models;

namespace MyFabricStashApi.Data
{
    public class MyFabricStashContext : DbContext
    {
        public MyFabricStashContext (DbContextOptions<MyFabricStashContext> options)
            : base(options)
        {
            
        }
        public DbSet<MyFabricStashApi.Models.Fabric> Fabrics { get; set; }
        public DbSet<MyFabricStashApi.Models.MainCategory> MainCategories { get; set; }
        public DbSet<MyFabricStashApi.Models.SubCategory> SubCategories { get; set; }

        
    }
}
