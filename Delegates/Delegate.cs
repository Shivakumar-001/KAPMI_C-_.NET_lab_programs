using System;
class Program
{
    delegate double MathOperation(double a, double b);
    static void Main()
    {
        MathOperation add = Add;
        MathOperation sub = Subtract;
        MathOperation mul = Multiply;
        MathOperation div = Divide;

        double num1 = 10;
        double num2 = 5;

        Console.WriteLine(num1+"+"+num2+"="+Add(num1,num2));
        Console.WriteLine(num1+"-"+num2+"="+Subtract(num1,num2));   
        Console.WriteLine(num1+"*"+num2+"="+Multiply(num1,num2));
        Console.WriteLine(num1+"/"+num2+"="+Divide(num1,num2));
        Console.ReadLine();
    }
    static double Add(double a,double b)
    {
        return a+b;
    }
    static double Subtract(double a,double b)
    {
        return a-b;
    }
    static double Multiply(double a,double b)
    {
        return a*b;
    }  
    static double Divide(double a,double b)
    {
        return a/b;
    }
}