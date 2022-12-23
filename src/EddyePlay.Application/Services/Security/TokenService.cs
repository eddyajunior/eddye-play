using EddyePlay.Application.Helpers;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EddyePlay.Application.Services.Security
{
    public static class TokenService
    {
        public static string GenerateJwtToken(Claim[] claims)
        {
            var jwtSecurityKey = AppSettingsHelper.Setting("JwtSecurityKey");
            var jwtExpirationDate = DateTime.UtcNow.AddHours(Convert.ToDouble(AppSettingsHelper.Setting("JwtExpirationHours")));

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(jwtSecurityKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = jwtExpirationDate,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
