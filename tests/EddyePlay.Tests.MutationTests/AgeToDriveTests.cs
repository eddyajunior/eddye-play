using EddyePlay.Application.Services.Quality;
using Xunit;
using FluentAssertions;

namespace EddyePlay.Tests.MutationTests
{
    public class AgeToDriveTests
    {
        [Fact]
        public void ShouldReturnTrueWhenAgeIsAllowed()
        {
            var result = new MutationTestsService().AllowedAgeToDrive(21);
            result.Should().BeTrue();
        }

        [Fact]
        public void ShouldReturnFalseWhenAgeIsNotAllowed()
        {
            var result = new MutationTestsService().AllowedAgeToDrive(15);
            result.Should().BeFalse();
        }
    }
}