using FactoryCSharp.Enums;
using FactoryCSharp.Models;

namespace FactoryCSharp.Dtos.InsertDtos
{
    public class InsertOperationDto
    {
        public int Code { get; set; }
        public string? Description { get; set; }
        public OperationState State { get; set; }
        public int DurataMin { get; set; }
        public DateTime StartDate { get; set; }
        public int MachineId { get; set; }
        public int OrderId { get; set; }
    }
}
