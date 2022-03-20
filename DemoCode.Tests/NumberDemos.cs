using System;
using Xunit;

namespace DemoCode.Tests
{
    public class NumberDemos
    {
        [Fact]
        public void Ints()
        {
            // Arrange
            var sut = new IntCalculator();

            // Act
            sut.Subtract(1);

            // Assert
            Assert.True(sut.Value < 0);
        }

    }
}
