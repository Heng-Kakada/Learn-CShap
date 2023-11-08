namespace _09Random;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int secreteNum = rnd.Next(1, 11);
        int numberGuessed = 0;

        do
        {
            Console.Write("Guess Number : ");
            numberGuessed = Convert.ToInt32(Console.ReadLine());


        } while (secreteNum != numberGuessed);

        Console.WriteLine("Congratuation You Guess a correct number : {0}", secreteNum);

    }
}

