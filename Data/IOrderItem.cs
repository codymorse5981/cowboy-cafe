/* Author: Cody Morse
 * Class: IOrderItem.cs
 * Description: Handles IOrderItem interface
  */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem: INotifyPropertyChanged
    {
        /// <summary>
        /// The price of the order item
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// The calories of the order item
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// The special instructions for the order item
        /// </summary>
        public List<string> SpecialInstructions { get; }
    }
}
