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
                new CategoryViewModel { Id = 1, NameBg = "Салати", NameEn = "Salads", Order = 1},
                new CategoryViewModel { Id = 2, NameBg = "СТУДЕНИ ПРЕДЯСТИЯ", NameEn = "STARTERS", Order = 2},
            };

            var menuItems = new[] {
                new MenuItemViewModel { Category = categories[0], NameBg = "Шопска салата", NameEn = "Shopska salad", Price = 4.90, Weight = 300, DescriptionBg = "домат,краставица,чушка,лук,сирене", DescriptionEn = "tomato, cucumber, pepper, onion, cheese" },
                new MenuItemViewModel { Category = categories[0], NameBg = "Овчарска салата", NameEn = "Shepherd’s salad", Price = 6.50, Weight = 300, DescriptionBg = "домат,краставица,шунка,кашкавал,сирене,лук,маслини,яйце", DescriptionEn = "tomato, cucumber, pepper, yellow cheese, ham, onion, olive, egg" },

                new MenuItemViewModel { Category = categories[1], NameBg = "Суджук", NameEn = "flat sausages \"Sudjuk\"", Price = 10.90, Weight = 170, DescriptionBg = "", DescriptionEn = "" },
            };

            var grouped = menuItems.GroupBy(m => m.Category, new CategoryComparer());
            var result = grouped.ToDictionary(g => g.Key, g => g.AsEnumerable());

            return new MenuViewModel { Items = result };
        }
    }
}
