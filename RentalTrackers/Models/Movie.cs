﻿
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Razor;

namespace RentalTrackers.Models
{
    public class Movie
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        public Genre Genre { get; set; }


        public DateTime? DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }

        [Display(Name = "Number Available")]
        public byte NumberAvailable { get; set; }
    }
}