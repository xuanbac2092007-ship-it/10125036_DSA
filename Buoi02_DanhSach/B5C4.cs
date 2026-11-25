using System;

namespace Buoi02_DanhSach
{
    static class B5C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI TẬP 5: DSLKD SỐ NGUYÊN l ---");
            Node l = null;
            int[] mau = { -2, 7, 0, 11, -5, 7 }; 
            int n = hamhotro.DocSo("Nhap so phan tu danh sach l", 6);

            for (int i = 0; i < n; i++)
            {
                int gtMacDinh = i < mau.Length ? mau[i] : i;
                int val = hamhotro.DocSo("Nhap l[" + i + "]", gtMacDinh);
                l = hamhotro.ThemCuoi(l, val); 
            }

            Console.Write("Danh sach l: ");
            hamhotro.InDSLK(l); 

            if (l == null) return;

            int max = l.Data;
            int tong = 0;
            int demSNT = 0;
            int demAm = 0, dem0 = 0, demDuong = 0;
            int minDuong = int.MaxValue;

            Node p = l;
            while (p != null)
            {
                if (p.Data > max) max = p.Data;
                tong += p.Data;
                if (hamhotro.KiemTraNguyenTo(p.Data)) demSNT++; 

                if (p.Data < 0) demAm++;
                else if (p.Data == 0) dem0++;
                else demDuong++;

                if (p.Data > 0 && p.Data < minDuong)
                    minDuong = p.Data;

                p = p.Next;
            }

            Console.WriteLine("\na. Phan tu lon nhat: " + max);
            Console.WriteLine("b. Tong cac phan tu: " + tong);
            Console.WriteLine("c. So luong so nguyen to: " + demSNT);
            Console.WriteLine("d. So am: " + demAm + ", So bang 0: " + dem0 + ", So duong: " + demDuong);

            int x = hamhotro.DocSo("e. Nhap x can tim", 7);
            int demX = 0;
            p = l;
            while (p != null)
            {
                if (p.Data == x) demX++;
                p = p.Next;
            }
            Console.WriteLine("-> So phan tu bang " + x + ": " + demX);

            if (minDuong == int.MaxValue)
                Console.WriteLine("f. Khong co so duong!");
            else
                Console.WriteLine("f. Phan tu duong nho nhat: " + minDuong);
        }
    }
}
