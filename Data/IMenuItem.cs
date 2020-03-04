using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Interface for a menu item. Requires price, calories, and ingredients properties.
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Price of the tem.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Amount of calories for the item.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// List of ingredients for the item.
        /// </summary>
        List<string> Ingredients { get; }
    }
}