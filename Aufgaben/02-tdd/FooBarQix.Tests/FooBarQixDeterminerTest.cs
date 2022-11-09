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

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        public void Determine_TestDivisibleBy3And5_ReturnBar(int number)
        {
            var foobarqix = new FooBarQixDeterminer();
            Assert.Equal("FooBar", foobarqix.Determine(number));
        }

        [Theory]
        [InlineData(21)]
        [InlineData(42)]
        [InlineData(63)]
        public void Determine_TestDivisibleBy3And7_ReturnBar(int number)
        {
            var foobarqix = new FooBarQixDeterminer();
            Assert.Equal("FooQix", foobarqix.Determine(number));
        }

        [Theory]
        [InlineData(105)]
        [InlineData(210)]
        [InlineData(420)]
        public void Determine_TestDivisibleBy357_ReturnBar(int number)
        {
            var foobarqix = new FooBarQixDeterminer();
            Assert.Equal("FooBarQix", foobarqix.Determine(number));
        }


    }
}