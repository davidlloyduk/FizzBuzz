using FizzBuzz.Interfaces;

namespace FizzBuzz;

public class CommandsGenerator : ICommandsGenerator
{
    public IEnumerable<IFizzBuzzCommand> GetCommands()
    {
        return Enumerable.Empty<IFizzBuzzCommand>();
    }
}