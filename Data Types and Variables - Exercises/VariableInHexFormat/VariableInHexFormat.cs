using System;

    public class VariableInHexFormat
    {
        public static void Main()
        {
            string variableHex = Console.ReadLine();
            var num = Convert.ToInt32(variableHex, 16);
            Console.WriteLine(num);
        }
    }

