using Microsoft.AspNetCore.Mvc;
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
        public string Get1()
        {
            return "Hello from Get 1";
        }
    }
}