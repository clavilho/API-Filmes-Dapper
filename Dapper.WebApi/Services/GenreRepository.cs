using Dapper;
using Microsoft.Extensions.Configuration;
using projeto.movie.api.Models;
using projeto.movie.api.Services.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.movie.api.Services
{
    public class GenreRepository : BaseRepository, IGenreRepository
    {

        private readonly ICommandTextGenre _commandTextGenre;

        public GenreRepository(ICommandTextGenre commandTextGenre, IConfiguration configuration) : base(configuration)
        {
            _commandTextGenre = commandTextGenre;
        }

        public async Task AddGenre(Genre entity)
        {
            await WithConnection(async con =>
            {

                await con.ExecuteAsync(_commandTextGenre.AddGenre, new {  Name = entity.Name });
            });
        }

        public async Task<IEnumerable<Genre>> GetAllGenre()
        {

            return await WithConnection(async conn =>
            {
                var query = await conn.QueryAsync<Genre>(_commandTextGenre.GetAllGenre);
                return query;
            });

        }

        public async ValueTask<Genre> GetGenreById(int id)
        {
            return await WithConnection(async conn =>
            {
                var query = await conn.QueryFirstOrDefaultAsync<Genre>(_commandTextGenre.GetGenreById, new { Id = id });
                return query;
            });
        }



        public async Task RemoveGenre(int id)
        {
            await WithConnection(async conn =>
           {
               await conn.ExecuteAsync(_commandTextGenre.RemoveGenre, new { Id = id });
           });
        }

        public async Task UpdateGenre(Genre entity, int id)
        {
            await WithConnection(async conn =>
            {
                await conn.ExecuteAsync(_commandTextGenre.UpdateGenre, new { Id = entity.Id, Name = entity.Name });
            });
        }


    }
}
