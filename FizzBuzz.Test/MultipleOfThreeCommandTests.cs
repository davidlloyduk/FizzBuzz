using FizzBuzz.Commands;
using FluentAssertions;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class MultipleOfThreeCommandTests
    {
        [Test]
        public void Given_Execute_called_Then_prints_Fizz()
        {
            //arrange
            var command = new MultipleOfThreeCommand();

            //act
            var result = command.Execute(3);

            //assert
            result.Should().Be("Fizz");
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(12)]
        [TestCase(18)]
        [TestCase(51)]
        [TestCase(72)]
        [TestCase(87)]
        [TestCase(99)]
        public void Given_IsHandled_called_Then_returns_True(int value)
        {
            //arrange
            var command = new MultipleOfThreeCommand();

            //act
            var result = command.IsHandled(value);

            //assert
            result.Should().BeTrue();
        }

        [TestCase(1)]
        [TestCase(8)]
        [TestCase(23)]
        [TestCase(55)]
        [TestCase(77)]
        [TestCase(98)]
        public void Given_IsHandled_called_Then_returns_False(int value)
        {
            //arrange
            var command = new MultipleOfThreeCommand();

            //act
            var result = command.IsHandled(value);

            //assert
            result.Should().BeFalse();
        }
    }
}