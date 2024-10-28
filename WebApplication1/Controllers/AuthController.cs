using Microsoft.AspNetCore.Mvc;
using WebApplication1.Helper;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetToken()
        {
            string token = JwtHelper.GenerateJsonWebToken();
            return Ok(token);
        }
    }
}
