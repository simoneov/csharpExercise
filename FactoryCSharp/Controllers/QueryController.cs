using FactoryCSharp.DbContexts;
using FactoryCSharp.Dtos.InsertDtos;
using FactoryCSharp.Dtos.UpdateDtos;
using FactoryCSharp.Models;
using FactoryCSharp.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FactoryCSharp.Controllers
{
    public class QueryController : ControllerBase
    {

        private readonly AppDbContext _db;



        public QueryController(AppDbContext db)
        {
            _db = db;

        }




        [HttpGet("/itemfirstop")]
        public Item Get()
        {
            var item = _db.Operations.Select(i => i.Order.Item).ToList().ElementAt(0);
            return item;
        }

        
        [HttpGet("/productioncycleswithoutitem")]
        public List<ProductionCycle> Prod()
        {
            var prod = _db.ProductionCycles.Where(i=>i.Items.Count == 0).ToList();
            return prod;
        }



        [HttpGet("/sumrequestedquantities")]
        public int Sum()
        {
            var prod = _db.Items.Select(i=> i.Order.Sum(i=>i.RequestedQuantity)).FirstOrDefault();
            return prod;
        }


    }
}
