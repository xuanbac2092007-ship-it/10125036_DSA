using System;

namespace Buoi02_DanhSach
{
    static class B1C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI TẬP 1: MẢNG SỐ NGUYÊN DƯƠNG ---");

            
            int n = hamhotro.DocSo("Nhap so phan tu n", 5);
            if (n <= 0) return;

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = hamhotro.DocSo("Nhap a[" + i + "]", (i + 1) * 3);
            }

            Console.Write("Danh sach phan tu: ");
            hamhotro.InMang(a); 

            int x = hamhotro.DocSo("Nhap phan tu x can chen", 99);
            int k = hamhotro.DocSo("Nhap vi tri k can chen", 2);

            if (k < 0 || k > n)
            {
                Console.WriteLine("Vi tri chen khong hop le!");
                return;
            }

            int[] tmp = new int[n + 1];
            for (int i = 0; i < k; i++)
                tmp[i] = a[i];

            tmp[k] = x;

            for (int i = k; i < n; i++)
                tmp[i + 1] = a[i];

            a = tmp;

            Console.Write("Mang sau khi chen: ");
            hamhotro.InMang(a);
        }
    }
}
