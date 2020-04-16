/* Menu.cs
 * Author : Cody Morse
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// Getter for AllMenuItems
        /// </summary>
        public static IEnumerable<IOrderItem> AllMenuItems()
        {
            List<IOrderItem> menuItems = new List<IOrderItem>
            {
                new CowboyCoffee(),
                new JerkedSoda(),
                new TexasTea(),
                new Water(),

                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new TrailBurger(),

                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo()
            };
            return menuItems;

        }
        /// <summary>
        /// a property with a getter for AllEntrees
        /// </summary>
        public static IEnumerable<IOrderItem> AllEntrees()
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
        /// a property with a getter for AllSides
        /// </summary>
        public static IEnumerable<IOrderItem> AllSides()
        {
            List<IOrderItem> menuSides = new List<IOrderItem>
            {
                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo()

            };
            return menuSides;
            
        }
        /// <summary>
        /// a property with a getter for AllDrinks
        /// </summary>
        public static IEnumerable<IOrderItem> AllDrinks()
        {
            List<IOrderItem> menuDrinks = new List<IOrderItem>
            {
                new CowboyCoffee(),
                new JerkedSoda(),
                new TexasTea(),
                new Water(),
            };
            return menuDrinks;
        }

        /// <summary>
        /// Updates the size of side object
        /// </summary>
        /// <param name="side">The side object</param>
        /// <param name="size">The size</param>
        public static void ChangeSideSize(Side side, Size size)
        {
            side.Size = size;
        }

        /// <summary>
        /// Updates the size of drink object
        /// </summary>
        /// <param name="drink">The drink object</param>
        /// <param name="size">The size</param>
        public static void ChangeDrinkSize(Drink drink, Size size)
        {
            drink.Size = size;
        }

    }
}