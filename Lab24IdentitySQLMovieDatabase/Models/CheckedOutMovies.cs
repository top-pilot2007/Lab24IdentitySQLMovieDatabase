using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab24IdentitySQLMovieDatabase.Models
{
    public class CheckedOutMovies
    {
        public int Id { get; set; }//Primary Key
        public IdentityUser User { get; set; }//Foreign key to Users table
        public string UserId { get; set; }

        public Movie Movie { get; set; }//Foreign key to Movies table
        public int MovieId { get; set; }
        public DateTime DueDate { get; set; }
    }
}
