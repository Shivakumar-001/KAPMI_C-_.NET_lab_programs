using System;
class Program
{
    public  static void Main(string[] args)
    {
        Hello();
        int sum=AddNumbers(5,7);
        Console.WriteLine("The sum of 5 and 7 is: "+sum);
        Console.ReadLine();
    }
    static void Hello()
    {
        Console.WriteLine("Hello,everyOne Welcome to the program");
    }
    static int AddNumbers(int a,int b)
    {
        return a+b;
    }
    
}