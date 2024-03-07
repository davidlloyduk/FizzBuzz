using FizzBuzz.Interfaces;

namespace FizzBuzz.Commands;

public class NumberCommand : IFizzBuzzCommand
{
    public string Execute(int t)
    {
        return t.ToString();
    }

    public bool IsHandled(int t)
    {
        return true;
    }
}
