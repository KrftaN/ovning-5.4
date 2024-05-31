using System;

namespace övning_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = { "Anna", "Kalle", "Erik", "Maria", "Bertil" };

            string förstaNamn = namn[0];

            for (int i = 1; i < namn.Length; i++)
            {
                if (string.Compare(namn[i], förstaNamn, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    förstaNamn = namn[i];
                }
            }

            Console.WriteLine($"Namnet som kommer först i bokstavsordning är: {förstaNamn}");
        }
    }
}
