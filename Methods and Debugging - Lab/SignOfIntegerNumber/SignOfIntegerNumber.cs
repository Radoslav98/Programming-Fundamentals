using System;

namespace SignOfIntegerNumber
{
    public class SignOfIntegerNumber
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else if ( number<0) 
            {
                Console.WriteLine("The number {0} is negative",number );
            }
            else
            {
                Console.WriteLine("The number {0} is zero", number);
            }
        }
    }
}
