using System;
class myException
{
    public static void Main(string[] args)
    {
        try
        {
            int a = 10;
            int b = 0;
            int div = a/b;
            Console.WriteLine("Division of a and b is:"+div);
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
    }
}