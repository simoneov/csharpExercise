using FactoryCSharp.Enums;
using FactoryCSharp.Models;

namespace FactoryCSharp.Dtos.InsertDtos
{
    public class InsertOrderDto
    {
        public long Code { get; set; }
        public int RequestedQuantity { get; set; }
        public int? ProducedQuantity { get; set; }
        public int? ScrappedQuantity { get; set; }
        public OrderState State { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int ItemId { get; set; }
    }
}
