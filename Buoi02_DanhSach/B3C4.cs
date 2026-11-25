using System;

namespace Buoi02_DanhSach
{
    static class B3C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI TẬP 3: MA TRẬN VUÔNG ---");
            int n = hamhotro.DocSo("Nhap cap ma tran vuong n", 3); 
            if (n <= 0) return;

            int[,] a = new int[n, n];
            int dem = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = hamhotro.DocSo("Nhap a[" + i + "," + j + "]", dem++);
                }
            }

            Console.WriteLine("\nMa tran vua nhap:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int tong = 0;
            int minDuong = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tong += a[i, j];
                    if (a[i, j] > 0 && a[i, j] < minDuong)
                        minDuong = a[i, j];
                }
            }

            Console.WriteLine("\na. Tong cac phan tu: " + tong);
            if (minDuong == int.MaxValue)
                Console.WriteLine("b. Khong co so duong!");
            else
                Console.WriteLine("b. Gia tri duong nho nhat: " + minDuong);

            int tongCheoPhu = 0;
            for (int i = 0; i < n; i++)
            {
                tongCheoPhu += a[i, n - 1 - i];
            }
            Console.WriteLine("c. Tong duong cheo phu: " + tongCheoPhu);

            bool tangDan = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i, i] >= a[i + 1, i + 1])
                {
                    tangDan = false;
                    break;
                }
            }

            if (tangDan)
                Console.WriteLine("d. Duong cheo chinh tang dan");
            else
                Console.WriteLine("d. Duong cheo chinh khong tang dan");
        }
    }
}
