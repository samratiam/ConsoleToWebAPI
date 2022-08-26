using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection.Extensions;
namespace ConsoleToWebAPI.Controllers
{
    [ApiController]
    [Route("test/{action}")]
    public class TestController:ControllerBase
    {
        public string Get()
        {
            return "Hello from Get";
        }

        [HttpGet]
        public IActionResult Get1()
        {
            return Ok("Hello from Get 1");
        }

        [HttpGet]
        public IActionResult getProduct([FromServices] IProductRepository _productRepository)
        {
            var name = _productRepository.GetAllProducts();
            return Ok(name);
        }         
    }
}