using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Unit_Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            for (long x = n + 1; x <= n * 2; x++)
            {
                long y = (n * x) / (x - n);
                if ((y + x) * n == x * y)
                    Console.WriteLine($"1/{n} = 1/{y} + 1/{x}");
            }
        }
    }
}
