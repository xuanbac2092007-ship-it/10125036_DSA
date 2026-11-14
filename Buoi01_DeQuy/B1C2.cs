
namespace BTTH1
{
    static class B1C2
    {
        static void ThapHaNoi(int n, char A, char B, char C)
        {
            if (n == 1)
            {
                Console.WriteLine(A + " -> " + C);
                return;
            }

            ThapHaNoi(n - 1, A, C, B);

            Console.WriteLine(A + " -> " + C);

            ThapHaNoi(n - 1, B, A, C);
        }

        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap so dia", 3);

            if (n <= 0)
            {
                Console.WriteLine("So dia khong hop le!");
                return;
            }

            ThapHaNoi(n, 'A', 'B', 'C');
        }
    }
}
