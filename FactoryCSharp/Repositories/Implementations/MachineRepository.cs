using FactoryCSharp.DbContexts;
using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Exceptions;
using FactoryCSharp.Models;
using FactoryCSharp.Repositories.Interfaces;

namespace FactoryCSharp.Repositories.Implementations
{
    public class MachineRepository : IMachineRepository
    {

        private readonly AppDbContext _db;

        public MachineRepository(AppDbContext db)
        {
            _db = db;
        }

        public void add(InsertMachineDto machine)
        {
            if (machine != null) 
            {
                Machine machineToSave = new Machine
                {
                    Code = machine.Code,
                    Description = machine.Description,
                    MachineState = machine.MachineState
                };
                _db.Machines.Add(machineToSave);
                _db.SaveChanges();
            }

        }

        public void delete(int id)
        {
            _db.Machines.Remove(_db.Machines.SingleOrDefault(m => m.Id == id));
            _db.SaveChanges();
        }

        public void edit(int id, UpdateMachineDto machine)
        {
            var saved = _db.Machines.SingleOrDefault(m => m.Id == id);
            if (saved == null)
            {
                throw new NotFoundException();
            }
            saved.Description = machine.Description;
            saved.MachineState = machine.MachineState;

            _db.SaveChanges();
        }

        public Machine get(int id)
        {
            return _db.Machines.SingleOrDefault(v => v.Id == id);
        }

        public List<Machine> getAll()
        {
            return _db.Machines.ToList();
        }


    }
}
