﻿/* Author: Cody Morse
 * Class: Drink.cs
 * Description: Handles Drink classes (abstract)
  */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size;
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; 
                  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));              
                  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                }
        }
        /// <summary>
        /// Gets the ingridients of the drink
        /// </summary>
        public abstract List<string> Ingridients { get; set; }

        /// <summary>
        /// Whether ice is wanted
        /// </summary>
        public abstract bool Ice { get; set; }

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the instructions of the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get;}


    }

}
