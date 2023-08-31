using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Models;
using FactoryCSharp.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FactoryCSharp.Controllers
{
    [ApiController]
    public class OperationController : ControllerBase
    {
        private readonly IOperationRepository _repo;

        public OperationController(IOperationRepository repo)
        {
            _repo = repo;

        }


        [HttpPost("/operations/add")]
        public void Add(InsertOperationDto model)
        {
            _repo.add(model);
        }

        [HttpGet("/operations")]
        public List<Operation> GetAll()
        {
            var operations = _repo.getAll();
            return operations;
        }

        [HttpGet("/operations/{id}")]
        public Operation Get(int id)
        {
            var operation = _repo.get(id);
            return operation;
        }

        [HttpPut("/operations/edit/{id}")]
        public void Edit(int id, UpdateOperationDto dto)
        {
            _repo.edit(id, dto);
        }

        [HttpDelete("/operations/delete/{id}")]
        public void Delete(int id)
        {
            _repo.delete(id);
        }

    }
}
