using EddyePlay.Application.Entities;
using EddyePlay.Application.Fake.Bogus;
using EddyePlay.Application.Interfaces.Fake;

namespace EddyePlay.Application.Services.Fake
{
    public class FakeService : IFakeService
    {
        public PersonEntity Generate()
        {
            return PersonFakeGenerator.Generate();
        }
    }
}
