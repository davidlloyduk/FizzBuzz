using FizzBuzz.Interfaces;

namespace FizzBuzz.Commands;

public class MultipleOfThreeCommand : IFizzBuzzCommand
{
    public string Execute()
    {
        return "Fizz";
    }

    public bool IsHandled(int t)
    {
        return t % 3 == 0 && !(t % 5 == 0);
    }
}
