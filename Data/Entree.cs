using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a entree
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories{ get; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the instructions of the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
