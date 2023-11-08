namespace _14PassByReference
{
    internal class Program
    {

        // change outside and inside function 

        private static void Swap(ref int num1, ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }



        static void Main(string[] args)
        {
            int num3 = 10;
            int num4 = 20;


            Console.WriteLine("Before Swap num1 : {0} num2 {1}",num3,num4);
            Swap(ref num3,ref num4);
            Console.WriteLine("After Swap num1 : {0} num2 {1}", num3, num4);


        }
    }
}