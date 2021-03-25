using System;
using System.Collections.Generic;

namespace ISBN_Check_digit
{
    class Program
    {
        public static int GetSumISBN(int[] ISBN)
        {
            if (ISBN.Length == 10)
                return Count10ISBN(ISBN);
            else if (ISBN.Length == 13)
                return Count13ISBN(ISBN);
            else
                return 0;
        }
        private static int Count10ISBN(int[] ISBN)
        {
            int sum = 0;
            for (int i = 10; i > 0; i--)
            {
                sum += ISBN[10 - i] * i;
            }
            return sum;
        }
        private static int Count13ISBN(int[] ISBN)
        {
            int sum = 0;
            for (int i = 13; i > 0; i--)
            {
                if (i % 2 != 0)
                    sum += ISBN[13 - i];
                else
                    sum += ISBN[13 - i] * 3;
            }
            return sum;
        }
        public static int[] ConvertDigits(string ISBN)
        {
            int[] array = new int[ISBN.Length];
            for (int i = 0; i < ISBN.Length; i++)
            {
                if (ISBN[i] == 'X')
                    array[i] = 10;
                else
                    array[i] = int.Parse($"{ISBN[i]}");
            }
            return array;
        }
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<string> invalid = new List<string>();
            for (int i = 0; i < N; i++)
            {
                string ISBN = Console.ReadLine();
                if (ISBN.Contains('_'))
                {
                    invalid.Add(ISBN);
                }
                else
                {
                    int isbn = GetSumISBN(ConvertDigits(ISBN));
                    if (ISBN.Length == 10 && isbn % 11 != 0)
                        invalid.Add(ISBN);
                    else if (ISBN.Length == 13 && isbn % 10 != 0)
                        invalid.Add(ISBN);
                    else if (ISBN.Length != 13 && ISBN.Length != 10)
                        invalid.Add(ISBN);
                }
            }

            Console.WriteLine($"{invalid.Count} invalid:");
            foreach (var a in invalid)
                Console.WriteLine(a);
        }
    }
}
