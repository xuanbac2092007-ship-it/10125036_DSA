using System;

namespace Buoi03_Stack_Queue
{
    static class hamhotro
    {
       
        public static int DocSo(string thongBao, int macDinh)
        {
            Console.Write(thongBao + " (Enter = " + macDinh + "): ");
            string s = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(s))
            {
                return macDinh;
            }
            int kq;
            if (int.TryParse(s, out kq))
                return kq;
            return macDinh;
        }

        
        public static string DocChuoi(string thongBao, string macDinh)
        {
            Console.Write(thongBao + " (Enter = \"" + macDinh + "\"): ");
            string s = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(s))
            {
                return macDinh;
            }
            return s;
        }
    }
}
