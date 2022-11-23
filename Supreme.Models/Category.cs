﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Supreme.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        [DisplayName(" Name")]
        
         public string? Name { get; set; }
       
        public string? Description { get; set; }
    }
}
