using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Character:");
        char vowel=char.Parse(Console.ReadLine());
        switch(vowel)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':  
            case 'u':Console.WriteLine("The entered character is Vowel");break;
            default:Console.WriteLine("The entered character is Consonant");break;
        }
        Console.ReadLine();
    }
}