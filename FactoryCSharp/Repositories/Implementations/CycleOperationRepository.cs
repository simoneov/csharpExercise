using FactoryCSharp.DbContexts;
using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Enums;
using FactoryCSharp.Exceptions;
using FactoryCSharp.Models;
using FactoryCSharp.Repositories.Interfaces;

namespace FactoryCSharp.Repositories.Implementations
{
    public class CycleOperationRepository : ICycleOperationRepository
    {
        private readonly AppDbContext _db;

        public CycleOperationRepository(AppDbContext db)
        {
            _db = db;
        }
        public void add(InsertCycleOperationDto cycleOperation)
        {
            if (cycleOperation != null)
            {
                CycleOperation cycleOperationToSave = new CycleOperation
                {
                    Description = cycleOperation.Description,
                    OperationCode = cycleOperation.OperationCode,
                    Type = cycleOperation.Type,
                    WorkingTime = cycleOperation.WorkingTime,
                    WorkingQuantity = cycleOperation.WorkingQuantity,
                    InvariantDuration = cycleOperation.InvariantDuration,
                    MachineId = cycleOperation.MachineId,
                    ProductionCycleId = cycleOperation.ProductionCycleId,
                };
                _db.CycleOperations.Add(cycleOperationToSave);
                _db.SaveChanges();
            }
        }

        public void delete(int id)
        {
            _db.CycleOperations.Remove(_db.CycleOperations.SingleOrDefault(m => m.Id == id));
            _db.SaveChanges();
        }

        public void edit(int id, UpdateCycleOperationDto cycleOperation)
        {
            var saved = _db.CycleOperations.SingleOrDefault(m => m.Id == id);
            if (saved == null)
            {
                throw new NotFoundException();
            }
            saved.Description = cycleOperation.Description;
            saved.Type = (DurationType)(cycleOperation.Type == null ? saved.Type : cycleOperation.Type);
            saved.WorkingTime = cycleOperation.WorkingTime;
            saved.WorkingQuantity = cycleOperation.WorkingQuantity;
            saved.InvariantDuration = cycleOperation.InvariantDuration;

            _db.SaveChanges();
        }

        public CycleOperation get(int id)
        {
            return _db.CycleOperations.SingleOrDefault(v => v.Id == id);
        }

        public List<CycleOperation> getAll()
        {
            return _db.CycleOperations.ToList();
        }
    }
}
