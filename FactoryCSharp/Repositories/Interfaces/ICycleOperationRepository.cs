using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Models;

namespace FactoryCSharp.Repositories.Interfaces
{
    public interface ICycleOperationRepository
    {
        List<CycleOperation> getAll();
        void add(InsertCycleOperationDto cycleOperation);
        CycleOperation get(int id);
        void edit(int id, UpdateCycleOperationDto cycleOperation);
        void delete(int id);
    }
}
