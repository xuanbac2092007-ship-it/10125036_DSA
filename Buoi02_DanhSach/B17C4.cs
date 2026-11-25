using System;

namespace Buoi02_DanhSach
{
    static class B17C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 17: PLAYLIST NHẠC DANH SÁCH KÉP ---");
            NodeKep bai1 = new NodeKep("Bai_Hat_A");
            NodeKep bai2 = new NodeKep("Bai_Hat_B");
            bai1.Next = bai2;
            bai2.Prev = bai1;

            NodeKep current = bai1;
            Console.WriteLine("Dang phat: " + current.Data);
            if (current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Nhan NEXT -> Dang phat: " + current.Data);
            }
        }
    }
}
