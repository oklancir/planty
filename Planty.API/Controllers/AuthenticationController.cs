namespace Planty.API.Controllers
{
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Planty.Business.Models;
    using Planty.Business.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly AuthenticationService _authService;

        public AuthenticationController(AuthenticationService authService)
        {
            _authService = authService;
        }

        [Route("register")]
        [HttpPost]
        [ProducesResponseType(typeof(UserBase), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> RegisterAsync(UserBase model)
        {
            return Ok(await _authService.RegisterAsync(model));
        }
    }
}
