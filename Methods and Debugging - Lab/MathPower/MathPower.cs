using System;

namespace MathPower
{
    public class MathPower
    {
        public static void Main()
        {
            var num = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());
            var res = GetResult(num,power);
            Console.WriteLine(res);
        }

        private static object GetResult(double n, int p)
        {
           return Math.Pow(n, p);
        }
    }
}
