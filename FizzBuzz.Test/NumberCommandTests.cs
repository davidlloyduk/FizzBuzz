using FizzBuzz.Commands;
using FluentAssertions;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class NumberCommandTests
    {
        [Test]
        public void Given_Execute_called_Then_prints_number()
        {
            //arrange
            var command = new NumberCommand();

            //act
            var result = command.Execute(5);

            //assert
            result.Should().Be("5");
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(9)]
        [TestCase(10)]
        [TestCase(25)]
        [TestCase(50)]
        [TestCase(75)]
        [TestCase(99)]
        [TestCase(100)]
        public void Given_IsHandled_called_Then_returns_True(int value)
        {
            //arrange
            var command = new NumberCommand();

            //act
            var result = command.IsHandled(value);

            //assert
            result.Should().BeTrue();
        }
    }
}