
using System;
using System.Text;

namespace BTTH1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n========== BÀI TẬP ==========");
                Console.WriteLine("1. Bài 1 Chương 1 - Tìm số lớn nhất, nhỏ nhất");
                Console.WriteLine("2. Bài 2 Chương 1 - FizzBuzz");
                Console.WriteLine("3. Bài 3 Chương 1 - Đảo ngược chuỗi");
                Console.WriteLine("4. Bài 4 Chương 1 - Sắp xếp mảng");
                Console.WriteLine("5. Bài Fibonacci Chương 1 + 2");

                Console.WriteLine("6. Bài 1 Chương 2 - Tháp Hà Nội");
                Console.WriteLine("7. Bài 2 Chương 2 - Tìm kiếm nhị phân");
                Console.WriteLine("8. Bài 3 Chương 2 - Kiểm tra số nguyên tố");
                Console.WriteLine("9. Bài 4 Chương 2 - Số hoàn hảo");
                Console.WriteLine("10. Bài 6 Chương 2 - Sắp xếp mảng");

                Console.WriteLine("11. Bài 1 Chương 3 - Tính tổng 1 đến n");
                Console.WriteLine("12. Bài 2 Chương 3 - Tổng bình phương");
                Console.WriteLine("13. Bài 3 Chương 3 - Tổng phân số");
                Console.WriteLine("14. Bài 4 Chương 3 - Tính lũy thừa");
                Console.WriteLine("15. Bài 5 Chương 3 - Ước lẻ lớn nhất");
                Console.WriteLine("16. Bài 6 Chương 3 - Tìm UCLN");
                Console.WriteLine("17. Bài 7 Chương 3 - Đếm chữ số");
                Console.WriteLine("18. Bài 8 Chương 3 - Căn lồng nhau");

                Console.WriteLine("0. Thoát");
                Console.Write("Chọn bài: ");

                string chon = Console.ReadLine();

                Console.WriteLine();

                switch (chon)
                {
                    case "1": B1C1.Run(); break;
                    case "2": B2C1.Run(); break;
                    case "3": B3C1.Run(); break;
                    case "4": B4C1.Run(); break;
                    case "5": B5_Fibo.Run(); break;
                    case "6": B1C2.Run(); break;
                    case "7": B2C2.Run(); break;
                    case "8": B3C2.Run(); break;
                    case "9": B4C2.Run(); break;
                    case "10": B6C2.Run(); break;
                    case "11": B1C3.Run(); break;
                    case "12": B2C3.Run(); break;
                    case "13": B3C3.Run(); break;
                    case "14": B4C3.Run(); break;
                    case "15": B5C3.Run(); break;
                    case "16": B6C3.Run(); break;
                    case "17": B7C3.Run(); break;
                    case "18": B8C3.Run(); break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

                Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
    }
}
