using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CDRSportsStore.Models.Respository
{
    public class EFDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
