using EddyePlay.API.JWT.Interfaces;
using EddyePlay.API.JWT.Requests;
using System.Security.Claims;

namespace EddyePlay.API.JWT.Service
{
    public class SecurityService : ISecurityService
    {
        public string GetToken(TokenRequest request)
        {
            var claims = GetJwtClaims(request);
            var token = Application.Services.Security.TokenService.GenerateJwtToken(claims);

            return token;
        }

        public Claim[] GetJwtClaims(TokenRequest request)
        {
            var claims = new Claim[3];
            claims[0] = new Claim("id", new Random().Next(1, 100).ToString());
            claims[1] = new Claim("username", request.Username);
            claims[2] = new Claim("role", "test");

            return claims;
        }
    }
}
