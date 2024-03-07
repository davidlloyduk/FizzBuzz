using FizzBuzz.Commands;
using FluentAssertions;

namespace FizzBuzz.Test
{
    [TestFixture]
    public class MultipleOfThreeAndFiveCommandTests
    {
        [Test]
        public void Given_Execute_called_Then_prints_Fizzbuzz()
        {
            //arrange
            var command = new MultipleOfThreeAndFiveCommand();

            //act
            var result = command.Execute();

            //assert
            result.Should().Be("Fizzbuzz");
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        [TestCase(60)]
        [TestCase(75)]
        public void Given_IsHandled_called_Then_returns_True(int value)
        {
            //arrange
            var command = new MultipleOfThreeAndFiveCommand();

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
            var command = new MultipleOfThreeAndFiveCommand();

            //act
            var result = command.IsHandled(value);

            //assert
            result.Should().BeFalse();
        }
    }
}