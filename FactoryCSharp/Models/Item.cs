namespace FactoryCSharp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int? Quantity { get; set; }
        public string? Description { get; set; }
        public ProductionCycle ProductionCycle { get; set; }
        public int ProductionCycleId { get; set; }
        public ICollection<Order> Order { get; set; } = new List<Order>();

    }
}
