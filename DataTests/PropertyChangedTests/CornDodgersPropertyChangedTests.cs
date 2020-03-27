using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void CornDodgersShouldImplrementINotifyPropertyChanged()
        {
            var corn = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(corn);
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
        public void CornDodgersSizeChangeShouldNotifyPropertyChanged(Size size, string propertyName)
        {
            CornDodgers corn = new CornDodgers();
            Assert.PropertyChanged(corn, propertyName, () =>
            {
                corn.Size = size;
            });
        }
    }
}