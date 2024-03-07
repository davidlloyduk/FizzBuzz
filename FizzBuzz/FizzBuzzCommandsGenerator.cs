using FizzBuzz.Interfaces;
using System.Reflection;

namespace FizzBuzz;

public class FizzBuzzCommandsGenerator : IFizzBuzzCommandsGenerator
{
    public IEnumerable<IFizzBuzzCommand> GetCommands()
    {
        return  Assembly.GetExecutingAssembly()
                        .GetExportedTypes()
                        .Where(t => typeof(IFizzBuzzCommand).IsAssignableFrom(t) && t.IsClass)
                        .Select(Activator.CreateInstance)
                        .Cast<IFizzBuzzCommand>();
    }
}