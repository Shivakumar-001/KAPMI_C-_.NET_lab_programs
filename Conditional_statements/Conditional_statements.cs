using System;
class Conditional_statements
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int n=int.Parse(Console.ReadLine());
        if(n%2==0)
        {
            Console.WriteLine("The number is Even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}