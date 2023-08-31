using Azure;
using FactoryCSharp.DbContexts;
using FactoryCSharp.Enums;
using FactoryCSharp.Models;
using Microsoft.AspNetCore.Http.Features;
using Operation = FactoryCSharp.Models.Operation;

namespace FactoryCSharp.Seed
{
    public class DbSeed
    {
        private readonly AppDbContext _context;

        public DbSeed(AppDbContext context)
        {
            _context = context;
        }

        public void doSeed() 
        {

            _context.Machines.RemoveRange(_context.Machines);
            _context.Items.RemoveRange(_context.Items);
            _context.Orders.RemoveRange(_context.Orders);
            _context.Operations.RemoveRange(_context.Operations);
            _context.CycleOperations.RemoveRange(_context.CycleOperations);
            _context.ProductionCycles.RemoveRange(_context.ProductionCycles);


            List<Machine> machines = new()
                {
                    new Machine()
                    {
                        Description = "impastatrice",
                        Code = "IMP001",
                        MachineState = MachineState.STOP
                    },
                    new Machine()
                    {
                        Description = "forno",
                        Code = "FRN001",
                        MachineState = MachineState.STOP
                    },
                    new Machine()
                    {
                        Description = "linea confezionamento 1",
                        Code = "CNF001",
                        MachineState = MachineState.STOP
                    }
                };

                _context.Machines.AddRange(machines);
                _context.SaveChanges();
            

                List<ProductionCycle> productionCycles = new()
                {
                    new ProductionCycle()
                    {
                        Description = "first",
                        Code = "PROD001",
                    },
                    new ProductionCycle()
                    {
                        Description = "second",
                        Code = "PROD002",
                    },
                    new ProductionCycle()
                    {
                        Description = "third",
                        Code = "PROD003",
                    }
                };

                _context.ProductionCycles.AddRange(productionCycles);
                _context.SaveChanges();





            List<CycleOperation> cycleOperations = new()
                {
                    new CycleOperation()
                    {
                        Description = "first production cycle",
                        OperationCode = 10,
                        Type = DurationType.INVARIANT,
                        WorkingTime = 22,
                        WorkingQuantity = 3,
                        InvariantDuration = 3,
                        Machine = machines.ElementAt(0),
                        ProductionCycle=productionCycles.ElementAt(0),
                    },
                    new CycleOperation()
                    {
                        Description = "second production cycle",
                        OperationCode = 10,
                        Type = DurationType.INVARIANT,
                        WorkingTime = 22,
                        WorkingQuantity = 3,
                        InvariantDuration = 3,
                        Machine = machines.ElementAt(0),
                        ProductionCycle=productionCycles.ElementAt(1),
                    },
                    new CycleOperation()
                    {   
                        Description = "third production cycle",
                        OperationCode = 10,
                        Type = DurationType.INVARIANT,
                        WorkingTime = 22,
                        WorkingQuantity = 3,
                        InvariantDuration = 3,
                        Machine = machines.ElementAt(2),
                        ProductionCycle=productionCycles.ElementAt(2),
                    }
                };

                _context.CycleOperations.AddRange(cycleOperations);
                _context.SaveChanges();


            List<Item> items = new()
                {
                    new Item()
                    {
                        Code = "liquirizia",
                        Quantity = 50,
                        Description = "liquirizia",
                        ProductionCycle = productionCycles.ElementAt(0),
                    },
                    new Item()
                    {
                        Code = "pasta",
                        Quantity = 50,
                        Description = "pasta",
                        ProductionCycle = productionCycles.ElementAt(2),
                    },
                    new Item()
                    {
                        Code = "crackers",
                        Quantity = 50,
                        Description = "crackers",
                        ProductionCycle = productionCycles.ElementAt(2),
                    }
                };

            _context.Items.AddRange(items);
            _context.SaveChanges();


            List<Order> orders = new()
                {
                    new Order()
                    {
                        Code = 1,
                        RequestedQuantity = 10,
                        ProducedQuantity = 3333,
                        ScrappedQuantity = 5,
                        State = OrderState.NEW,
                        DeliveryDate = DateTime.Now.AddDays(3),
                        Item = items.ElementAt(1),
                    },
                    new Order()
                    {
                        Code = 1,
                        RequestedQuantity = 10,
                        ProducedQuantity = 5555,
                        ScrappedQuantity = 5,
                        State = OrderState.NEW,
                        DeliveryDate = DateTime.Now.AddDays(2),
                        Item = items.ElementAt(0),
                    },
                    new Order()
                    {
                        Code = 1,
                        RequestedQuantity = 10,
                        ProducedQuantity = 8888,
                        ScrappedQuantity = 5,
                        State = OrderState.NEW,
                        DeliveryDate = DateTime.Now.AddDays(5),
                        Item = items.ElementAt(0),
                    }
                };

            _context.Orders.AddRange(orders);
            _context.SaveChanges();



            List<Operation> operations = new()
                {
                    new Operation()
                    {
                        Code = 2,
                        Description = "impasto",
                        ProducedQuantity = 100,
                        ScrappedQuantity = 30,
                        State = OperationState.NEW,
                        DurataMin = 40,
                        StartDate = DateTime.Now.AddDays(2),
                        Machine = machines.ElementAt(1),
                        Order = orders.ElementAt(0)
                    },
                    new Operation()
                    {
                        Code = 2,
                        Description = "infornata",
                        ProducedQuantity = 10,
                        ScrappedQuantity = 30,
                        State = OperationState.NEW,
                        DurataMin = 40,
                        StartDate = DateTime.Now.AddDays(2),
                        Machine = machines.ElementAt(2),
                        Order = orders.ElementAt(0)
                    },
                    new Operation()
                    {
                        Code = 2,
                        Description = "confezionamento",
                        ProducedQuantity = 60,
                        ScrappedQuantity = 30,
                        State = OperationState.NEW,
                        DurataMin = 40,
                        StartDate = DateTime.Now.AddDays(2),
                        Machine = machines.ElementAt(1),
                        Order = orders.ElementAt(1)
                    }
            };

            _context.Operations.AddRange(operations);
            _context.SaveChanges();


        }
    }
}
