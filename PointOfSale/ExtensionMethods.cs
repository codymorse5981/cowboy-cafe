using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace PointOfSale
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Finds the first ancestor in the visual tree that has the specified type
        /// </summary>
        /// <typeparam name="T">Type to search for</typeparam>
        /// <param name="obj"></param>
        /// <returns>The first ancestor of Type T, or null</returns>
        public static T FindAncestor<T>(this DependencyObject obj) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(obj);

            if (parent == null) return null;

            if (parent is T) return parent as T;

            return FindAncestor<T>(parent);
        }

    }
}
