namespace _03Casting;

class Program
{
    static void Main(string[] args)
    {

        bool boolFromString = bool.Parse("true");
        Console.WriteLine($"boolean convert from String {boolFromString.GetType()} ");

        int intFromString = int.Parse("168");
        Console.WriteLine($"int convert from String {intFromString.GetType()}");

        double doubleFromString = double.Parse("1.232");
        Console.WriteLine($"double convert from String {doubleFromString.GetType()}");

        string strValue = doubleFromString.ToString();
        Console.WriteLine($"double to String {strValue}");

        double doubleToint = 1.3423;
        Console.WriteLine($"Double Value to int {(int)doubleToint}");

        int num = 10;
        long numLong = num;

        Console.WriteLine(numLong);

    }
}

