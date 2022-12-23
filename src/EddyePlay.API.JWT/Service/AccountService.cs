using EddyePlay.Application.Helpers;

namespace EddyePlay.API.JWT.Service
{
    public class AccountService
    {
        public bool Authenticate(string username, string password)
        {
            return username == AppSettingsHelper.Setting("TestUsername") &&
                password == AppSettingsHelper.Setting("TestPassword");
        }
    }
}
