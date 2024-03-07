using FizzBuzz.Interfaces;

namespace FizzBuzz.Commands;

public class MultipleOfFiveCommand : IFizzBuzzCommand
{
    public string Execute(int t)
    {
        return string.Empty;
    }

    public bool IsHandled(int t)
    {
        return false;
    }
}
