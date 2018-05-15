using Xunit;
using HoughTransform;

namespace HoughTransform.UnitTests.Services
{
    public class HoughTransform_HelloWorld
    {
        private readonly Program _prog;

        public HoughTransform_HelloWorld()
        {
            _prog = new Program();
        }

        [Fact]
        public void HelloWorldTest()
        {
            string[] args = string{"a"};
            var result = _prog.Main();

            Assert.False(result, "1 should not be prime");
        }
    }
}