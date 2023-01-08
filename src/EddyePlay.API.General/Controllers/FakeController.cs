using EddyePlay.Application.Entities;
using EddyePlay.Application.Interfaces.Fake;
using Microsoft.AspNetCore.Mvc;

namespace EddyePlay.API.General.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FakeController : ControllerBase
    {
        private readonly ILogger<FakeController> _logger;

        public FakeController(ILogger<FakeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public PersonEntity Get([FromServices]IFakeService fakeService)
        {
            return fakeService.Generate();
        }
    }
}