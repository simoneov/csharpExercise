using FactoryCSharp.Enums;
using FactoryCSharp.Models;

namespace FactoryCSharp.Dtos.InsertDtos
{
    public class InsertCycleOperationDto
    {
        public string? Description { get; set; }
        public int OperationCode { get; set; }
        public DurationType Type { get; set; }
        public int? WorkingTime { get; set; }
        public int? WorkingQuantity { get; set; }
        public int? InvariantDuration { get; set; }
        public int MachineId { get; set; }
        public int ProductionCycleId { get; set; }
    }
}
