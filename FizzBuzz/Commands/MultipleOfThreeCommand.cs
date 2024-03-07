using FizzBuzz.Interfaces;

namespace FizzBuzz.Commands;

public class MultipleOfThreeCommand : IFizzBuzzCommand
{
    public string Execute(int t)
    {
        return "Fizz";
    }

    public bool IsHandled(int t)
    {
        return t % 3 == 0;
    }
}
