using Microsoft.AspNetCore.Mvc;
using ProductInventory.Api.Dtos;
using ProductInventory.Api

namespace ProductInventory.Api.Controllers 
{
    [Route("/api/products")]    
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public Task<ActionResult<List<ProductReadDTO>>> FindAll()
        {
            
        }

        [HttpGet("{id}")]
        public Task<ActionResult<ProductDetailsReadDTO>> FindById(string id)
        {
            
        }
    }
}
