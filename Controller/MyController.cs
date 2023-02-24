using Microsoft.AspNetCore.Mvc;

namespace DemoDeploy.Controller
{
    public class MyController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
