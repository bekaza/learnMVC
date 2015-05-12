using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Concreate
{
    public class EFDbContext : DbContext
    {
        public DbSet<GameProduct> Products { get; set; }
    }
}
