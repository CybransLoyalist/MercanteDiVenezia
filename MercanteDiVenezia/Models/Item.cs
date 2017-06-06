﻿using System.ComponentModel.DataAnnotations;

namespace MercanteDiVenezia.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}