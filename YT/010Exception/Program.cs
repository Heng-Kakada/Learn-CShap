namespace _010Exception;

class Program
{

    static double DoDivision(double x, double y)
    {
        if(y == 0) throw new DivideByZeroException() ;
        return x / y;  
    }



    static void Main(string[] args)
    {
        double num1 = 5;
        double num2 = 0;

        try
        {
            Console.WriteLine("5 / 0 = {0}", DoDivision(num1, num2));

        } catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.GetType().Name);
        } catch (Exception ex)
        {
            Console.WriteLine("Exception : ", ex.Message);
        }
        finally
        {
            Console.WriteLine("Clean up");
        }



    }
}

