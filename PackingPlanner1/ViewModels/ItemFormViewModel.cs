using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PackingPlanner1.Models;

namespace PackingPlanner1.ViewModels
{
    public class ItemFormViewModel
    {
        public Item Item { get; set; }
        public IEnumerable<Category> Category { get; set; }
    }
}