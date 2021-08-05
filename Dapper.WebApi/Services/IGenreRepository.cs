using projeto.movie.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.movie.api.Services
{
    public interface IGenreRepository
    {
        Task<IEnumerable<Genre>> GetAllGenre();
        ValueTask<Genre> GetGenreById(int id);
        Task AddGenre(Genre entity);
        Task UpdateGenre(Genre entity, int id);
        Task RemoveGenre(int id);
    }
}
