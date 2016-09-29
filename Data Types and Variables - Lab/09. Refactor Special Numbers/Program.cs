using System;
    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0; int digit = 0;
            for (int i = 1; i <= num; i++)
            {
                digit = i;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }
                bool isToe = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}",digit,isToe);
                
            }

        }
    }