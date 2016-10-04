using System;

public class PrintingTriangle
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintHeader(n);
        PrintBody(n);
        PrintHeader(n);
        
    }

     static void PrintHeader(int n)
    {
        Console.WriteLine("{0}", new string('-', n * 2));
    }

     static void PrintBody(int n)
    {
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("-");
            for (int row = 0; row < n - 1; row++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
    }
}
