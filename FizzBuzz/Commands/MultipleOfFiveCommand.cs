using FizzBuzz.Interfaces;

namespace FizzBuzz.Commands;

public class MultipleOfFiveCommand : IFizzBuzzCommand
{
    public string Execute(int t)
    {
        return "Buzz";
    }

    public bool IsHandled(int t)
    {
        return t % 5 == 0;
    }
}
