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
        [Range(0.01, Int32.MaxValue, ErrorMessage = "Value has to be greater than zero.")]
        public short Quantity { get; set; }

        public Category Category { get; set; }

        [Display(Name = "Category")]
        public byte CategoryId { get; set; }
    }
}