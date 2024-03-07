using FizzBuzz.Interfaces;
namespace FizzBuzz;

public class FizzBuzzCommandProcessor : IFizzBuzzCommandProcessor
{
    private readonly IFizzBuzzCommandsGenerator _commandsGenerator = new FizzBuzzCommandsGenerator();
    private readonly IEnumerable<IFizzBuzzCommand> _commands;

    public FizzBuzzCommandProcessor(IFizzBuzzCommandsGenerator commandsGenerator)
    {
        _commandsGenerator = commandsGenerator;
        _commands = _commandsGenerator.GetCommands();
    }

    public void Process(IEnumerable<int> numbers)
    {
        numbers.ToList().ForEach(Process);
    }

    public void Process(int number)
    {
        var commands = _commands.Where(x => x.IsHandled(number));

        if(commands.Any())
        {
            commands.ToList().ForEach(command => Console.Write(command.Execute()));
        }
        else
        {
            Console.Write(number.ToString());
        }
        
        Console.Write(Environment.NewLine);
    }
}
