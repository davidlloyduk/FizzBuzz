using FizzBuzz.Commands;
using FluentAssertions;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class MultipleOfFiveCommandTests
    {
        [Test]
        public void Given_Execute_called_Then_prints_Buzz()
        {
            //arrange
            var command = new MultipleOfFiveCommand();

            //act
            var result = command.Execute(5);

            //assert
            result.Should().Be("Buzz");
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(25)]
        [TestCase(50)]
        [TestCase(75)]
        [TestCase(100)]
        public void Given_IsHandled_called_Then_returns_True(int value)
        {
            //arrange
            var command = new MultipleOfFiveCommand();

            //act
            var result = command.IsHandled(value);

            //assert
            result.Should().BeTrue();
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(9)]
        [TestCase(23)]
        [TestCase(52)]
        [TestCase(78)]
        [TestCase(99)]
        public void Given_IsHandled_called_Then_returns_False(int value)
        {
            //arrange
            var command = new MultipleOfFiveCommand();

            //act
            var result = command.IsHandled(value);

            //assert
            result.Should().BeFalse();
        }
    }
}