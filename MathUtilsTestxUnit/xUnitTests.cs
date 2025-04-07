using MathUtils;
namespace MathUtilsTestxUnit
{
    public class xUnitTests
    {
        [Fact]
        public void TestAdd()
        {
            var mo = new MathOperations();
            Assert.Equal(3, mo.Add(1, 2));
        }
        [Fact]
        public void TestSubtract()
        {
            var mo = new MathOperations();
            Assert.Equal(2, mo.Subtract(4, 2));
        }
        [Fact]
        public void ForceFail()
        {
            var mo = new MathOperations();
            Assert.Equal(2, mo.Subtract(5, 2));
        }
    }
}
