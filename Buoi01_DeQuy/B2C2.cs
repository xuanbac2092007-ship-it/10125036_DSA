
namespace BTTH1
{
    static class B2C2
    {
        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap so phan tu", 10);

            if (n <= 0) return;

            int[] a = hamhotro.TaoMangNgauNhien(n, 100);

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

            int x = hamhotro.DocSo("Nhap so can tim", 5);

            int dau = 0;
            int cuoi = n - 1;
            int vt = -1;

            while (dau <= cuoi)
            {
                int giua = (dau + cuoi) / 2;

                if (a[giua] == x)
                {
                    vt = giua;
                    break;
                }
                else if (a[giua] < x)
                    dau = giua + 1;
                else
                    cuoi = giua - 1;
            }

            if (vt == -1)
                Console.WriteLine("Khong tim thay!");
            else
                Console.WriteLine("Tim thay tai vi tri: " + vt);
        }
    }
}
