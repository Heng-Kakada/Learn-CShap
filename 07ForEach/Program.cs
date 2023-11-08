namespace _07ForEach;

class Program
{
    // start function

    static void printNum(int[] num , string mes)
    {
        foreach(int i in num)
        {
            Console.WriteLine("{0} : {1}", mes, i);
        }
    }

    // end function
    static void Main(string[] args)
    {
        int[] num = new int[] { 543,43,1,4 };

        printNum(num, "ForEach");


        Array.Sort(num);
        printNum(num, "Sort");

    }
}

