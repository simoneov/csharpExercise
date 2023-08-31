using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Models;
using FactoryCSharp.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FactoryCSharp.Controllers
{
    [ApiController]
    public class MachineController : ControllerBase
    {
        private readonly IMachineRepository _repo;

        public MachineController( IMachineRepository repo )
        {
            _repo = repo;

        }


        [HttpPost("/machines/add")]
        public void Add(InsertMachineDto model)
        {
            _repo.add(model);
        }

        [HttpGet("/machines")]
        public List<Machine> GetAll()
        {
            var machines = _repo.getAll();
            return machines;
        }

        [HttpGet("/machines/{id}")]
        public Machine Get(int id)
        {
            var machine = _repo.get(id);
            return machine;
        }

        [HttpPut("/machines/edit/{id}")]
        public void Edit(int id, UpdateMachineDto dto)
        {
            _repo.edit(id, dto);
        }

        [HttpDelete("/machines/delete/{id}")]
        public void Delete(int id)
        {
            _repo.delete(id);
        }

    }
}
