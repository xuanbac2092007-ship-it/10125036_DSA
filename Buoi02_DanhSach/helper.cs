using System;

namespace Buoi02_DanhSach
{
    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }


    class NodeKep
    {
        public string Data;
        public NodeKep Prev;
        public NodeKep Next;

        public NodeKep(string data)
        {
            Data = data;
            Prev = null;
            Next = null;
        }
    }


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


        public static void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }


        public static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }


        public static Node ThemCuoi(Node head, int val)
        {
            Node moi = new Node(val);
            if (head == null) return moi;
            Node p = head;
            while (p.Next != null)
                p = p.Next;
            p.Next = moi;
            return head;
        }


        public static void InDSLK(Node head)
        {
            if (head == null)
            {
                Console.WriteLine("Danh sach rong");
                return;
            }
            Node p = head;
            while (p != null)
            {
                Console.Write(p.Data + (p.Next != null ? " -> " : ""));
                p = p.Next;
            }
            Console.WriteLine();
        }


        public static Node XoaDauTien(Node head, int x)
        {
            if (head == null) return null;


            if (head.Data == x) return head.Next;


            Node truoc = head;
            Node p = head.Next;
            while (p != null)
            {
                if (p.Data == x)
                {
                    truoc.Next = p.Next;
                    break;
                }
                truoc = p;
                p = p.Next;
            }
            return head;
        }
    }
}
