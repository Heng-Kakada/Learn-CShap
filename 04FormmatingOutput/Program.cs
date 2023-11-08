namespace _04FormmatingOutput;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("currency : {0:c}", 24.5);
        Console.WriteLine("pad with 0s : {0:d6}", 24);
        Console.WriteLine("3 Decimal : {0:f3}", 24.43232);
        Console.WriteLine("commas : {0:n4}", 24.3);

    }
}

