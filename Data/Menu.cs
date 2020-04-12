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
        public static IEnumerable<IOrderItem> AllMenuItems
        {
            get
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
        }
        /// <summary>
        /// a property with a getter for AllEntrees
        /// </summary>
        public static IEnumerable<IOrderItem> AllEntrees
        {
            get
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
        }
        /// <summary>
        /// a property with a getter for AllSides
        /// </summary>
        public static IEnumerable<IOrderItem> AllSides
        {
            get
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
        }
        /// <summary>
        /// a property with a getter for AllDrinks
        /// </summary>
        public static IEnumerable<IOrderItem> AllDrinks
        {
            get
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
        }

    }
}