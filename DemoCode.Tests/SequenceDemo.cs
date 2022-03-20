using AutoFixture;
using System.Collections.Generic;
using Xunit;

namespace DemoCode.Tests
{
    public class SequenceDemo
    {
        [Fact]
        public void SequenceOfStrings()
        {
            var fixture = new Fixture();

            IEnumerable<string> messages = fixture.CreateMany<string>();
        }

        [Fact]
        public void ExplicitNumberOfItems()
        {
            var fixture = new Fixture();

            IEnumerable<int> numbers = fixture.CreateMany<int>(600);
        }

        [Fact]
        public void AddingToExistingList()
        {
            var fixture = new Fixture();
            var sut = new DebugMessageBuffer();

            fixture.AddManyTo(sut.Messages, 10);
            

            //act

            sut.WriteMessages();

            Assert.Equal(10, sut.MessagesWritten);


        }
    }
}
