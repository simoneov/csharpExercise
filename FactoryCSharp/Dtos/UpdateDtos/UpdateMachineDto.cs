using FactoryCSharp.Enums;

namespace FactoryCSharp.Dtos.UpdateDtos
{
    public class UpdateMachineDto
    {
        public string? Description { get; set; }
        public MachineState? MachineState { get; set; }
    }
}
