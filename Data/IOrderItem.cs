using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the order item
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// The special instructions for the order item
        /// </summary>
        public IEnumerable<string> SpecialInstructions { get; }
    }
}
