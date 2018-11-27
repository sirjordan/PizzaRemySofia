using System;
using System.Collections.Generic;

namespace PizzaRemySofia.Models
{
    public class MenuViewModel
    {
        public Dictionary<CategoryViewModel, IEnumerable<MenuItemViewModel>> Items { get; set; }
    }
}