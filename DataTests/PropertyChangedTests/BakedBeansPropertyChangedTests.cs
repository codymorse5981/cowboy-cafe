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
        public void BakedBeansSizeChangeShouldNotifyPropertyChanged(Size size, string propertyName)
        {
            BakedBeans beans = new BakedBeans();
            Assert.PropertyChanged(beans, propertyName, () =>
            {
                beans.Size = size;
            });
        }
    }
}
