using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B1C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 1: KIỂM TRA TÍNH ĐÚNG ĐẮN CỦA BIỂU THỨC ---");
            string expression = hamhotro.DocChuoi("Nhập biểu thức kiểm tra", "{[()]}");
            Stack<char> stack = new Stack<char>();
            bool isValid = true;

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        isValid = false;
                        break;
                    }
                    char open = stack.Pop();
                    if ((c == ')' && open != '(') ||
                        (c == ']' && open != '[') ||
                        (c == '}' && open != '{'))
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            if (stack.Count > 0) isValid = false;

            if (isValid)
                Console.WriteLine("-> Kết quả: Biểu thức đúng cấu trúc ngoặc!");
            else
                Console.WriteLine("-> Kết quả: Biểu thức sai cấu trúc ngoặc!");
        }
    }
}
