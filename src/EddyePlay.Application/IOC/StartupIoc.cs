using EddyePlay.Application.Interfaces.Fake;
using EddyePlay.Application.Services.Fake;
using Microsoft.Extensions.DependencyInjection;

namespace EddyePlay.Application.IOC
{
    public static class StartupIoc
    {
        public static void Inject(IServiceCollection  service)
        {
            service.AddScoped<IFakeService, FakeService>();
        }
    }
}
