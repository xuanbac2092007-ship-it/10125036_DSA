
namespace BTTH1
{
    static class B7C3
    {
        static int SoChuSo(int n)
        {
            if (n == 0)
                return 0;

            return SoChuSo(n / 10) + 1;
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap n", 12345);

            if (n <= 0) return;

            Console.WriteLine("So chu so = " + SoChuSo(n));
        }
    }
}
