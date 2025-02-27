using System;
namespace Fundamental
{
    internal class exceptionExample
    {
        public static void Main(String[] args)
        {
            try
            {
            int a,b,c;
            Console.WriteLine("Enter a first Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a first Number");
            b = Convert.ToInt32(Console.ReadLine());
            c = a/b;
            Console.WriteLine(c);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Enter only Numeric Data");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Input Correct Data");
            }
        }
    }
}