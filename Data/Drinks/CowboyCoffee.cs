/* Author: Cody Morse
 * Class: CowboyCoffee.cs
 * Description: Handles Cowboy Coffee class
  */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a cowboy coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        private bool decaf = false;
        /// <summary>
        /// If the coffee is decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; } 
        }


        /// <summary>
        /// Gets the flavor of the cowboy coffee
        /// </summary>
        private bool cream = false;
        public bool RoomForCream
        {
            get { return cream; }
            set { cream = value; }
        }


        /// <summary>
        /// Gets the price of the cowboy coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private List<string> ingridients;
        /// <summary>
        /// List of coffee ingridients
        /// </summary>
        public override List<string> Ingridients
        {
            get { return ingridients; }
            set { ingridients = value; }
        }

        private bool ice = false;
        /// <summary>
        /// If the coffee has ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Gets the calories of cowboy coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }  
            }
        }

        /// <summary>
        /// Special instructions for the cowboy coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (Decaf) instructions.Add("Decaf coffee");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// Override ToString() method and provide string return.
        /// </summary>
        public override string ToString()
        {
            if (Decaf)
            {
                return Size + " Decaf Cowboy Coffee";
            }
            else
            {
                return Size + " Cowboy Coffee";
            }
            
        }
    }
}

