using System;

class Program
{
    static void Main()
    {
        byte centuries = byte.Parse(Console.ReadLine());
        Console.WriteLine(centuries);
        int years = centuries * 100;
        Console.WriteLine(years);
        //TROPICAL YEAR HAS 365.2422 DAYS
        int days = (int)(years * 365.2422);
        Console.WriteLine(days);
        int hours = 24 * days;
        Console.WriteLine(hours);
        int mins = 60 * hours;
        Console.WriteLine(mins);






    }
}
