
namespace BTTH1
{
    static class B1C3
    {
        static int Tong(int n)
        {
            if (n == 1)
                return 1;

            return Tong(n - 1) + n;
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap n", 10);

            if (n < 1) return;

            Console.WriteLine("Tong = " + Tong(n));
        }
    }
}
