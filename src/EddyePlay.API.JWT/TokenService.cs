using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EddyePlay.Application.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace EddyePlay.API.JWT
{
    public static class TokenService
    {
        public static string GenerateToken(string username, string role)
        {
            var jwtSecurityKey = AppSettingsHelper.Setting("JwtSecurityKey");

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(jwtSecurityKey);
            var expirationDate = DateTime.UtcNow.AddHours(2);

            var x = new Claim[3];
            x[0] = new Claim("username", "eu");
            x[1] = new Claim(ClaimTypes.Role, "admin");
            x[2] = new Claim("id", "121");

            var tokenDescriptor = new SecurityTokenDescriptor{
                Subject = new ClaimsIdentity(
                //    new Claim[]
                //{
                //    //new Claim(ClaimTypes.Name, username)
                //    //,new Claim(ClaimTypes.Role, role)
                //    //,new Claim("Id", "1") // Claims adicionais
                //}
                    x
                ),
                Expires = expirationDate,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}