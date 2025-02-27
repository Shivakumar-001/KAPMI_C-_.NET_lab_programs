//C# program to accept series of random numbers and print the same
using System;
class elementArray
{
    static void Main(String[] args)
    {
        int i,n;
        int[] a=new int[20];
        Console.WriteLine("How many elements?");
        n=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the elements\n");
        for(i=0;i<n;i++)
        {
            a[i]=int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Entered elements are:\n");
        for(i=0;i<n;i++)
        {
            Console.WriteLine(a[i]+"\t");
        }
    }
}