/* Author: Cody Morse
 * Class: TexasTripleBurgerCustomization.cs
 * Description: Handles TexasTripleBurgerCustomization class
  */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale.EntreeCustomization
{
    /// <summary>
    /// Interaction logic for TexasTrip;eBurgerCustomization.xaml
    /// </summary>
    public partial class TexasTripleBurgerCustomization : UserControl
    {
        public TexasTripleBurgerCustomization()
        {
            InitializeComponent();           
        }

        private TexasTripleBurger tripleBurger;
        public TexasTripleBurgerCustomization(TexasTripleBurger t)
        {
            tripleBurger = t;
            InitializeComponent();
        }
    }
}
