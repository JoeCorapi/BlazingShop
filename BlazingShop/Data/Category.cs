using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazingShop.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
