/* Author: Professor Bean
 * Edited by: Cody Morse
 * Class: Side.cs
 * Description: Handles Side classes (abstract)
  */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for properties changing.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size;
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Calories");
            }
        }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        public abstract List<string> SpecialInstructions { get; }


        /// <summary>
        /// Helper method for notifying changed
        /// </summary>
        /// <param name="propertyName">Property for notifying</param>
        private protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
