using Microsoft.Extensions.Configuration;

namespace EddyePlay.Application.Helpers
{
    public static class AppSettingsHelper
    {
        private static IConfiguration _configuration;

        public static void AppSettingsConfigure(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static string Setting(string key)
            => _configuration.GetSection(key).Value;
    }
}
