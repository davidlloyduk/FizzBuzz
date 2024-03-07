using FizzBuzz.Interfaces;

namespace FizzBuzz.Commands;

internal class NumberCommand : IFizzBuzzCommand
{
    public string Execute(int t)
    {
        return string.Empty;
    }

    public bool IsHandled(int t)
    {
        return true;
    }
}
