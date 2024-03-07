namespace FizzBuzz.Interfaces;

public interface IFizzBuzzCommandProcessor
{
    void Process(IEnumerable<int> numbers);

    void Process(int number);
}
