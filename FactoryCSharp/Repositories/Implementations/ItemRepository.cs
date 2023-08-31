using FactoryCSharp.DbContexts;
using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Exceptions;
using FactoryCSharp.Models;
using FactoryCSharp.Repositories.Interfaces;
using System.Reflection.PortableExecutable;

namespace FactoryCSharp.Repositories.Implementations
{
    public class ItemRepository : IItemRepository
    {

        private readonly AppDbContext _db;

        public ItemRepository(AppDbContext db)
        {
            _db = db;
        }
        public void add(InsertItemDto item)
        {
            if (item != null)
            {
                Item itemToSave = new Item
                {
                    Code = item.Code,
                    Description = item.Description,
                    Quantity = item.Quantity,
                    ProductionCycleId = item.ProductionCycleId
                };
                _db.Items.Add(itemToSave);
                _db.SaveChanges();
            }
        }

        public void delete(int id)
        {
            _db.Items.Remove(_db.Items.SingleOrDefault(m => m.Id == id));
            _db.SaveChanges();
        }

        public void edit(int id, UpdateItemDto item)
        {
            var saved = _db.Items.SingleOrDefault(m => m.Id == id);
            if (saved == null)
            {
                throw new NotFoundException();
            }
            saved.Description = item.Description;
            saved.Quantity = item.Quantity;

            _db.SaveChanges();
        }

        public Item get(int id)
        {
            return _db.Items.SingleOrDefault(v => v.Id == id);
        }

        public List<Item> getAll()
        {
            return _db.Items.ToList();
        }
    }
}
