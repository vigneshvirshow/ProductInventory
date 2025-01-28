using Microsoft.AspNetCore.Mvc;
using ProductInventory.Application.Interfaces;
using ProductInventory.Infrastructure.Dto;

namespace ProductInventory.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VariantsController(IVariantService variantService) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(variantService.GetVariants());
        }

        [HttpPost]
        public IActionResult Create([FromBody] VariantDto variant)
        {
            return Ok(variantService.AddVariant(variant));
        }

        [HttpPut]
        public IActionResult Update(VariantDto variant)
        {
            return Ok(variantService.UpdateVariant(variant));
        }

        [HttpDelete]
        public IActionResult Delete([FromRoute] Guid id)
        {
            return Ok(variantService.DeleteVariant(id));
        }
    }
}
