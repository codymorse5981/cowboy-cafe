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
        private static uint lastOrderNumber = 0;

        /// <summary>
        /// Instantiates new list.
        /// </summary>
        private List<IOrderItem> items;

        /// <summary>
        /// Instantiates items list to an enumerable.
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// Order instantiation.
        /// </summary>
        public Order()
        {
            items = new List<IOrderItem>();
            lastOrderNumber++;
        }

        /// <summary>
        /// Generates subtotal
        /// </summary>
        public double Subtotal
        {
            get
            {
                double totalCost = 0;
                foreach (IOrderItem i in items)
                {
                    totalCost += i.Price;
                }
                return totalCost;
            }
            set
            {
                ///
            }
        }

        /// <summary>
        /// Gets/Sets the last order number
        /// </summary>
        public uint OrderNumber => lastOrderNumber;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Adds item into list and updates four variables.
        /// </summary>
        /// <param name="item">Item to add into list</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderNumber"));
        }

        /// <summary>
        /// removes item into list and updates four variables.
        /// </summary>
        /// <param name="item">Item to add into list</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderNumber"));
        }
    }
}
