using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductInventory.Application.Dto;
using ProductInventory.Application.Interfaces;
using ProductInventory.Application.Services;

namespace ProductInventory.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubVariantsController(ISubVariantService subVariantService) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(subVariantService.GetSubVariants());
        }

        [HttpPost]
        public IActionResult Create([FromBody] string name)
        {
            return Ok(subVariantService.AddSubVariant(name));
        }

        [HttpPut]
        public IActionResult Update(SubVariantDto subVariant)
        {
            return Ok(subVariantService.UpdateSubVariant(subVariant));
        }

        [HttpDelete]
        public IActionResult Delete([FromRoute] Guid id)
        {
            return Ok(subVariantService.DeleteSubVariant(id));
        }
    }
}
