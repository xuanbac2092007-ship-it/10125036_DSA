using System;
using System.Collections.Generic;

namespace Buoi02_DanhSach
{
    static class B8C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 8: THỐNG KÊ TỪ ---");
            Console.Write("Nhap chuoi van ban: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) input = "apple orange apple banana orange apple";

            // Chuyển về chữ thường và tách từ
            string[] words = input.ToLower().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (count.ContainsKey(word)) count[word]++;
                else count[word] = 1;
            }

            Console.WriteLine("\nTan suat xuat hien cua moi tu:");
            foreach (var pair in count)
            {
                Console.WriteLine($"   {pair.Key}: {pair.Value} lan");
            }
        }
    }
}
