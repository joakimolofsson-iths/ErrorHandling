using System.Diagnostics.CodeAnalysis;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type two numbers:");
            int numOne = Int32.Parse(Console.ReadLine());
            int numTwo = Int32.Parse(Console.ReadLine());

            try
            {
                double result = DivisionOfTwoNumbers(numOne, numTwo);
                Console.WriteLine(result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static double DivisionOfTwoNumbers(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            double sum = (double)dividend / divisor;
            return sum;
        }
    }
}
