using FizzBuzz.Interfaces;

namespace FizzBuzz.Commands;

public class MultipleOfThreeCommand : IFizzBuzzCommand
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
