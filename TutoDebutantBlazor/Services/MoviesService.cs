using TutoDebutantBlazor.Entities;

namespace TutoDebutantBlazor.Services;

public class MoviesService
{
    public List<Movie> GetMovies()
    {
        return new List<Movie>
        {
            new Movie { Title = "Star Wars", ReleaseDate = new DateTime(1977, 5, 25) },
            new Movie { Title = "Indiana Jones", ReleaseDate = new DateTime(1981, 6, 12) },
            new Movie { Title = "Jurassic Park", ReleaseDate = new DateTime(1993, 6, 11) }
        };
    }
}
