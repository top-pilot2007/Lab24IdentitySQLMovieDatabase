using Lab24IdentitySQLMovieDatabase.Data;
using Lab24IdentitySQLMovieDatabase.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab24IdentitySQLMovieDatabase.Services
{
    public class CheckOut: ICheckOut
    {
        private readonly ApplicationDbContext _context;
        public CheckOut (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task <List<Movie>> GetMovies()
        {
            return await _context.Movies.ToListAsync();
        }
    }
}
