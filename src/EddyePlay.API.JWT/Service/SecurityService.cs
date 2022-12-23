using EddyePlay.API.JWT.Interfaces;
using EddyePlay.API.JWT.Requests;
using System.Security.Claims;

namespace EddyePlay.API.JWT.Service
{
    public class SecurityService : ISecurityService
    {
        // ToDo: Implementar validação de usuário e senha antes de retornar o token
        public string GetToken(TokenRequest request)
        {
            var claims = GetJwtClaims(request);
            var token = Application.Services.Security.TokenService.GenerateJwtToken(claims);

            return token;
        }

        public Claim[] GetJwtClaims(TokenRequest request)
        {
            var claims = new Claim[2];
            claims[0] = new Claim("id", "0");
            claims[1] = new Claim("username", request.Username);
            claims[2] = new Claim("role", "test");

            return claims;
        }
    }
}
