using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Models;

namespace FactoryCSharp.Repositories.Interfaces
{
    public interface IItemRepository
    {
        List<Item> getAll();
        void add(InsertItemDto item);
        Item get(int id);
        void edit(int id, UpdateItemDto item);
        void delete(int id);
    }
}
