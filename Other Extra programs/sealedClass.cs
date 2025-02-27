using System;
sealed class SealedClass{
    public int Add(int a,int b)
    {
        return a+b;
    }
}
class Program
{
    public static void Main(String[] args)
    {
        SealedClass slc = new SealedClass();
        int total = slc.Add(6,10);
        Console.WriteLine("Total="+total.ToString());
    }
}
//output: Total=16