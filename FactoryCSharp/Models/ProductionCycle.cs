namespace FactoryCSharp.Models
{
    public class ProductionCycle
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string? Description { get; set; }
        public ICollection<CycleOperation> CycleOperations { get; set; } = new List<CycleOperation>();
        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
