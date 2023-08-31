using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Models;

namespace FactoryCSharp.Repositories.Interfaces
{
    public interface IProductionCycleRepository
    {
        List<ProductionCycle> getAll();
        void add(InsertProductionCycleDto productionCycle);
        ProductionCycle get(int id);
        void edit(int id, UpdateProductionCycleDto productionCycle);
        void delete(int id);
    }
}
