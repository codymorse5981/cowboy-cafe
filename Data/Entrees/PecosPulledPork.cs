/* Author: Cody Morse
 * Class: PecosPulledPork.cs
 * Description: Handles Pecos Pulled Pork class
  */

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork: Entree
    {

        private bool bread = true;
        /// <summary>
        /// If the pulled pork comes with side of bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value;
                NotifyOfPropertyChange("Bread");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the pulled pork comes with side of pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }

        /// <summary>
        /// The price of the pulled pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the pulled pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the pulled pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Override ToString() method and provide string return.
        /// </summary>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }

    }
}

