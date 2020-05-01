/* Menu.cs
 * Author : Cody Morse
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Returns All possible items
        /// </summary>
        public static IEnumerable<IOrderItem> All()
        {
            List<IOrderItem> menuItems = new List<IOrderItem>();
            foreach (IOrderItem item in Entrees())
            {
                menuItems.Add(item);
            }

            foreach (IOrderItem item in Drinks())
            {
                menuItems.Add(item);
            }

            foreach (IOrderItem item in Sides())
            {
                menuItems.Add(item);
            }

            return menuItems;

        }
        /// <summary>
        /// Returns All possible entrees
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> menuEntrees = new List<IOrderItem>
            {
                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new TrailBurger()
            };
            return menuEntrees;
        }
        /// <summary>
        /// Returns All possible sides
        /// </summary>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> menuSides = new List<IOrderItem>();
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CornDodgers corn = new CornDodgers();
                corn.Size = size;
                menuSides.Add(corn);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                ChiliCheeseFries chili = new ChiliCheeseFries();
                chili.Size = size;
                menuSides.Add(chili);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                BakedBeans baked = new BakedBeans();
                baked.Size = size;
                menuSides.Add(baked);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                PanDeCampo campo = new PanDeCampo();
                campo.Size = size;
                menuSides.Add(campo);
            }

            return menuSides;

        }
        /// <summary>
        /// Returns All possible Drinks
        /// </summary>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> menuDrinks = new List<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                JerkedSoda soda = new JerkedSoda();
                soda.Flavor = SodaFlavor.None;
                soda.Size = size;
                menuDrinks.Add(soda);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                Water water = new Water();
                water.Size = size;
                menuDrinks.Add(water);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CowboyCoffee coffee = new CowboyCoffee();
                coffee.Size = size;
                menuDrinks.Add(coffee);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                TexasTea tea = new TexasTea();
                tea.Size = size;
                menuDrinks.Add(tea);
            }
            return menuDrinks;
        }

        /// <summary>
        /// Searches through the list for the given terms
        /// </summary>
        /// <param name="items">Items to filter</param>
        /// <param name="terms">Terms to filter items by</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string terms)
        {
            if (terms == null) return items;

            return items.Where(item => item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Filters the given list by food category
        /// </summary>
        /// <param name="items">Items to filter out</param>
        /// <param name="menuCategories">Categories to filter by</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> items, string[] menuCategories)
        {
            if (menuCategories == null || menuCategories.Length == 0) return items;
            List<IOrderItem> result = new List<IOrderItem>();
            IEnumerable<IOrderItem> temp = null;
            foreach (string menuCategory in menuCategories)
            {
                switch (menuCategory)
                {
                    case "Entree":
                        temp = items.Where(item => item is Entree);
                        break;
                    case "Side":
                        temp = items.Where(item => item is Side);
                        break;
                    case "Drink":
                        temp = items.Where(item => item is Drink);
                        break;
                    default:
                        return items;
                }
                foreach(IOrderItem item in temp)
                {
                    result.Add(item);
                }
                temp = null;
            }
            return result;
        }

        /// <summary>
        /// Filters by a minimum and maximum calorie amount
        /// </summary>
        /// <param name="items">Items to filter</param>
        /// <param name="min">Minimum calories</param>
        /// <param name="max">Maximum calories</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            if (min == null) min = 0;
            if (max == null) max = 10;
            return items.Where(item => item.Calories >= min && item.Calories <= max);

        }

        /// <summary>
        /// Sorts by a minimum or maximum price
        /// </summary>
        /// <param name="items">Items to filter out</param>
        /// <param name="min">Minimum Price</param>
        /// <param name="max">Maximum Price</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            if (min == null) min = 0;
            if (max == null) max = 10;
            return items.Where(item => item.Price >= min && item.Price <= max); 

        }
    }
}