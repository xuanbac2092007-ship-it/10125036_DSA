using System;

namespace Buoi02_DanhSach
{
    static class B4C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI TẬP 4: DSLKD SỐ NGUYÊN DƯƠNG ---");
            Node pHead = null;

            int[] mau = { 5, 12, 5, 3, 9 }; 
            int n = hamhotro.DocSo("Nhap so phan tu DSLKD", 5);

            for (int i = 0; i < n; i++)
            {
                int gtMacDinh = i < mau.Length ? mau[i] : i + 1;
                int val = hamhotro.DocSo("Nhap phan tu thu " + (i + 1), gtMacDinh);
                pHead = hamhotro.ThemCuoi(pHead, val); 
            }

            Console.Write("Danh sach lien ket don: ");
            hamhotro.InDSLK(pHead); 

            int x = hamhotro.DocSo("a. Nhap x can dem", 5);
            int demX = 0;
            int minDuong = int.MaxValue;

            Node p = pHead;
            while (p != null)
            {
                if (p.Data == x)
                    demX++;
                if (p.Data > 0 && p.Data < minDuong)
                    minDuong = p.Data;
                p = p.Next;
            }

            Console.WriteLine("-> So phan tu bang " + x + ": " + demX);

            if (minDuong == int.MaxValue)
                Console.WriteLine("b. Khong co so duong!");
            else
                Console.WriteLine("b. Phan tu duong nho nhat: " + minDuong);

            int xXoa = hamhotro.DocSo("c. Nhap x can xoa dau tien", 5);
            pHead = hamhotro.XoaDauTien(pHead, xXoa); 

            Console.Write("Danh sach sau khi xoa: ");
            hamhotro.InDSLK(pHead); 
        }
    }
}
