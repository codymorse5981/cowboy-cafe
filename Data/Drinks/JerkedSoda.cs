/* Author: Cody Morse
 * Class: JerkedSoda.cs
 * Description: Handles jerked soda drink class
  */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a jerked soda drink
    /// </summary>
    public class JerkedSoda: Drink
    {

        private SodaFlavor flavor;
        /// <summary>
        /// Gets the flavor of the jerked soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; 
                NotifyOfPropertyChange("Flavor"); 
            }
        }


        /// <summary>
        /// Gets the price of the jerked soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
                
            }
        }

        private List<string> ingridients;
        /// <summary>
        /// List of soda ingridients
        /// </summary>
        public override List<string> Ingridients
        {         
                get { return ingridients; }
                set { ingridients = value; }
        }

        private bool ice = true;
        /// <summary>
        /// If the jerked soda has ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }

        /// <summary>
        /// Gets the calories of jerked soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// Special instructions for the jerked soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }           
        }

        /// <summary>
        /// Override ToString() method and provide string return.
        /// </summary>
        public override string ToString()
        {
            if (Flavor == SodaFlavor.BirchBeer)
            {
                return Size + " " + "Birch Beer Jerked Soda";
            }
            else if(Flavor == SodaFlavor.CreamSoda)
            {
                return Size + " " + "Cream Soda Jerked Soda";
            }
            else if (Flavor == SodaFlavor.OrangeSoda)
            {
                return Size + " " + "Orange Soda Jerked Soda";
            }
            else if (Flavor == SodaFlavor.RootBeer)
            {
                return Size + " " + "Root Beer Jerked Soda";
            }
            else
            {
                return Size + " " + "Sarsparilla Jerked Soda";
            }         
        }
    }
}

