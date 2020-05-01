/* IndexModel.cs
 * Author : Cody Morse
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Enumerable list of menu items based on filter items
        /// </summary>
        public IEnumerable<IOrderItem> menuItems { get; protected set; } = Menu.All();

        /// <summary>
        /// Search terms to filter out
        /// </summary>
        [BindProperty]
        public string search { get; set; }

        /// <summary>
        /// Categories of items selected
        /// </summary>
        [BindProperty]
        public string[] menuCategory { get; set; }

        /// <summary>
        /// Minimum price inputed
        /// </summary>
        [BindProperty]
        public double? minimumPrice { get; set; }

        /// <summary>
        /// Maximum price inputed
        /// </summary>
        [BindProperty]
        public double? maximumPrice { get; set; }

        /// <summary>
        /// Minimum calories selected
        /// </summary>
        [BindProperty]
        public int? minimumCalories { get; set; }

        /// <summary>
        /// Maximum calories selected
        /// </summary>
        [BindProperty]
        public int? maximumCalories { get; set; }

        /// <summary>
        /// Count for determining items in each column
        /// </summary>
        [BindProperty]
        public int Count { get; set; } = 0;

        /// <summary>
        /// Count for determining items in each column
        /// </summary>
        [BindProperty]
        public bool ContainsJerkedSoda { get; set; } = false;

        /// <summary>
        /// On submit menu items will be filtered
        /// </summary>
        /// <param name="MinimumPrice">Minimium Price inputed in box</param>
        /// <param name="MaximumPrice">Maximum Price inputed in box</param>
        /// <param name="MinimumCalories">Minimium Calories inputed in box</param>
        /// <param name="MaximumCalories">Maximum Calories inputed in box</param>
        public void OnGet(double? MinimumPrice, double? MaximumPrice, int? MinimumCalories, int? MaximumCalories)
        {
            this.minimumPrice = MinimumPrice;
            this.maximumPrice = MaximumPrice;
            this.minimumCalories = MinimumCalories;
            this.maximumCalories = MaximumCalories;
            search = Request.Query["search"];
            menuCategory = Request.Query["MenuCategory"];
            menuItems = Menu.Search(menuItems,search);
            menuItems = Menu.FilterByPrice(menuItems, minimumPrice, maximumPrice);
            menuItems = Menu.FilterByCalories(menuItems, minimumCalories, maximumCalories);
            menuItems = Menu.FilterByType(menuItems, menuCategory);
        }
    }
}

