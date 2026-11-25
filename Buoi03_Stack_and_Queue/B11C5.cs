using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B11C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 11: QUẢN LÝ DỊCH VỤ KHÁCH HÀNG NGÂN HÀNG ---");
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("\n=== QUẦY GIAO DỊCH NGÂN HÀNG ===");
                Console.WriteLine("1. Khách hàng mới lấy số (Xếp hàng)");
                Console.WriteLine("2. Mời số tiếp theo vào quầy (Phục vụ)");
                Console.WriteLine("3. Hiển thị các khách hàng đang chờ");
                Console.WriteLine("0. Quay lại Menu chính");
                int chon = hamhotro.DocSo("Chọn", 1);

                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        string name = hamhotro.DocChuoi("Nhập tên khách hàng", "Vũ Văn Long");
                        queue.Enqueue(name);
                        Console.WriteLine($" -> Khách hàng '{name}' đã nhận số thứ tự thành công.");
                        break;
                    case 2:
                        if (queue.Count > 0)
                        {
                            Console.WriteLine(" -> ĐANG PHỤC VỤ khách hàng: " + queue.Dequeue() + " ... Giao dịch hoàn tất!");
                        }
                        else Console.WriteLine(" -> Hiện không có khách hàng nào đang đợi!");
                        break;
                    case 3:
                        Console.Write(" -> Danh sách khách hàng xếp hàng: ");
                        if (queue.Count == 0) Console.Write("(Trống)");
                        foreach (var k in queue) Console.Write(k + " | ");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
