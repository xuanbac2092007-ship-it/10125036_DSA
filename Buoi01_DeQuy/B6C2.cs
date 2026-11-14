
namespace BTTH1
{
    static class B6C2
    {
        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap so phan tu", 10);

            if (n <= 0) return;

            int[] a = hamhotro.TaoMangNgauNhien(n, 100);

            Console.WriteLine("Mang ban dau:");
            hamhotro.InMang(a);

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                        hamhotro.Swap(a, j, j + 1);
                }
            }

            Console.WriteLine("Mang tang dan:");
            hamhotro.InMang(a);
        }
    }
}
