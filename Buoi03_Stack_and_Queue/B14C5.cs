using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi03_Stack_Queue
{
    static class B14C5
    {
        static bool IsOperand(string s)
        {
            double num;
            return double.TryParse(s, out num);
        }

        static int Pri(string op)
        {
            if (op == "+" || op == "-") return 1;
            if (op == "*" || op == "/") return 2;
            return 0;
        }

        static string HauTo(string infixExpression)
        {
            Stack<string> St = new Stack<string>();
            StringBuilder E1 = new StringBuilder();
            string[] tokens = infixExpression.Split(' ');

            foreach (string s in tokens)
            {
                if (string.IsNullOrWhiteSpace(s)) continue;

                if (s == "(")
                {
                    St.Push(s);
                }
                else if (s == ")")
                {
                    while (St.Count > 0 && St.Peek() != "(")
                    {
                        E1.Append(St.Pop()).Append(" ");
                    }
                    if (St.Count > 0) St.Pop(); 
                }
                else if (IsOperand(s))
                {
                    E1.Append(s).Append(" ");
                }
                else 
                {
                    while (St.Count > 0 && Pri(St.Peek()) >= Pri(s))
                    {
                        E1.Append(St.Pop()).Append(" ");
                    }
                    St.Push(s);
                }
            }

            while (St.Count > 0)
            {
                E1.Append(St.Pop()).Append(" ");
            }

            return E1.ToString().Trim();
        }

        
        static double TinhHauTo(string postfix)
        {
            string[] tokens = postfix.Split(' ');
            Stack<double> stack = new Stack<double>();

            foreach (string token in tokens)
            {
                if (string.IsNullOrWhiteSpace(token)) continue;

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
                    }
                }
            }
            return stack.Pop();
        }

        public static void Run()
        {
            Console.WriteLine("--- BÀI 14: TÍNH GIÁ TRỊ BIỂU THỨC TRUNG TỐ ---");
            Console.WriteLine("(Lưu ý: Các phần tử toán tử và toán hạng cách nhau bằng khoảng trắng. Ví dụ: 3 + 4 * 2)");
            string infix = hamhotro.DocChuoi("Nhập biểu thức trung tố", "3 + 4 * 2");

            try
            {
                string postfix = HauTo(infix);
                Console.WriteLine("-> Biểu thức hậu tố (Postfix): " + postfix);

                double ketQua = TinhHauTo(postfix);
                Console.WriteLine("-> Kết quả tính toán biểu thức: " + ketQua);
            }
            catch (Exception)
            {
                Console.WriteLine("Biểu thức không hợp lệ! Vui lòng kiểm tra lại khoảng trắng giữa các phần tử.");
            }
        }
    }
}
