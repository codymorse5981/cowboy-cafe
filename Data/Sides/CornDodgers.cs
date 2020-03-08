/* Author: Cody Morse
 * Class: CornDodgers.cs
 * Description: Handles corn dodgers side class
  */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a side of corn dodgers
    /// </summary>
    public class CornDodgers : Side
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
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
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
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
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
            return Size + " Corn Dodgers";
        }

        /// <summary>
        /// Special instruction list (empty)
        /// </summary>
        public override List<string> SpecialInstructions { get; }
    }
}