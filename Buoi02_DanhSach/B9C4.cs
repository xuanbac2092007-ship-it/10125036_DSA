using System;
using System.Collections.Generic;

namespace Buoi02_DanhSach
{
    static class B9C4
    {
        static bool KiemTraHoanHao(int n)
        {
            if (n < 2) return false;
            int sum = 1;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (i * i != n) sum += n / i;
                }
            }
            return sum == n;
        }

        public static void Run()
        {
            Console.WriteLine("--- BÀI 9: XỬ LÝ SỐ NGUYÊN ---");
            int n = hamhotro.DocSo("Nhap so phan tu", 5);
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(hamhotro.DocSo($"Nhap phan tu [{i}]", (i + 1) * 2 + 1));
            }

            Console.Write("Phan loai va thong ke:\n");
            foreach (int x in numbers)
            {
                string snt = hamhotro.KiemTraNguyenTo(x) ? "la SNT" : "khong la SNT";
                string chanle = x % 2 == 0 ? "so chan" : "so le";
                string hoanhao = KiemTraHoanHao(x) ? "la so hoan hao" : "khong la so hoan hao";
                Console.WriteLine($"   {x}: {chanle}, {snt}, {hoanhao}");
            }
        }
    }
}
