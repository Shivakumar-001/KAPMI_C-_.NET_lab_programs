using System;

class Program
{
    public static void Main(string[] args)
    {
        const int NumberOfCandidates = 10;
        const double minHeight = 157.5;

        double[] Heights = new double[NumberOfCandidates];
        int ShortlistedCandidates = 0;

        for (int i = 0; i < NumberOfCandidates; i++)
        {
            Console.WriteLine("Enter the height of Candidate " + (i + 1) + " in cm:");

            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out Heights[i]))
                {
                    break; // Valid input, exit loop
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid numeric height.");
                }
            }
        }

        Console.WriteLine("The following candidates are shortlisted:");
        for (int i = 0; i < NumberOfCandidates; i++)
        {
            if (Heights[i] >= minHeight)
            {
                Console.WriteLine("Candidate " + (i + 1) + ": " + Heights[i] + " cm");
                ShortlistedCandidates++;
            }
        }

        Console.WriteLine("The total number of candidates shortlisted are: " + ShortlistedCandidates);
    }
}
