using System;

    public class BooleanVariable
    {
        public static void Main()
        {
            string boolean = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(boolean);
            Console.WriteLine(isTrue ? "Yes" : " No");
        }
    }
