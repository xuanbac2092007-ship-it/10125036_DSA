using System;

namespace Buoi02_DanhSach
{
    static class B7C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 7: QUẢN LÝ NHIỆT ĐỘ ---");
            int n = hamhotro.DocSo("Nhap so ngay", 7);
            int[] temp = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                temp[i] = hamhotro.DocSo($"Nhiet do ngay {i + 1}", 25 + i % 3);
                sum += temp[i];
            }

            int max = temp[0], min = temp[0];
            foreach (int t in temp)
            {
                if (t > max) max = t;
                if (t < min) min = t;
            }

            Console.WriteLine($"Nhiet do cao nhat: {max}°C");
            Console.WriteLine($"Nhiet do thap nhat: {min}°C");
            Console.WriteLine($"Nhiet do trung binh tuan: {(double)sum / n:F2}°C");
        }
    }
}
