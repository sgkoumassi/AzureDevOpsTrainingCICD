﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        // Foreign key
        [Required]
        public int AuthorId { get; set; }
    
        // Nagigation property
        public Author Author { get; set; }
    }
}