using FactoryCSharp.Enums;
using FactoryCSharp.Models;

namespace FactoryCSharp.Dtos.UpdateDtos
{
    public class UpdateOperationDto
    {

        public string? Description { get; set; }
        public OperationState? State { get; set; }
        public int DurataMin { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ProducedQuantity { get; set; }
        public int? ScrappedQuantity { get; set; }

    }
}
