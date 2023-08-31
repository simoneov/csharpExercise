using FactoryCSharp.DbContexts;
using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Enums;
using FactoryCSharp.Exceptions;
using FactoryCSharp.Models;
using FactoryCSharp.Repositories.Interfaces;
using System.Reflection.PortableExecutable;

namespace FactoryCSharp.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _db;

        public OrderRepository(AppDbContext db)
        {
            _db = db;
        }
        public void add(InsertOrderDto order)
        {
            if (order != null)
            {
                Order orderToSave = new Order
                {
                    Code = order.Code,
                    RequestedQuantity = order.RequestedQuantity,
                    ProducedQuantity = order.ProducedQuantity,
                    ScrappedQuantity = order.ScrappedQuantity,
                    State = order.State,
                    DeliveryDate = order.DeliveryDate,
                    ItemId = order.ItemId,
                };
                _db.Orders.Add(orderToSave);
                _db.SaveChanges();
            }
        }

        public void delete(int id)
        {
            _db.Orders.Remove(_db.Orders.SingleOrDefault(m => m.Id == id));
            _db.SaveChanges();
        }

        public void edit(int id, UpdateOrderDto order)
        {
            var saved = _db.Orders.SingleOrDefault(m => m.Id == id);
            if (saved == null)
            {
                throw new NotFoundException();
            }
            saved.RequestedQuantity = order.RequestedQuantity;
            saved.ProducedQuantity = order.ProducedQuantity;
            saved.ScrappedQuantity = order.ScrappedQuantity;
            saved.State = (OrderState)(order.State == null ? saved.State : order.State);
            saved.DeliveryDate = order.DeliveryDate;
            saved.EndDate = order.EndDate;

            _db.SaveChanges();
        }

        public Order get(int id)
        {
            return _db.Orders.SingleOrDefault(v => v.Id == id);
        }

        public List<Order> getAll()
        {
            return _db.Orders.ToList();
        }
    }
}
