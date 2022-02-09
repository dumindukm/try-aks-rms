using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rms.ProductService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rms.ProductService.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ProductViewModel> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new ProductViewModel
            {
                Name = $"Product-{index}",
                Quantity = index ,
                Price = index * 100
            })
            .ToArray();
        }
    }
}
