/* Author: Cody Morse
 * Class: WaterPropertyChangedTests.cs
 * Description: Tests for water properties.
*/

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
                water.Lemon = true;
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
                water.Lemon = true;
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
        /// Checks size property if Property changed for size
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void WaterSizeChangeShouldNotifyPropertyChanged(Size size)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = size;
            });
        }

        /// <summary>
        /// Checks size property if Property changed for Price
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void WaterCoffeeSizeChangeShouldNotifyPropertyChangedForPrice(Size size)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Price", () =>
            {
                water.Size = size;
            });
        }

        /// <summary>
        /// Checks size property if Property changed for Calories
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void WaterSizeChangeShouldNotifyPropertyChangedForCalories(Size size)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Calories", () =>
            {
                water.Size = size;
            });
        }
    }
}