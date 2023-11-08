using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input Name : ");
        string? name = Console.ReadLine();
        Console.Write("Input Age : ");
        int? age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("name : " + name);
        Console.WriteLine("age : " + age);

    }
}

