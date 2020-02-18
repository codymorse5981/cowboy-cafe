/* Author: Cody Morse
 * Class: TexasTea.cs
 * Description: Handles Texas Tea class
  */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a texas tea drink
    /// </summary>
    public class TexasTea: Drink
    {
        /// <summary>
        /// If there is sweetener in the texas tea
        /// </summary>
        private bool sweet = true;
        public bool Sweet
        {
            get { return sweet; }
            set { sweet = value; }
        }

        /// <summary>
        /// If there is a lemon in the texas tea
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }


        /// <summary>
        /// Gets the price of the tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        private List<string> ingridients;
        /// <summary>
        /// List of texas tea ingridients
        /// </summary>
        public override List<string> Ingridients
        {
            get { return ingridients; }
            set { ingridients = value; }
        }

        private bool ice = true;
        /// <summary>
        /// If the texas tea has ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Gets the calories of texas tea. If sweet / if not sweet
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            throw new NotImplementedException();
                    }


                }
            }
        }

        /// <summary>
        /// Special instructions for the texas tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        /// <summary>
        /// Override ToString() method and provide string return.
        /// </summary>
        public override string ToString()
        {
            if (Sweet)
            {
                return Size + " Texas Sweet Tea";
            }
            else
            {
                return Size + " Texas Plain Tea";
            }
        }
    }
}

