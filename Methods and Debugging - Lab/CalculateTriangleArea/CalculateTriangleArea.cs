using System;

namespace CalculateTriangleArea
{
    public class CalculateTriangleArea
    {
        public static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var area = GetTriangleArea(a, b);
            Console.WriteLine(area);
        }

        private static object GetTriangleArea(double a, double b)
        {
            return a * b / 2;
        }

        
    }
}
