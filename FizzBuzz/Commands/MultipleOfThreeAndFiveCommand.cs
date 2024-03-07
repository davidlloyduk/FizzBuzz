using FizzBuzz.Interfaces;

namespace FizzBuzz.Commands;

public class MultipleOfThreeAndFiveCommand : IFizzBuzzCommand
{
    public string Execute()
    {
        return "Fizzbuzz";
    }

    public bool IsHandled(int t)
    {
        return t % 3 == 0 && t % 5 == 0;
    }
}
