/* Author: Cody Morse
 * Class: JerkedSoda.cs
 * Description: Handles jerked soda drink class
  */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a jerked soda drink
    /// </summary>
    public class JerkedSoda: Drink
    {
        /// <summary>
        /// Gets the flavor of the jerked soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }

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
            set { ice = value; }
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
    }
}

