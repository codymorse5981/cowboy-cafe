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

namespace PointOfSale.DrinkCustomization
{
    /// <summary>
    /// Interaction logic for FlavorSelect.xaml
    /// </summary>
    public partial class FlavorSelect : UserControl
    {
        private Drink soda;
        public FlavorSelect()
        {
            InitializeComponent();
        }
    }
}
