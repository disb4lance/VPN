

using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.TransferObjects;

namespace Presintation.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _service;
        public AuthenticationController(IServiceManager service) => _service = service;

        /// <summary>
        /// Register User
        /// </summary>
        /// <param name="userForRegistration"></param>
        /// <returns></returns>
        [HttpPost]
        //[ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            var result = await _service.AuthenticationService.RegisterUser(userForRegistration);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }

        /// <summary>
        /// Authenticate User
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Token</returns>
        [HttpPost("login")]
        //[ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto user)
        {
            if (!await _service.AuthenticationService.ValidateUser(user))
                return Unauthorized();
            //var tokenDto = await _service.AuthenticationService.CreateToken(populateExp: true);
            return Ok();
        }
    }
}
