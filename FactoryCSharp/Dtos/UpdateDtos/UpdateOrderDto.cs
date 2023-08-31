using FactoryCSharp.Enums;
using FactoryCSharp.Models;

namespace FactoryCSharp.Dtos.UpdateDtos
{
    public class UpdateOrderDto
    {

        public int RequestedQuantity { get; set; }
        public int? ProducedQuantity { get; set; }
        public int? ScrappedQuantity { get; set; }
        public OrderState? State { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
