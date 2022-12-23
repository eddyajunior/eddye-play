using EddyePlay.API.JWT.Requests;
using System.Security.Claims;

namespace EddyePlay.API.JWT.Interfaces
{
    public interface ISecurityService
    {
        string GetToken(TokenRequest request);
        Claim[] GetJwtClaims(TokenRequest request);
    }
}
