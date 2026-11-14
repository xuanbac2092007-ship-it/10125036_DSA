using System;

namespace BTTH1
{
    static class B1C1
    {
        public static void Run()
        {
            int[] a = hamhotro.TaoMangNgauNhien(1000, 500);

            Console.WriteLine("Mang vua tao:");
            hamhotro.InMang(a);

            int lonNhat = a[0];
            int nhoNhat = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > lonNhat)
                    lonNhat = a[i];

                if (a[i] < nhoNhat)
                    nhoNhat = a[i];
            }

            Console.WriteLine("So lon nhat: " + lonNhat);
            Console.WriteLine("So nho nhat: " + nhoNhat);
        }
    }
}