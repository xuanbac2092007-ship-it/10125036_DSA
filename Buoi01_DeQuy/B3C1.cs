
namespace BTTH1
{
    static class B3C1
    {
        public static void Run()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();

            string kq = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                kq += s[i];
            }

            Console.WriteLine("Chuoi dao nguoc: " + kq);
        }
    }
}