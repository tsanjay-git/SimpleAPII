using System;
using Xunit;
using SimpleAPII.Controllers;

namespace SimpleAPII.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
    ValuesController controller = new ValuesController();[Fact]
    public void GetReturnsCorrectNumber()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("Sanjay Kumar Tiwary", returnValue.Value);
    }
    }
}
