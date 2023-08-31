using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Models;
using FactoryCSharp.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FactoryCSharp.Controllers
{
    [ApiController]
    public class CycleOperationController : ControllerBase
    {
        private readonly ICycleOperationRepository _repo;

        public CycleOperationController(ICycleOperationRepository repo)
        {
            _repo = repo;

        }


        [HttpPost("/cycleoperations/add")]
        public void Add(InsertCycleOperationDto model)
        {
            _repo.add(model);
        }

        [HttpGet("/cycleoperations")]
        public List<CycleOperation> GetAll()
        {
            var cycleOperations = _repo.getAll();
            return cycleOperations;
        }

        [HttpGet("/cycleoperations/{id}")]
        public CycleOperation Get(int id)
        {
            var cycleOperation = _repo.get(id);
            return cycleOperation;
        }

        [HttpPut("/cycleoperations/edit/{id}")]
        public void Edit(int id, UpdateCycleOperationDto dto)
        {
            _repo.edit(id, dto);
        }

        [HttpDelete("/cycleoperations/delete/{id}")]
        public void Delete(int id)
        {
            _repo.delete(id);
        }

    }
}
