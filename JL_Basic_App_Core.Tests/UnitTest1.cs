using JL_Basic_App_GitHub;
using Xunit;


namespace JL_Basic_App_Core.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestNameProperty()
        {
            Class1 tp = new Class1();

            var result = tp.Name;

            Assert.Equal("[Jake Lewis] - The Code Master", result);
        }
    }
}