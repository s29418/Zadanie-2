namespace Zadanie_2;

public class OverfillException : Exception
{
    public OverfillException()
    {
        Console.WriteLine("Overfill. The load weight is greater than the capacity.");
    }
}