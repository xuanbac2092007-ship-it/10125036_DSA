
using System;
using System.Text;

namespace Buoi03_Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            if (args.Length > 0)
            {
                string chonNhanh = args[0];
                Console.WriteLine("Chọn nhanh bài: " + chonNhanh);
                ChayBai(chonNhanh);
                return;
            }

            while (true)
            {
                Console.WriteLine("\n========== MENU BÀI TẬP BUỔI 03 (STACK & QUEUE) ==========");
                Console.WriteLine("1. Bài 1: Kiểm tra tính đúng đắn của biểu thức toán học");
                Console.WriteLine("2. Bài 2: Mô phỏng lịch sử trình duyệt web (Cơ bản)");
                Console.WriteLine("3. Bài 3: Mô phỏng quá trình thực thi chương trình (Call Stack)");
                Console.WriteLine("4. Bài 4: Mô phỏng hệ thống in ấn (Cơ bản)");
                Console.WriteLine("5. Bài 5: Mô phỏng đường truyền dữ liệu (Cơ bản)");
                Console.WriteLine("6. Bài 6: Mô phỏng quản lý hàng đợi dịch vụ/ngân hàng (Cơ bản)");
                Console.WriteLine("7. Bài 7: Mô phỏng lịch sử trình duyệt web nâng cao (Visit, Back, Forward)");
                Console.WriteLine("8. Bài 8: Kiểm tra chuỗi ngoặc () đúng");
                Console.WriteLine("9. Bài 9: Mô phỏng hệ thống in ấn (FIFO) quản lý chờ và in");
                Console.WriteLine("10. Bài 10: Mô phỏng đường truyền dữ liệu trong mạng gửi và xử lý");
                Console.WriteLine("11. Bài 11: Mô phỏng hàng đợi quản lý Dịch vụ Khách hàng ngân hàng");
                Console.WriteLine("12. Bài 12: Tính giá trị của biểu thức toán học hậu tố (Postfix)");
                Console.WriteLine("13. Bài 13: Kiểm tra tính hợp lệ của biểu thức trung tố toán học");
                Console.WriteLine("14. Bài 14: Tính giá trị biểu thức trung tố toán học (Ba Lan)");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn bài (0-14): ");

                string chon = Console.ReadLine();
                Console.WriteLine();

                if (chon == "0") return;
                ChayBai(chon);

                Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        static void ChayBai(string chon)
        {
            switch (chon)
            {
                case "1": B1C5.Run(); break;
                case "2": B2C5.Run(); break;
                case "3": B3C5.Run(); break;
                case "4": B4C5.Run(); break;
                case "5": B5C5.Run(); break;
                case "6": B6C5.Run(); break;
                case "7": B7C5.Run(); break;
                case "8": B8C5.Run(); break;
                case "9": B9C5.Run(); break;
                case "10": B10C5.Run(); break;
                case "11": B11C5.Run(); break;
                case "12": B12C5.Run(); break;
                case "13": B13C5.Run(); break;
                case "14": B14C5.Run(); break;
                default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
            }
        }
    }
}
