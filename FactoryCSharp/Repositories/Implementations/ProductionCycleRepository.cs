using FactoryCSharp.DbContexts;
using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Exceptions;
using FactoryCSharp.Models;
using FactoryCSharp.Repositories.Interfaces;
using System.Reflection.PortableExecutable;

namespace FactoryCSharp.Repositories.Implementations
{
    public class ProductionCycleRepository : IProductionCycleRepository
    {

        private readonly AppDbContext _db;

        public ProductionCycleRepository(AppDbContext db)
        {
            _db = db;
        }
        public void add(InsertProductionCycleDto productionCycle)
        {
            if (productionCycle != null)
            {
                ProductionCycle productionCycleToSave = new ProductionCycle
                {
                    Code = productionCycle.Code,
                    Description = productionCycle.Description
                };
                _db.ProductionCycles.Add(productionCycleToSave);
                _db.SaveChanges();
            }
        }

        public void delete(int id)
        {
            _db.ProductionCycles.Remove(_db.ProductionCycles.SingleOrDefault(m => m.Id == id));
            _db.SaveChanges();
        }

        public void edit(int id, UpdateProductionCycleDto productionCycle)
        {
            var saved = _db.ProductionCycles.SingleOrDefault(m => m.Id == id);
            if (saved == null)
            {
                throw new NotFoundException();
            }
            saved.Description = productionCycle.Description;

            _db.SaveChanges();
        }

        public ProductionCycle get(int id)
        {
            return _db.ProductionCycles.SingleOrDefault(v => v.Id == id);
        }

        public List<ProductionCycle> getAll()
        {
            return _db.ProductionCycles.ToList();
        }
    }
}
