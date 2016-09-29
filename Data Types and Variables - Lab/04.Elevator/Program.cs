using System;

    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());
            int courses = (int)(Math.Ceiling((double)n / p));
            Console.WriteLine(courses);
        }
    }