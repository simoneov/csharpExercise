using FactoryCSharp.Enums;

namespace FactoryCSharp.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public String Code { get; set; }
        public String? Description { get; set; }
        public MachineState? MachineState { get; set; }
        public ICollection<CycleOperation> CycleOperations { get; set; } = new List<CycleOperation>();
        public ICollection<Operation> Operations { get; set; } = new List<Operation>();


    }
}
