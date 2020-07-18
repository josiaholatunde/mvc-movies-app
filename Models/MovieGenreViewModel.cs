using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieViewGenreModel
    {
        public List<Movie> Movies { get; set; }

        public SelectList Genres { get; set; }

        public string MovieGenre { get; set; }

        public string SearchString { get; set; }

    }
    
}