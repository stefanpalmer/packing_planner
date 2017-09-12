using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PackingPlanner1.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public byte Quantity { get; set; }

        public Category Category { get; set; }

        [Display(Name = "Category")]
        public byte CategoryId { get; set; }
    }
}