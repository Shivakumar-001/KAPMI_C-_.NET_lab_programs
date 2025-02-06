using System;
using System.Collections;
class Program
{
    public static void Main(string[] args)
    {
        IList mylist = new ArrayList();
        mylist.Add("kuvempu");
        mylist.Add("university");
        Console.WriteLine("Number of strings present in ArrayList: "+mylist.Count);
        Console.WriteLine("The values are:");
        print(mylist);
        Console.ReadLine();
    }
    static void print(IList mylist)
    {
        foreach(object obj in mylist)
        {
            Console.WriteLine(obj);
        }
    }
}