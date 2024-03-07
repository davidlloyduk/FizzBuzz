namespace FizzBuzz.Interfaces;

public interface ICommandsGenerator
{
    IEnumerable<IFizzBuzzCommand> GetCommands();
}
