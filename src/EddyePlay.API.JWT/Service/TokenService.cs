using EddyePlay.API.JWT.Models;
using System.Security.Claims;

namespace EddyePlay.API.JWT.Service
{
    public class TokenService
    {
        public Claim[] GetTokenClaims(ClaimModel model)
        {
            var claims = new Claim[3];
            claims[0] = new Claim("username", model.Username);
            claims[1] = new Claim("role", model.Role);
            claims[2] = new Claim("id", model.Id);

            return claims;
        }
    }
}
