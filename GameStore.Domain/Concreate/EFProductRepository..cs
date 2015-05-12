using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Concreate
{
    public class EFProductRepository : IGameRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<GameProduct> Products
        {
            get { return context.Products; }
        }
    }
}
