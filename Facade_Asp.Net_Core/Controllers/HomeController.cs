using FacadeLayer;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Facade_Asp.Net_Core.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly IFacadeService _facadeService;

        public HomeController(IFacadeService facadeService)
        {
            _facadeService = facadeService;
        }

        [HttpGet]
        public IActionResult RegisterThenLogin()
        {
            _facadeService.userRegisterService.Execute();
            _facadeService.userLoginService.Execute();
            return Ok();
        }
    }
}
