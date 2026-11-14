
namespace BTTH1
{
    static class B8C3
    {
        static double Can(int i, int n)
        {
            if (i == n)
                return Math.Sqrt(n);

            return Math.Sqrt(i + Can(i + 1, n));
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap n", 5);

            if (n < 1) return;

            Console.WriteLine("Ket qua = " + Can(1, n));
        }
    }
}
