using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Models;
using FactoryCSharp.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FactoryCSharp.Controllers
{
    [ApiController]

    public class ItemController : ControllerBase
    {
        private readonly IItemRepository _repo;

        public ItemController(IItemRepository repo)
        {
            _repo = repo;

        }


        [HttpPost("/items/add")]
        public void Add(InsertItemDto model)
        {
            _repo.add(model);
        }

        [HttpGet("/items")]
        public List<Item> GetAll()
        {
            var items = _repo.getAll();
            return items;
        }

        [HttpGet("/items/{id}")]
        public Item Get(int id)
        {
            var item = _repo.get(id);
            return item;
        }

        [HttpPut("/items/edit/{id}")]
        public void Edit(int id, UpdateItemDto dto)
        {
            _repo.edit(id, dto);
        }

        [HttpDelete("/items/delete/{id}")]
        public void Delete(int id)
        {
            _repo.delete(id);
        }

    }
}
