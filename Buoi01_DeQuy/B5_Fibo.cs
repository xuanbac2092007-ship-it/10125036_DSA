
using System;

namespace BTTH1
{
    static class B5_Fibo
    {
        static int FiboLap(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }
        static int FiboDeQuy(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return FiboDeQuy(n - 1) + FiboDeQuy(n - 2);
        }

        public static void Run()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0 || n > 40)
            {
                Console.WriteLine("Vui long nhap n tu 0 den 40!");
                return;
            }

            Console.WriteLine("Fibonacci bang vong lap: " + FiboLap(n));
            Console.WriteLine("Fibonacci bang de quy: " + FiboDeQuy(n));
        }
    }
}
