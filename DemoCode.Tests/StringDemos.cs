using System;
using Xunit;
using AutoFixture;

namespace DemoCode.Tests
{
    public class StringDemos
    {
        [Fact]
        public void BasicStrings()
        {
            // arrange
            var fixture = new Fixture();
            var sut = new NameJoiner();

            var firstNmae = fixture.Create("First_");
            var lastNmae = fixture.Create("Last_");

            // act
            var result = sut.Join(firstNmae, lastNmae);

            // assert
            Assert.Equal(firstNmae+ ' '+ lastNmae, result);

        }
    }
}
