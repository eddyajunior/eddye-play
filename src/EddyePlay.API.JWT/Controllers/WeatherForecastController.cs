using Microsoft.AspNetCore.Mvc;

namespace EddyePlay.API.JWT.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public string Get()
    {
        return TokenService.GenerateToken("edson.amaral@teste.com", "administrator");
    }
}
