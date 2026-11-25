using System;

namespace Buoi02_DanhSach
{
    static class B13C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 13: ĐẢO NGƯỢC DANH SÁCH LIÊN KẾT ---");
            Node head = null;
            head = hamhotro.ThemCuoi(head, 1);
            head = hamhotro.ThemCuoi(head, 2);
            head = hamhotro.ThemCuoi(head, 3);

            Console.Write("Danh sach ban dau: ");
            hamhotro.InDSLK(head);

            
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;

            Console.Write("Danh sach sau khi dao nguoc: ");
            hamhotro.InDSLK(head);
        }
    }
}
