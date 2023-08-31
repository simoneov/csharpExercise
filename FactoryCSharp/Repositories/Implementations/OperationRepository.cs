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
    public class OperationRepository : IOperationRepository
    {

        private readonly AppDbContext _db;

        public OperationRepository(AppDbContext db)
        {
            _db = db;
        }
        public void add(InsertOperationDto operation)
        {
            if (operation != null)
            {
                Operation operationToSave = new Operation
                {
                    Code = operation.Code,
                    Description = operation.Description,
                    State = operation.State,
                    DurataMin = operation.DurataMin,
                    StartDate = operation.StartDate,
                    MachineId = operation.MachineId,
                    OrderId = operation.OrderId,
                };
                _db.Operations.Add(operationToSave);
                _db.SaveChanges();
            }
        }

        public void delete(int id)
        {
            _db.Operations.Remove(_db.Operations.SingleOrDefault(m => m.Id == id));
            _db.SaveChanges();
        }

        public void edit(int id, UpdateOperationDto operation)
        {
            var saved = _db.Operations.SingleOrDefault(m => m.Id == id);
            if (saved == null)
            {
                throw new NotFoundException();
            }
            saved.Description = operation.Description;
            saved.State = (OperationState)(operation.State == null ? saved.State : operation.State);
            saved.DurataMin = operation.DurataMin;
            saved.EndDate = operation.EndDate;
            saved.ProducedQuantity = operation.ProducedQuantity;
            saved.ScrappedQuantity = operation.ScrappedQuantity;

            _db.SaveChanges();
        }

        public Operation get(int id)
        {
            return _db.Operations.SingleOrDefault(v => v.Id == id);
        }

        public List<Operation> getAll()
        {
            return _db.Operations.ToList();
        }
    }
}
