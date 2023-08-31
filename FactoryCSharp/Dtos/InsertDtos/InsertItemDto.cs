using FactoryCSharp.Models;

namespace FactoryCSharp.Dtos.InsertDtos
{
    public class InsertItemDto
    {
        public string Code { get; set; }
        public int? Quantity { get; set; }
        public string? Description { get; set; }
        public int ProductionCycleId { get; set; }

    }
}
