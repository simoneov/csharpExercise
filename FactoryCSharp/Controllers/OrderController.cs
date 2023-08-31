using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Models;
using FactoryCSharp.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FactoryCSharp.Controllers
{
    [ApiController]

    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _repo;

        public OrderController(IOrderRepository repo)
        {
            _repo = repo;

        }


        [HttpPost("/orders/add")]
        public void Add(InsertOrderDto model)
        {
            _repo.add(model);
        }

        [HttpGet("/orders")]
        public List<Order> GetAll()
        {
            var orders = _repo.getAll();
            return orders;
        }

        [HttpGet("/orders/{id}")]
        public Order Get(int id)
        {
            var order = _repo.get(id);
            return order;
        }

        [HttpPut("/orders/edit/{id}")]
        public void Edit(int id, UpdateOrderDto dto)
        {
            _repo.edit(id, dto);
        }

        [HttpDelete("/orders/delete/{id}")]
        public void Delete(int id)
        {
            _repo.delete(id);
        }

    }
}
