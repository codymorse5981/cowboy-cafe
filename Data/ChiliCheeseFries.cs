/* Author: Cody Morse
 * Class: ChiliCheeseFries.cs
 * Description: Handles chili cheese fries side class
  */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a side of chili cheese fries
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }

            }
        }
            /// <summary>
            /// Override ToString() method and provide string return.
            /// </summary>
        public override string ToString()
        {
            return Size + " Chili Cheese Fries";
        }

        public override List<string> SpecialInstructions { get; }
    }

}
