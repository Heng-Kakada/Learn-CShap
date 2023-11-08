namespace _12Functions
{
    internal class Program
    {
        // avoid of repeating code

        // <Access Specifier> <Return Type> <Method Name> ( [Parameters] ) 
        // { body }


        // Access Specifier determine whether the can be called from another class
        // public : Can be accessed from another class
        // private : Can't be accessed from another class
        // protected : Can be accessed by class and Derived class


        // Function

        private static void SayHello()
        {
            Console.WriteLine("Hello");
            Console.Write("What is Your name ? ");
            var name = Console.ReadLine();

            Console.WriteLine("Your name is : {0} Right ! ",name);

        }

        // End Function

        private static double GetSum(double x = 1, double y = 1) {
            return x + y;
        }


        static void Main(string[] args)
        {
            SayHello();
            Console.WriteLine(GetSum());
            Console.WriteLine(GetSum(2,5));
        }
    }
}