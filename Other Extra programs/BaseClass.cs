using System;
public class Animal
{
    public string color ="white";
}
public class Dog: Animal
{
    String color = "black";
    public void showColor()
    {
        Console.WriteLine(base.color);
        Console.WriteLine(color);
    }
}
public class TestBase
{
    public static void Main(String[] args)
    {
        Dog d = new Dog();
        d.showColor();
    }
}

/* output
white
black
*/