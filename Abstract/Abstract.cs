using System;
class Program
{
    public abstract class shape
    {
        public abstract void draw();
    }
    public class rectangle:shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing rectangle");
        }
    }
    public static void Main(string[] args)
    {
        rectangle r = new rectangle();
        r.draw();
    }
}