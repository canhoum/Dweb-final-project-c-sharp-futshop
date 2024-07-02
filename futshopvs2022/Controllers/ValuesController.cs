using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace futshopvs2022.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult Ola()
        {
            return Ok("Olá");
        }

        [HttpGet]
        [Route("adeus")]
        public ActionResult Adeus()
        {
            return Ok("Adeus");
        }
    }
}
