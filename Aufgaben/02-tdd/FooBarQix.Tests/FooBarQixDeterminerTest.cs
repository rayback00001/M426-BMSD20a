using Xunit;

namespace FooBarQix.Tests
{
    public class FooBarQixDeterminerTest
    {
        [Fact]
        public void Determine_WhenNumberNotDivisible()
        {
            var number = 1;
            var teste = new FooBarQixDeterminer();
            
            var result = teste.Determine(number);
         
            Assert.Equal("1", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void Determine_TestDivisibleBy5_ReturnBar(int number)
        {
            var foobarqix = new FooBarQixDeterminer();
            Assert.Equal("Bar", foobarqix.Determine(number));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void Determine_TestDivisibleBy3_ReturnBar(int number)
        {
            var foobarqix = new FooBarQixDeterminer();
            Assert.Equal("Foo", foobarqix.Determine(number));
        }

        [Theory]
        [InlineData(7)]
        [InlineData(14)]
        [InlineData(49)]
        public void Determine_TestDivisibleBy7_ReturnBar(int number)
        {
            var foobarqix = new FooBarQixDeterminer();
            Assert.Equal("Qix", foobarqix.Determine(number));
        }

       
    }
}