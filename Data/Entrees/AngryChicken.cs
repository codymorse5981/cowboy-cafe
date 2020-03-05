﻿/* Author: Cody Morse
 * Class: AngryChicken.cs
 * Description: Handles Angry Chicken entree class
  */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken: Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool bread = true;
        /// <summary>
        /// If the chicken comes with side of bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstruction"));
            }
        }

        private bool pickle = true;
    
        /// <summary>
        /// If the chicken is comes with side of pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstruction"));
            }
        }

        /// <summary>
        /// The price of the chicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chicken
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
            return "Angry Chicken";
        }

    }
}

