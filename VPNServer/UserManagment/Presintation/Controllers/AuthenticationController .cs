

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
        private readonly IRabbitMQProducer _rabbitMQProducer;
        public AuthenticationController(IServiceManager service, IRabbitMQProducer rabbitMQProducer) { 
            _service = service;
            _rabbitMQProducer = rabbitMQProducer;
        } 


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


        [HttpPost("login")]
        //[ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto user)
        {
            var rez = await _service.AuthenticationService.ValidateUser(user);
            _rabbitMQProducer.SendMessage(rez);
            return Ok(new { Message = "User registered successfully", UserId = rez });
        }
    }
}
