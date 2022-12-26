namespace EddyePlay.Application.Services.Quality
{
    public class MutationTestsService
    {
        public bool AllowedAgeToDrive(int age)
        {
            if (age >= 18)
                return true;
            else
                return false;
        }
    }
}
