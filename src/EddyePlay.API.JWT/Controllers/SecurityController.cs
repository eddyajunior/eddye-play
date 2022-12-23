using EddyePlay.Application.Services.Security;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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

    [HttpGet("token")]
    public string Get()
    {
        var claims = new Claim[3];
        claims[0] = new Claim("username", "edson.amaral@teste.com");
        claims[1] = new Claim("role", "administrator");
        claims[2] = new Claim("id", "1");

        return Application.Services.Security.TokenService.GenerateJwtToken(claims);
    }
}
