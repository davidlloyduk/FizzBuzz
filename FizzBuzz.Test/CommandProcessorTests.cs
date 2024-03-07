using FluentAssertions;

namespace FizzBuzz.Test;

[TestFixture]
public class CommandProcessorTests
{
    [Test]
    public void Given_Process_called_Then_successfully_Processes()
    {
        //arrange
        var commandsGenerator = new FizzBuzzCommandsGenerator(); 
        var commandProcessor = new FizzBuzzCommandProcessor(commandsGenerator);
        var numbers = Enumerable.Range(1, 101);

        //act
        Action act = () => commandProcessor.Process(numbers);

        //assert
        act.Should().NotThrow();
        
    }
}
