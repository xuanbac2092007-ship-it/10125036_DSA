using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B4C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 4: MÔ PHỎNG HỆ THỐNG IN ẤN (CƠ BẢN) ---");
            Queue<string> printQueue = new Queue<string>();

            Console.WriteLine("Thêm tài liệu vào hàng đợi: BaoCao.pdf");
            printQueue.Enqueue("BaoCao.pdf");

            Console.WriteLine("Thêm tài liệu vào hàng đợi: HinhAnh.png");
            printQueue.Enqueue("HinhAnh.png");

            Console.WriteLine("Thêm tài liệu vào hàng đợi: BaiTap.docx");
            printQueue.Enqueue("BaiTap.docx");

            Console.WriteLine("\nBắt đầu in theo nguyên lý FIFO (First In First Out):");
            while (printQueue.Count > 0)
            {
                string doc = printQueue.Dequeue();
                Console.WriteLine(" -> Đang in: " + doc + " ... Hoàn thành!");
            }
        }
    }
}
