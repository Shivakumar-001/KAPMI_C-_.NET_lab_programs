//C# program to find the entered number is odd or even
using System;
class oddEven
{
    static void Main(String[] args)
    {
        int n;
        Console.WriteLine("Enter a number\n");
        n=int.Parse(Console.ReadLine());
        if(n%2==0)
        {
            Console.WriteLine("The given number is Even\n");
        }
        else
        {
            Console.WriteLine("The given number is Odd\n");
        }
    }
}
/* OUTPUT 
Enter a number
5
The given number is odd
*/
