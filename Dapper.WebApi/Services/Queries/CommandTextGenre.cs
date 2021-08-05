using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.movie.api.Services.Queries
{
    public class CommandTextGenre : ICommandTextGenre
    {
        public string GetAllGenre => "SELECT * FROM genre";
        public string AddGenre => "Insert into [dbo].[genre] (name) values ( @Name)";

        public string GetGenreById => throw new NotImplementedException();

        public string UpdateGenre => throw new NotImplementedException();

        public string RemoveGenre => throw new NotImplementedException();

        public string GetMovieByIdSp => throw new NotImplementedException();
    }
}
