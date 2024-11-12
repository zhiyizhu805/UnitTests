using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FluentAssertions;
using NetworkUtility.Ping;
using Xunit;

namespace NetworkUtility.Tests.PingTests
{
    public class NetworkServiceTests
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        //Naming Convention - ClassName_MethodName_ExepctedResult
        {
            //Arrange - Go get your variables, whatever you need, you classes, go get functions
            var pingService = new NetworkService();

            //Act - Execute this function
            var result = pingService.Sending();
            
            //Assert - Whatever ever is returned is it what you want.
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping Sent!");
            result.Should().Contain("Success", Exactly.Once());
        }
    }
}