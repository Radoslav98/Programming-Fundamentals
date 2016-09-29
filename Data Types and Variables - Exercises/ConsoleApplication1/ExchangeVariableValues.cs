using System;

    public class ExchangeVariableValues
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);

            int c = b;
            b = a;
            a = c;
            Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
        }
    }
