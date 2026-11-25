using System;

namespace Buoi02_DanhSach
{
    static class B11C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 11: KIỂM TRA MA TRẬN ĐẶC BIỆT ---");
            int n = hamhotro.DocSo("Nhap cap n", 3);
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = hamhotro.DocSo($"Nhap [{i},{j}]", i == j ? 1 : 0);

            bool isDonVi = true;
            bool isDoiXung = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && matrix[i, j] != 1) isDonVi = false;
                    if (i != j && matrix[i, j] != 0) isDonVi = false;
                    if (matrix[i, j] != matrix[j, i]) isDoiXung = false;
                }
            }

            Console.WriteLine(isDonVi ? "-> Day la ma tran don vi!" : "-> Khong phai ma tran don vi.");
            Console.WriteLine(isDoiXung ? "-> Day la ma tran doi xung!" : "-> Khong phai ma tran doi xung.");
        }
    }
}
