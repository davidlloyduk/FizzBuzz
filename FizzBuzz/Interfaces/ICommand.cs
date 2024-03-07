namespace FizzBuzz.Interfaces;

public interface ICommand<in T>
{
    bool IsHandled(T t);

    string Execute();
}
