
namespace BTTH1
{
    static class B6C3
    {
        static int UCLN(int a, int b)
        {
            if (a % b == 0)
                return b;

            return UCLN(b, a % b);
        }

        public static void Run()
        {
            int a = hamhotro.DocSo("Nhap a", 24);
            int b = hamhotro.DocSo("Nhap b", 12);

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Nhap so duong!");
                return;
            }

            Console.WriteLine("UCLN = " + UCLN(a, b));
        }
    }
}
