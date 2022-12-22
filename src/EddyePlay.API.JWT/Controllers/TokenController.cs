using Microsoft.AspNetCore.Mvc;

namespace EddyePlay.API.JWT.Controllers;

[ApiController]
[Route("[controller]")]
public class TokenController : ControllerBase
{
    private readonly ILogger<TokenController> _logger;

    public TokenController(ILogger<TokenController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        return TokenService.GenerateToken("edson.amaral@teste.com", "administrator");
    }
}
