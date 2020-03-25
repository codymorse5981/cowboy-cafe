/* Author: Cody Morse
 * Class: AngryChickenCustomization.cs
 * Description: Handles AngryChickenCustomization class
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
    /// Interaction logic for AngryChickenCustomization.xaml
    /// </summary>
    public partial class AngryChickenCustomization : UserControl
    {
        public AngryChickenCustomization()
        {
            InitializeComponent();          
        }

        private AngryChicken chicken;
        public AngryChickenCustomization(AngryChicken c)
        {
            chicken = c;
            //this.DataContext = this;
            InitializeComponent();
        }
    }
}
