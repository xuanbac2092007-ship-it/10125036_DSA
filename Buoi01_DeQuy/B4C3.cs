
namespace BTTH1
{
    static class B4C3
    {
        static double LuyThua(double x, int n)
        {
            if (n == 0)
                return 1;

            return x * LuyThua(x, n - 1);
        }

        public static void Run()
        {
            double x = 2;
            int n = hamhotro.DocSo("Nhap so mu n", 5);

            if (n < 0) return;

            Console.WriteLine("Ket qua = " + LuyThua(x, n));
        }
    }
}
