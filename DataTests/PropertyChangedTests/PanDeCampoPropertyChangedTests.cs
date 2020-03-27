using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        /// <summary>
        /// Ensures class implements INotifyChangedProperty
        /// </summary>
        [Fact]
        public void PanDeCampoShouldImplrementINotifyPropertyChanged()
        {
            var pan = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pan);
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
        public void PanDeCampoSizeChangeShouldNotifyPropertyChanged(Size size, string propertyName)
        {
            PanDeCampo pan = new PanDeCampo();
            Assert.PropertyChanged(pan, propertyName, () =>
            {
                pan.Size = size;
            });
        }
    }
}