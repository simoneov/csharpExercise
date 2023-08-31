using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Models;
using FactoryCSharp.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FactoryCSharp.Controllers
{
    [ApiController]
    public class ProductionCycleController : ControllerBase
    {
        private readonly IProductionCycleRepository _repo;

        public ProductionCycleController(IProductionCycleRepository repo)
        {
            _repo = repo;

        }


        [HttpPost("/productioncycles/add")]
        public void Add(InsertProductionCycleDto model)
        {
            _repo.add(model);
        }

        [HttpGet("/productioncycles")]
        public List<ProductionCycle> GetAll()
        {
            var productionCycles = _repo.getAll();
            return productionCycles;
        }

        [HttpGet("/productioncycles/{id}")]
        public ProductionCycle Get(int id)
        {
            var productionCycle = _repo.get(id);
            return productionCycle;
        }

        [HttpPut("/productioncycles/edit/{id}")]
        public void Edit(int id, UpdateProductionCycleDto dto)
        {
            _repo.edit(id, dto);
        }

        [HttpDelete("/productioncycles/delete/{id}")]
        public void Delete(int id)
        {
            _repo.delete(id);
        }

    }
}
