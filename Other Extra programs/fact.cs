//C# program to finthe factorial of a number
using System;
class fact
{
    static void Main(String[] args)
    {
        int n,fact,i;
        Console.WriteLine("Enter the values for n\n");
        n=int.Parse(Console.ReadLine());
          fact=1;
        for(i=n;i>=n;i--)
        {
          
            fact=fact*(i);
        }
        Console.WriteLine("{0}",fact);
    }
}