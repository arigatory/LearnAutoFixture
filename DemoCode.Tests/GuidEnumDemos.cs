using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoCode.Tests
{
    public class GuidEnumDemos
    {

        [Fact]
        public void Guid()
        {
            var fixture = new Fixture();
            var sut = new EmailMessage(fixture.Create<string>(),
                fixture.Create<string>(),
                fixture.Create<bool>());

            sut.Id = fixture.Create<Guid>();

            sut.MessageType = fixture.Create<EmailMessageType>();



        }
    }
}
