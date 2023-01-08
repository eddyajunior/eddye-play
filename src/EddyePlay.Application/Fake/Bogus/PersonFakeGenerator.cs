using Bogus;
using EddyePlay.Application.Entities;

namespace EddyePlay.Application.Fake.Bogus
{
    public static class PersonFakeGenerator
    {
        public static PersonEntity Generate()
        {
            var person = new Faker<PersonEntity>()
                .StrictMode(true)
                .RuleFor(o => o.Id, f => f.Random.Number(1, 1000000))
                .RuleFor(o => o.FirstName, f => f.Person.FirstName)
                .RuleFor(o => o.LastName, f => f.Person.LastName)
                .RuleFor(o => o.Email, (f, o) => f.Internet.Email(o.FirstName, o.LastName).ToLower())
                .RuleFor(o => o.Phone, f => f.Person.Phone)
                .Generate();

            return person;
        }
    }
}
