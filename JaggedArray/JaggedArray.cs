using System;
class Program
{
    public static void Main(string[] args)
    {
        int[][] jaggedArray = new int[3][]
        {
            new int[] {1,2,3},
            new int[] {4,5,6},
            new int[] {7,8,9},
        };
        int sum=0;
        foreach(int[] innerArray in jaggedArray)
        {
            foreach(int element in innerArray)
            {
                sum+=element;
            }
        }
        Console.WriteLine("The sum of all elements in the jagged Array is:"+sum);
        Console.ReadLine();
    }
}