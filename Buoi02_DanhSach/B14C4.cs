using System;

namespace Buoi02_DanhSach
{
    static class B14C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 14: GỘP HAI DANH SÁCH ĐÃ SẮP XẾP ---");
            Node l1 = null, l2 = null;
            l1 = hamhotro.ThemCuoi(l1, 1); l1 = hamhotro.ThemCuoi(l1, 3);
            l2 = hamhotro.ThemCuoi(l2, 2); l2 = hamhotro.ThemCuoi(l2, 4);

            Console.Write("DS1: "); hamhotro.InDSLK(l1);
            Console.Write("DS2: "); hamhotro.InDSLK(l2);

            Node gop = Gop(l1, l2);
            Console.Write("DS sau khi gop tang dan: ");
            hamhotro.InDSLK(gop);
        }

        static Node Gop(Node a, Node b)
        {
            if (a == null) return b;
            if (b == null) return a;
            if (a.Data <= b.Data)
            {
                a.Next = Gop(a.Next, b);
                return a;
            }
            else
            {
                b.Next = Gop(a, b.Next);
                return b;
            }
        }
    }
}
