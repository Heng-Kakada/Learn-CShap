namespace _06Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[] favNums = new int[3];
        favNums[0] = 1;
        Console.WriteLine("favNum 0 : {0}", favNums[0]);

        string[] name = new[] { "bob", "davin", "piko" };
        //string[] name = { "bob", "davin", "piko" };

        var employees = new[] { "miky", "vila", "vida" };

        object[] randType = { "kiko", 1, 344.42 };

        Console.WriteLine("Object Array Length : {0}", randType.Length);

        Console.WriteLine("--------------- Multi Dimention Array ----------------");

        string[,] custName = new string[2, 2] {
            { "bob","osca" },
            {"miky", "tommy" }
        };

        Console.WriteLine("Length : {0}", custName.GetLength(0) );
        Console.WriteLine("Length : {0}", custName.Length );

        Console.WriteLine("MD Value : {0}", custName.GetValue(0, 0));

        for(int i = 0; i < custName.GetLength(0); i++)
        {
            for(int j = 0; j < custName.GetLength(0); j++)
            {
                Console.WriteLine("{0}, ", custName.GetValue(i, j));
            }
        }



    }
}

