using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Models;

namespace FactoryCSharp.Repositories.Interfaces
{
    public interface IOperationRepository
    {
        List<Operation> getAll();
        void add(InsertOperationDto operation);
        Operation get(int id);
        void edit(int id, UpdateOperationDto operation);
        void delete(int id);
    }
}
