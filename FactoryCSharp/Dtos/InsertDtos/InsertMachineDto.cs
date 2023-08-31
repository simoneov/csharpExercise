using FactoryCSharp.Enums;

namespace FactoryCSharp.Dtos.InsertDtos
{
    public class InsertMachineDto
    {
        public string Code { get; set; }
        public string? Description { get; set; }
        public MachineState? MachineState { get; set; }
    }
}
