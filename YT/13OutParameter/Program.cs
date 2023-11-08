namespace _13OutParameter
{




    internal class Program
    {

        // Function

        private static void DoubleIt(int x, out double result)
        {
            result = x * 2;
        }

        // End Function


        static void Main(string[] args)
        {
            double mul;

            DoubleIt(9, out mul);

            Console.WriteLine("9 * 2 = {0}", mul);

        }
    }
}