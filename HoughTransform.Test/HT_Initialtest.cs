using Xunit;
using HoughTransform;

namespace HoughTransform.UnitTests.Services
{
    public class HoughTransform_HelloWorld
    {
        private readonly Print _core;

        public HoughTransform_HelloWorld()
        {
            _core = new Print();
        }

        [Fact]
        public void HelloWorldTest()
        {
            
            var result = _core.PrintHelloWorld();

            Assert.True(result == "Hello World!", "Wrong string");
        }
    }
}