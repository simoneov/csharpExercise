using FactoryCSharp.Enums;

namespace FactoryCSharp.Models
{
    public class CycleOperation
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int OperationCode { get; set; }
        public DurationType Type { get; set; }
        public int? WorkingTime { get; set; }
        public int? WorkingQuantity { get; set; }
        public int? InvariantDuration { get; set; }
        public Machine? Machine { get; set; }
        public int MachineId { get; set; }
        public ProductionCycle? ProductionCycle { get; set; }
        public int ProductionCycleId { get; set; }
    }
}
