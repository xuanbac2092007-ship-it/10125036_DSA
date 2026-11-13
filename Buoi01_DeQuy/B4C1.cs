
namespace BTTH1
{
    static class B4C1
    {
        public static void Run()
        {
            int[] a = hamhotro.TaoMangNgauNhien(1000, 500);

            Console.WriteLine("Mang ban dau:");
            hamhotro.InMang(a);

            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                        hamhotro.Swap(a, j, j + 1);
                }
            }

            Console.WriteLine("Mang sau sap xep:");
            hamhotro.InMang(a);
        }
    }
}
