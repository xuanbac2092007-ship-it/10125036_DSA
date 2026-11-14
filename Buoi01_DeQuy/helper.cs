
using System;

namespace BTTH1
{
    static class hamhotro
    {
        public static Random Rnd = new Random();

        public static int[] TaoMangNgauNhien(int n, int max = 10000)
        {
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
                a[i] = Rnd.Next(0, max);

            return a;
        }

        public static void InMang(int[] a, int toiDa = 20)
        {
            int n = Math.Min(a.Length, toiDa);

            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");

            if (a.Length > n)
                Console.Write("... (" + a.Length + " phan tu)");

            Console.WriteLine();
        }

        public static void Swap(int[] a, int i, int j)
        {
            int t = a[i];
            a[i] = a[j];
            a[j] = t;
        }

        public static int DocSo(string loiNhac, int macDinh)
        {
            Console.Write($"{loiNhac} (Enter = {macDinh}): ");

            string s = Console.ReadLine();

            return int.TryParse(s, out int v) ? v : macDinh;
        }

        public static int TimMax(int[] a)
        {
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
                if (a[i] > max)
                    max = a[i];

            return max;
        }

        public static int TimMin(int[] a)
        {
            int min = a[0];

            for (int i = 1; i < a.Length; i++)
                if (a[i] < min)
                    min = a[i];

            return min;
        }

        public static int TongUoc(int n)
        {
            int tong = 0;

            for (int i = 1; i < n; i++)
                if (n % i == 0)
                    tong += i;

            return tong;
        }

        public static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        public static bool KiemTraHoanHao(int n)
        {
            return n > 1 && TongUoc(n) == n;
        }
    }
}
