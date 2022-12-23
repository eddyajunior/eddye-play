using System.IdentityModel.Tokens.Jwt;

namespace EddyePlay.Application.Helpers
{
    public static class JwtTokenHelper
    {
        public static string GetTokenValue(string token, string typeName)
        {
            var tokenResult = new JwtSecurityToken(jwtEncodedString: token);

            return tokenResult.Claims.First(c => c.Type == typeName).Value;
        }
    }
}
