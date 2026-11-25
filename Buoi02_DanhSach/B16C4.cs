using System;

namespace Buoi02_DanhSach
{
    static class B16C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 16: LỊCH SỬ DUYỆT WEB DANH SÁCH KÉP ---");
            NodeKep trang1 = new NodeKep("Google.com");
            NodeKep trang2 = new NodeKep("Github.com");
            trang1.Next = trang2;
            trang2.Prev = trang1;

            NodeKep current = trang2;
            Console.WriteLine("Trang hien tai: " + current.Data);
            if (current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Nhan nut BACK -> " + current.Data);
            }
        }
    }
}
