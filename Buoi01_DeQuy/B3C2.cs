
namespace BTTH1
{
    static class B3C2
    {
        public static void Run()
        {
            int n = hamhotro.DocSo("Nhap n", 17);

            if (hamhotro.KiemTraNguyenTo(n))
                Console.WriteLine(n + " la so nguyen to");
            else
                Console.WriteLine(n + " khong phai so nguyen to");
        }
    }
}
