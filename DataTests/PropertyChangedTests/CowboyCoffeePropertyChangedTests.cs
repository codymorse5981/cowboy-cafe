using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void CowboyCoffeeShouldImplrementINotifyPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }

        /// <summary>
        /// Testing Decaf property for invocation of PropertyChanged for Decaf
        /// </summary>
        [Fact]
        public void ChangingDecafPropertyShouldInvokePropertyChangedForDecaf()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () =>
            {
                coffee.Decaf = false;
            });
        }

        /// <summary>
        /// Testing Ice property for invocation of PropertyChanged for Ice
        /// </summary>
        [Fact]
        public void ChangingIcePropertyShouldInvokePropertyChangedForIce()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Ice", () =>
            {
                coffee.Ice = false;
            });
        }

        /// <summary>
        /// Testing RoomForCream property for invocation of PropertyChanged for RoomForCream
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamPropertyShouldInvokePropertyChangedForRoomForCream()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () =>
            {
                coffee.RoomForCream = false;
            });
        }

        /// <summary>
        /// Changing the Decaf property should invoke PropertyChanged for SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Decaf = false;
            });
        }

        /// <summary>
        /// Changing the RoomForCream property should invoke PropertyChanged for SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.RoomForCream = false;
            });
        }

        /// <summary>
        /// Changing the Ice property should invoke PropertyChanged for SpecialInstructions
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Ice = false;
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
        public void CowboyCoffeeSizeChangeShouldNotifyPropertyChanged(Size size, string propertyName)
        {
            CowboyCoffee coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, propertyName, () =>
            {
                coffee.Size = size;
            });
        }
    }
}