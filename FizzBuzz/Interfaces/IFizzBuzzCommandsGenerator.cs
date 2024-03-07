namespace FizzBuzz.Interfaces;

public interface IFizzBuzzCommandsGenerator
{
    IEnumerable<IFizzBuzzCommand> GetCommands();
}
