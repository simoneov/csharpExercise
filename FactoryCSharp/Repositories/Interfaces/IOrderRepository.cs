using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Models;

namespace FactoryCSharp.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> getAll();
        void add(InsertOrderDto order);
        Order get(int id);
        void edit(int id, UpdateOrderDto order);
        void delete(int id);
    }
}
