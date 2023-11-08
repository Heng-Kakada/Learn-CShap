namespace _05StringFunction;

class Program
{
    static void Main(string[] args)
    {
        string randString = "This is a string";

        Console.WriteLine("String Length : {0}", randString.Length);
        Console.WriteLine("String Contain : {0}", randString.Contains("is"));
        Console.WriteLine("String Index is : {0}", randString.IndexOf("is"));
        Console.WriteLine("String Remove : {0}", randString.Remove(10, 6));
        Console.WriteLine("String Insert : {0}", randString.Insert(9,"short"));
        Console.WriteLine("String Replace : {0}", randString.Replace("string", "sentence"));
        Console.WriteLine("String Compare A to B : {0}", String.Compare("B", "B", StringComparison.OrdinalIgnoreCase)); //  (=) result 0, (>) result 1, (<) result -1

        Console.WriteLine("------------------ Format ---------------");
        Console.WriteLine("pad left : {0}", randString.PadLeft(20, '.'));
        Console.WriteLine("pad right : {0}", randString.PadRight(30, '.'));
        Console.WriteLine("Trim : {0}", randString.Trim()) ;
        Console.WriteLine("toUpper : {0}", randString.ToUpper() );
        Console.WriteLine("toLower : {0}", randString.ToLower());

        Console.WriteLine("------------------ Verbatim Strings ---------------");
        Console.WriteLine(@"What I type \n");


    }
}

