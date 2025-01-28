using Microsoft.AspNetCore.Mvc;
using ProductInventory.Application.Interfaces;
using ProductInventory.Infrastructure.Dto;

namespace ProductInventory.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController(IProductService productService) : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(productService.GetProducts());
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProductDto product)
        {
            return Ok(productService.AddProduct(product));
        }
        
        [HttpPut]
        public IActionResult Update(ProductDto product)
        {
            return Ok(productService.UpdateProduct(product));
        }
        
        [HttpDelete]
        public IActionResult Delete([FromRoute] Guid id)
        {
            return Ok(productService.DeleteProduct(id));
        }
    }
}
