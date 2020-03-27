using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class WaterPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void WaterShouldImplrementINotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }


        /// <summary>
        /// Testing Ice property for invocation of PropertyChanged for Ice
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = false;
            });
        }

        /// <summary>
        /// Testing Lemon property for invocation of PropertyChanged for Lemon
        /// </summary>
        [Fact]
        public void ChangingLemonPropertyShouldInvokePropertyChangedForLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () =>
            {
                water.Lemon = false;
            });
        }


        /// <summary>
        /// Changing the Lemon property should invoke PropertyChanged for SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Lemon = false;
            });
        }

        /// <summary>
        /// Changing the Ice property should invoke PropertyChanged for SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Ice = false;
            });
        }

        /// <summary>
        /// Checks size property if Property changed
        /// </summary>
        /// <param name="size">Size of the item</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(Size.Large, "ToString")]
        [InlineData(Size.Medium, "ToString")]
        [InlineData(Size.Small, "ToString")]
        [InlineData(Size.Large, "Price")]
        [InlineData(Size.Medium, "Price")]
        [InlineData(Size.Small, "Price")]
        public void WaterSizeChangeShouldNotifyPropertyChanged(Size size, string propertyName)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, propertyName, () =>
            {
                water.Size = size;
            });
        }
    }
}