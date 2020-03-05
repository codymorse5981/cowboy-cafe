/* Author: Cody Morse
 * Class: Water.cs
 * Description: Handles Water class
  */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a water drink
    /// </summary>
    public class Water: Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// If there is a lemon in the water
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                     PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstruction"));
                }
        }

        /// <summary>
        /// Gets the price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        private List<string> ingridients;
        /// <summary>
        /// List of water ingridients
        /// </summary>
        public override List<string> Ingridients
        {
            get { return ingridients; }
            set { ingridients = value; }
        }

        private bool ice = true;
        /// <summary>
        /// If the water has ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstruction"));
            }
        }

        /// <summary>
        /// Gets the calories of the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        throw new NotImplementedException();
                }
            }      
        }

        /// <summary>
        /// Special instructions for the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        /// <summary>
        /// Override ToString() method and provide string return.
        /// </summary>
        public override string ToString()
        {
            return Size + " Water";
        }
    }
}

