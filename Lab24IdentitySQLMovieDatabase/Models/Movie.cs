using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Lab24IdentitySQLMovieDatabase.Models
{
    public class Movie
    {
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Genre")]
        public MovieGenre Genre { get; set; }

        [Display(Name = "Year")]
        //[DisplayFormat(DataFormatString = "{0:yyyy}")]
        public int Year { get; set; }

        [Display(Name = "Actors")]
        public string Actors { get; set; }

        [Display(Name = "Directors")]
        public string Directors { get; set; }

        [Display(Name = "Runtime")]
        public double Runtime { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        public List<CheckedOutMovies> CheckedOutMovies { get; set; }
    }
}
