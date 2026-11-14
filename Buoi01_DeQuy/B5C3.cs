
namespace BTTH1
{
    static class B5C3
    {
        static int UocLeMax(int n)
        {
            if (n % 2 == 1)
                return n;

            return UocLeMax(n / 2);
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap n", 100);

            if (n <= 0) return;

            Console.WriteLine("Uoc le lon nhat = "
                + UocLeMax(n));
        }
    }
}
