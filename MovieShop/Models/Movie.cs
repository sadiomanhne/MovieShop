﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MovieShop.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime Release { get; set; }
        public string  Genre { get; set; }
        public decimal Price { get; set; }
        
    }
}
