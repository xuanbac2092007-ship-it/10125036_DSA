using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B3C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 3: MÔ PHỎNG QUÁ TRÌNH THỰC THI (CALL STACK) ---");
            Stack<string> callStack = new Stack<string>();

            Console.WriteLine("Bắt đầu thực thi Main()");
            callStack.Push("Main()");

            Console.WriteLine("Main() gọi HamA()");
            callStack.Push("HamA()");

            Console.WriteLine("HamA() gọi HamB()");
            callStack.Push("HamB()");

            Console.WriteLine("\nDanh sách các hàm đang chờ trong Call Stack:");
            foreach (var func in callStack)
            {
                Console.WriteLine("   | " + func + " |");
            }
            Console.WriteLine("   +----------+");

            Console.WriteLine("\nHàmB() thực thi xong, quay về hàm gọi...");
            callStack.Pop();

            Console.WriteLine("HàmA() thực thi xong, quay về hàm gọi...");
            callStack.Pop();

            Console.WriteLine("\nTrạng thái Call Stack còn lại:");
            foreach (var func in callStack)
            {
                Console.WriteLine("   | " + func + " |");
            }
            Console.WriteLine("   +----------+");
        }
    }
}
