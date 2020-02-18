/* Author: Cody Morse
 * Class: PanDeCampo.cs
 * Description: Handles Pan De Campo side class
  */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a side of pan de campo
    /// </summary>
    public class PanDeCampo : Side
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
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
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
            return Size + " Pan de Campo";
        }
    }
}

