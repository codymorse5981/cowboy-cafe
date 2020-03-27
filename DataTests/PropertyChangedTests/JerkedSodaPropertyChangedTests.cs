using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void JerkedSodaShouldImplrementINotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }

        /// <summary>
        /// Changing the Ice property should invoke PropertyChanged for SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Ice = false;
            });
        }

        /// <summary>
        /// Checks size property if Property changed
        /// </summary>
        /// <param name="size">Size of the item</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(Size.Large, "Description")]
        [InlineData(Size.Medium, "Description")]
        [InlineData(Size.Small, "Description")]
        [InlineData(Size.Large, "Price")]
        [InlineData(Size.Medium, "Price")]
        [InlineData(Size.Small, "Price")]
        public void JerkedSodaSizeChangeShouldNotifyPropertyChanged(Size size, string propertyName)
        {
            JerkedSoda soda = new JerkedSoda();
            Assert.PropertyChanged(soda, propertyName, () =>
            {
                soda.Size = size;
            });
        }

        /// <summary>
        /// Checks size property if Property changed
        /// </summary>
        /// <param name="size">Size of the item</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(SodaFlavor.CreamSoda)]
        [InlineData(SodaFlavor.OrangeSoda)]
        [InlineData(SodaFlavor.RootBeer)]
        [InlineData(SodaFlavor.BirchBeer)]
        [InlineData(SodaFlavor.Sarsparilla)]
        public void JerkedSodaFlavorChangeShouldNotifyPropertyChanged(SodaFlavor flavor)
        {
            JerkedSoda soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "ToString()", () =>
            {
                soda.Flavor = flavor;
            });
        }
    }
}