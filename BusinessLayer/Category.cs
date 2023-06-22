﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Name must be between 1 and 20 symbols.")]
        public string Name { get; set; }

        public List<User> Users { get; set; } = new List<User> { };

        public List<Interest> Interests { get; set; } = new List<Interest> { };


        public Category() { }

        public Category(string name)
        {
            this.Name = name;
        }
    }
}
