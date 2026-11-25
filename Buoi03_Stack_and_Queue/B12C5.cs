using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B12C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 12: TÍNH GIÁ TRỊ BIỂU THỨC HẬU TỐ ---");
            Console.WriteLine("(Lưu ý: Các toán tử và toán hạng phải cách nhau bằng khoảng trắng. Ví dụ: 3 4 2 * +)");
            string postfix = hamhotro.DocChuoi("Nhập biểu thức hậu tố", "3 4 2 * +");

            try
            {
                string[] tokens = postfix.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Stack<double> stack = new Stack<double>();

                foreach (string token in tokens)
                {
                    double val;
                    if (double.TryParse(token, out val))
                    {
                        stack.Push(val);
                    }
                    else
                    {
                        double b = stack.Pop();
                        double a = stack.Pop();
                        switch (token)
                        {
                            case "+": stack.Push(a + b); break;
                            case "-": stack.Push(a - b); break;
                            case "*": stack.Push(a * b); break;
                            case "/": stack.Push(a / b); break;
                            default: throw new InvalidOperationException("Toán tử không hợp lệ!");
                        }
                    }
                }
                Console.WriteLine("-> Kết quả tính toán hậu tố: " + stack.Pop());
            }
            catch (Exception)
            {
                Console.WriteLine(" -> Lỗi: Biểu thức hậu tố sai cấu trúc hoặc thiếu khoảng trắng!");
            }
        }
    }
}
