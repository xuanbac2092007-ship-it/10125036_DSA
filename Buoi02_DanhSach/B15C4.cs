using System;

namespace Buoi02_DanhSach
{
    static class B15C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 15: PHÁT HIỆN CHU TRÌNH (RÙA VÀ THỎ) ---");
            Node head = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            head.Next = n2;
            n2.Next = n3;
            n3.Next = n2; 

            
            Node rua = head, tho = head;
            bool coChuTrinh = false;

            while (tho != null && tho.Next != null)
            {
                rua = rua.Next;
                tho = tho.Next.Next;
                if (rua == tho)
                {
                    coChuTrinh = true;
                    break;
                }
            }

            Console.WriteLine(coChuTrinh ? "-> Phat hien chu trinh trong danh sach!" : "-> Danh sach an toan, khong co chu trinh.");
        }
    }
}
