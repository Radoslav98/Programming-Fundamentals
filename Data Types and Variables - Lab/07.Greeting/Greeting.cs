using System;


namespace Greeting
{
    public class Greeting
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello , {0} {1}. You are {2} years old.",firstName,secondName,age);
        }
    }
}
