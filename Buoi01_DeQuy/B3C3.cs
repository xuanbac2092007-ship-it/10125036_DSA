
namespace BTTH1
{
    static class B3C3
    {
        static double TongNghichDao(int n)
        {
            if (n == 1)
                return 1;

            return TongNghichDao(n - 1) + 1.0 / n;
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap n", 5);

            if (n < 1) return;

            Console.WriteLine("Tong = " + TongNghichDao(n));
        }
    }
}
