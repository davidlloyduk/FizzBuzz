namespace FizzBuzz;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = Enumerable.Range(1, 100);

        var commandsGenerator = new FizzBuzzCommandsGenerator();
        var commandProcessor = new FizzBuzzCommandProcessor(commandsGenerator);
        commandProcessor.Process(numbers);
    }
}
