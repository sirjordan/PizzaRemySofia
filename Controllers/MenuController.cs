using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaRemySofia.Models;

namespace PizzaRemySofia.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View(this.GetMenu());
        }

        private MenuViewModel GetMenu()
        {
            var categories = new[]{
                new CategoryViewModel { Id = 1, NameBg = "Салати", NameEn = "Salads", Order = 1}
            };

            var menuItems = new[] {
                new MenuItemViewModel { Category = categories[0], NameBg = "Шопска салата", NameEn = "Shopska salad", Price = 4.90, Weight = 300, DescriptionBg = "домат,краставица,чушка,лук,сирене", DescriptionEn = "tomato, cucumber, pepper, onion, cheese" },
            };

            var grouped = menuItems.GroupBy(m => m.Category, new CategoryComparer());
            var result = grouped.ToDictionary(g => g.Key, g => g.AsEnumerable());

            return new MenuViewModel { Items = result };
        }
    }
}
