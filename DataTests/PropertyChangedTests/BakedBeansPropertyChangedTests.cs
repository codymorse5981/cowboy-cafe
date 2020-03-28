﻿/* Author: Cody Morse
 * Class: BakedBeansPropertyChangedTests.cs
 * Description: Tests for baked beans properties.
*/

using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class BakedBeansPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void BakedBeansShouldImplrementINotifyPropertyChanged()
        {
            var beans = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(beans);
        }

        /// <summary>
        /// Checks size property if Property changed for size
        /// </summary>
        /// <param name="size">Size of the item</param>
        [Theory]
        [InlineData(Size.Large)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Small)]
        public void BakedBeansSizeChangeShouldNotifyPropertyChanged(Size size)
        {
            BakedBeans beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Size", () =>
            {
                beans.Size = size;
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
        public void BakedBeansSizeChangeShouldNotifyPropertyChangedForPrice(Size size)
        {
            BakedBeans beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Price", () =>
            {
                beans.Size = size;
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
        public void BakedBeansSizeChangeShouldNotifyPropertyChangedForCalories(Size size)
        {
            BakedBeans beans = new BakedBeans();
            Assert.PropertyChanged(beans, "Calories", () =>
            {
                beans.Size = size;
            });
        }
    }
}
