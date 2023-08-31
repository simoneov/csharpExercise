using FactoryCSharp.Enums;
using FactoryCSharp.Models;

namespace FactoryCSharp.Dtos.UpdateDtos
{
    public class UpdateCycleOperationDto
    {
        public string? Description { get; set; }
        public DurationType? Type { get; set; }
        public int? WorkingTime { get; set; }
        public int? WorkingQuantity { get; set; }
        public int? InvariantDuration { get; set; }

    }
}
