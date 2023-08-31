using FactoryCSharp.Enums;

namespace FactoryCSharp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public long Code { get; set; }
        public int RequestedQuantity { get; set; }
        public int? ProducedQuantity { get; set; }
        public int? ScrappedQuantity { get; set; }
        public OrderState State { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Item Item { get; set; }
        public int ItemId { get; set; }
        public ICollection<Operation> Operations { get; set; } = new List<Operation>();

    }
}
