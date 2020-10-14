using System;
using System.Linq;
using BloemenwinkelAPI.API.Database;
using BloemenwinkelAPI.API.Models.Domain;
using BloemenwinkelAPI.API.Models.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BloemenwinkelAPI.API.Controllers
{
    [ApiController]
    [Route("Bloemenwinkel")]
    public class BloemenwinkelController : ControllerBase
    {
        private readonly IInMemoryDatabase _database;
        private readonly ILogger<BloemenwinkelController> _logger;

        public BloemenwinkelController(IInMemoryDatabase database, ILogger<BloemenwinkelController> logger)
        {
            _logger = logger;
            //_database = database;
        }

        [HttpGet]
        public IActionResult BouquetSales() {
            return null;
        }

        [HttpGet]
        public IActionResult BouquetSalesStore() {
            return null;
        }

        [HttpGet]
        public IActionResult TurnoverStore() {
            return null;
        }

        [HttpGet]
        public IActionResult ComparisonStoreSales() {
            return null;
        }

        [HttpGet]
        public IActionResult RegisterBouquetSale() {
            return null;
        }

        
    }
}