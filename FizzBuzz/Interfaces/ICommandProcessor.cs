namespace FizzBuzz.Interfaces;

public interface ICommandProcessor
{
    void Process(IEnumerable<int> numbers);

    void Process(int number);
}
