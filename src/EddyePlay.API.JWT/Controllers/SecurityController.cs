using EddyePlay.API.JWT.Interfaces;
using EddyePlay.API.JWT.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EddyePlay.API.JWT.Controllers;

[ApiController]
[Route("[controller]")]
public class SecurityController : ControllerBase
{
    private readonly ILogger<SecurityController> _logger;

    public SecurityController(
        ILogger<SecurityController> logger)
    {
        _logger = logger;
    }

    [HttpPost("token")]
    public string Get(
        [FromBody]TokenRequest request,
        [FromServices]ISecurityService service
        )
    {
        return service.GetToken(request);
    }
}
