
namespace BTTH1
{
    static class B2C3
    {
        static int TongBinhPhuong(int n)
        {
            if (n == 1)
                return 1;

            return TongBinhPhuong(n - 1) + n * n;
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap n", 5);

            if (n < 1) return;

            Console.WriteLine("Tong binh phuong = "
                + TongBinhPhuong(n));
        }
    }
}
