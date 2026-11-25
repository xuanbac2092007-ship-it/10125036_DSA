using System;

namespace Buoi02_DanhSach
{
    static class B18C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 18: QUẢN LÝ ĐƠN HÀNG DANH SÁCH KÉP ---");
            NodeKep don1 = new NodeKep("Don_Hang_01: Cho xu ly");
            NodeKep don2 = new NodeKep("Don_Hang_01: Dang giao");
            don1.Next = don2;
            don2.Prev = don1;

            NodeKep current = don1;
            Console.WriteLine("Trang thai hien tai: " + current.Data);
            if (current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Chuyen trang thai tiep theo -> " + current.Data);
            }
        }
    }
}
