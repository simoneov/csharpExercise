using FactoryCSharp.Enums;

namespace FactoryCSharp.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string? Description { get; set; }
        public int? ProducedQuantity { get; set; }
        public int? ScrappedQuantity { get; set; }
        public OperationState State { get; set; }
        public int DurataMin { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Machine Machine { get; set; }
        public int MachineId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }



    }
}
