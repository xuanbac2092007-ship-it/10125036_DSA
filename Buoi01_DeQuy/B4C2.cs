
namespace BTTH1
{
    static class B4C2
    {
        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap N", 1000);

            Console.WriteLine("Cac so hoan hao nho hon N:");

            for (int i = 2; i < n; i++)
            {
                if (hamhotro.KiemTraHoanHao(i))
                    Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
