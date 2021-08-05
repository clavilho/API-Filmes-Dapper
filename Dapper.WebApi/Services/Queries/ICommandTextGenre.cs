namespace projeto.movie.api.Services.Queries
{
    public interface ICommandTextGenre
    {

        string GetAllGenre { get; }
        string GetGenreById { get; }
        string AddGenre { get; }
        string UpdateGenre { get; }
        string RemoveGenre { get; }
        string GetMovieByIdSp { get; }

    }
}
