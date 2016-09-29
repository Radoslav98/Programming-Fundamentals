using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            int sum = 0;
            string num = i.ToString();
            for (int j = 0; j < num.Length; j++)
            {
                sum += int.Parse(num[j].ToString());
            }
            bool special = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine("{0} -> {1}", i, special);
        }
    }
}
