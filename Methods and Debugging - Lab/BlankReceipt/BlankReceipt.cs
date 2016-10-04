using System;

namespace BlankReceipt
{
    public class BlankReceipt
    {
         public static void Main()
        {
            PrintRaceiptHeader();
            PrintRaceiptBody();
            PrintRaceeeeeeeeiptFootee();

        }

        private static void PrintRaceeeeeeeeiptFootee()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

        private static void PrintRaceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void PrintRaceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
