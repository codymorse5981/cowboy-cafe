﻿/* Author: Cody Morse
 * Class: RustlersRibs.cs
 * Description: Handles Rustler's Ribs entree class
  */

using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs: Entree
    {
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }

        /// <summary>
        /// Override ToString() method and provide string return.
        /// </summary>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}


