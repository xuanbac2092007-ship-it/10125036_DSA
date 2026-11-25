using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B6C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 6: QUẢN LÝ HÀNG ĐỢI DỊCH VỤ / NGÂN HÀNG (CƠ BẢN) ---");
            Queue<string> customers = new Queue<string>();

            Console.WriteLine("Khách hàng Nguyễn Văn A vào hàng đợi.");
            customers.Enqueue("Nguyễn Văn A");

            Console.WriteLine("Khách hàng Trần Thị B vào hàng đợi.");
            customers.Enqueue("Trần Thị B");

            Console.WriteLine("Khách hàng Lê Văn C vào hàng đợi.");
            customers.Enqueue("Lê Văn C");

            Console.WriteLine("\nBắt đầu gọi phục vụ theo lượt xếp hàng:");
            while (customers.Count > 0)
            {
                string client = customers.Dequeue();
                Console.WriteLine(" -> Mời khách hàng: " + client + " vào quầy phục vụ... Xong!");
            }
        }
    }
}
