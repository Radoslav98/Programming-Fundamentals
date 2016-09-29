using System;

namespace PrintPartOfASCIITable
{
    public class PrintPartOfASCIITable
    {
        public static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int secound = int.Parse(Console.ReadLine());

            for (int i = first; i <= secound; i++)
            {
                Console.Write("{0} ", (char)i);
            }
        }
    }
}
