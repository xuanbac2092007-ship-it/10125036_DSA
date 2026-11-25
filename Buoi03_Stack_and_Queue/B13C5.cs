using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B13C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 13: KIỂM TRA TÍNH HỢP LỆ TRUNG TỐ ---");
            string infix = hamhotro.DocChuoi("Nhập biểu thức trung tố", "[(3+4)*2]");
            Stack<char> stack = new Stack<char>();
            bool isValid = true;

            foreach (char c in infix)
            {
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
                Console.WriteLine(" -> Kết quả: Biểu thức trung tố HỢP LỆ!");
            else
                Console.WriteLine(" -> Kết quả: Biểu thức trung tố KHÔNG HỢP LỆ!");
        }
    }
}
