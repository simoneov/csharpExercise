using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Models;

namespace FactoryCSharp.Repositories.Interfaces
{
    public interface IMachineRepository
    {
        List<Machine> getAll();
        void add(InsertMachineDto machine);
        Machine get(int id);
        void edit (int id, UpdateMachineDto machine);
        void delete (int id);

    }
}
