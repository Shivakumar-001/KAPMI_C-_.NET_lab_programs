using System;
public class p{}
public class p1: p{}
public class p2{}
public class GFG
{
    public static void Main(String[] args)
    {
        p o1 = new p();
        p1 o2 = new p1();
        Console.WriteLine(o1 is p);
        Console.WriteLine(o1 is object);
        Console.WriteLine(o2 is p1);
        Console.WriteLine(o1 is object);
        Console.WriteLine(o2 is p1);
        Console.WriteLine(o1 is p2);
        Console.WriteLine(o2 is p2);

    }
}

/* output

True
True
True
True
True
False
False

*/