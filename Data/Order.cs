/* Author: Cody Morse
 * Class: Order.cs
 * Description: Handles Order class for application.
  */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        private static uint lastOrderNumber = 1;

        /// <summary>
        /// Instantiates new list.
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Instantiates items list to an enumerable.
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// Instantiating variable for subtotal
        /// </summary>
        private double subtotal = 0;

        /// <summary>
        /// Generates subtotal
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem i in items)
                {
                    subtotal += i.Price;
                }
                return subtotal;
            }
            set
            {
                ///
            }
        }

        /// <summary>
        /// Gets/Sets the last order number
        /// </summary>
        public uint OrderNumber => lastOrderNumber++;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Adds item into list and updates four variables.
        /// </summary>
        /// <param name="item">Item to add into list</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            OnItemPropertyChanged(this, new PropertyChangedEventArgs("Price"));

            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            
        }

        /// <summary>
        /// removes item into list and updates four variables.
        /// </summary>
        /// <param name="item">Item to add into list</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            OnItemPropertyChanged(this, new PropertyChangedEventArgs("Price"));
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }
        }

        /// <summary>
        /// When item property changes this updates the list and instructions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
            
        }
    }
}
