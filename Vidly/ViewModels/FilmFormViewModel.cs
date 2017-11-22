﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class FilmFormViewModel
    {
        public IEnumerable<Zanr> Zanrs { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? ZanrId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public int? Stock { get; set; }


        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public Film Film { get; set; }

        public FilmFormViewModel()
        {
            Id = 0;
        }

        public FilmFormViewModel(Film film)
        {
            Id = film.Id;
            Name = film.Name;
            ReleaseDate = film.ReleaseDate;
            Stock = film.Stock;
            ZanrId = film.ZanrId;
        }
    }
}