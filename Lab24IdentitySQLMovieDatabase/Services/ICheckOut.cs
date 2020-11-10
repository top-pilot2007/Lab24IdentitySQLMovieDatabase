using Lab24IdentitySQLMovieDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab24IdentitySQLMovieDatabase.Services
{
    public interface ICheckOut
    {
        Task<List<Movie>> GetMovies();
    }
}
