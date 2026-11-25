using Buoi02_DanhSach;
using System;
using System.Text;

namespace Buoi02_DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            if (args.Length > 0)
            {
                string chonNhanh = args[0];
                Console.WriteLine("Chọn bài: " + chonNhanh);
                ChayBai(chonNhanh);
                return;
            }

            while (true)
            {
                Console.WriteLine("\n========== MENU BÀI TẬP BUỔI 02 (DANH SÁCH) ==========");
                Console.WriteLine("1. Bài 1 Chương 4 - Chèn phần tử mảng");
                Console.WriteLine("2. Bài 2 Chương 4 - Quản lý nhân viên");
                Console.WriteLine("3. Bài 3 Chương 4 - Ma trận vuông");
                Console.WriteLine("4. Bài 4 Chương 4 - DSLKD Số nguyên dương");
                Console.WriteLine("5. Bài 5 Chương 4 - DSLKD Số nguyên l");
                Console.WriteLine("7. Bài 7 Chương 4 - Quản lý nhiệt độ");
                Console.WriteLine("8. Bài 8 Chương 4 - Thống kê từ");
                Console.WriteLine("9. Bài 9 Chương 4 - Xử lý số nguyên");
                Console.WriteLine("10. Bài 10 Chương 4 - Ma trận xoắn ốc");
                Console.WriteLine("11. Bài 11 Chương 4 - Ma trận đặc biệt");
                Console.WriteLine("12. Bài 12 Chương 4 - Game Minesweeper");
                Console.WriteLine("13. Bài 13 Chương 4 - Đảo ngược danh sách");
                Console.WriteLine("14. Bài 14 Chương 4 - Gộp danh sách");
                Console.WriteLine("15. Bài 15 Chương 4 - Phát hiện chu trình");
                Console.WriteLine("16. Bài 16 Chương 4 - Lịch sử duyệt Web (Kép)");
                Console.WriteLine("17. Bài 17 Chương 4 - Playlist nhạc (Kép)");
                Console.WriteLine("18. Bài 18 Chương 4 - Hệ thống đặt hàng (Kép)");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn bài: ");

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
                case "1": B1C4.Run(); break;
                case "2": B2C4.Run(); break;
                case "3": B3C4.Run(); break;
                case "4": B4C4.Run(); break;
                case "5": B5C4.Run(); break;
                case "7": B7C4.Run(); break;
                case "8": B8C4.Run(); break;
                case "9": B9C4.Run(); break;
                case "10": B10C4.Run(); break;
                case "11": B11C4.Run(); break;
                case "12": B12C4.Run(); break;
                case "13": B13C4.Run(); break;
                case "14": B14C4.Run(); break;
                case "15": B15C4.Run(); break;
                case "16": B16C4.Run(); break;
                case "17": B17C4.Run(); break;
                case "18": B18C4.Run(); break;
                default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
            }
        }
    }
}
