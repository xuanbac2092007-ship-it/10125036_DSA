using System;

namespace Buoi02_DanhSach
{
    
    struct NhanVien
    {
        public string MaNV;
        public string Hoten;
        public int Namsinh;
        public string Phongban;
        public int LuongCB;
        public int Thuong;
        public int ThucLinh;

        public NhanVien(string ma, string ten, int nam, string phong, int luong, int thuong)
        {
            MaNV = ma;
            Hoten = ten;
            Namsinh = nam;
            Phongban = phong;
            LuongCB = luong;
            Thuong = thuong;
            ThucLinh = luong + thuong;
        }
    }

    static class B2C4
    {
        static void InDS(NhanVien[] ds)
        {
            for (int i = 0; i < ds.Length; i++)
            {
                Console.WriteLine(ds[i].MaNV + " | " + ds[i].Hoten + " | " + ds[i].Phongban + " | LuongCB: " + ds[i].LuongCB + " | Thuong: " + ds[i].Thuong + " | ThucLinh: " + ds[i].ThucLinh);
            }
        }

        public static void Run()
        {
            Console.WriteLine("--- BÀI TẬP 2: DANH SÁCH NHÂN VIÊN ---");
            NhanVien[] ds = new NhanVien[3];
            ds[0] = new NhanVien("NV03", "Tran Van B", 1995, "Ke toan", 8000000, 1500000);
            ds[1] = new NhanVien("NV01", "Nguyen Van A", 1998, "Kinh doanh", 7500000, 1000000);
            ds[2] = new NhanVien("NV02", "Le Van C", 1993, "Ke toan", 7500000, 2000000);

            Console.WriteLine("Danh sach nhan vien ban dau:");
            InDS(ds);

            long tongThucLinh = 0;
            int minLuong = ds[0].LuongCB;
            int demThuong = 0;

            for (int i = 0; i < ds.Length; i++)
            {
                tongThucLinh += ds[i].ThucLinh;
                if (ds[i].LuongCB < minLuong)
                    minLuong = ds[i].LuongCB;
                if (ds[i].Thuong >= 1200000)
                    demThuong++;
            }

            Console.WriteLine("\na. Tong thuc linh: " + tongThucLinh);

            Console.WriteLine("\nb. Nhan vien co luong CB thap nhat (" + minLuong + "):");
            for (int i = 0; i < ds.Length; i++)
            {
                if (ds[i].LuongCB == minLuong)
                    Console.WriteLine("   " + ds[i].MaNV + " - " + ds[i].Hoten);
            }

            Console.WriteLine("\nc. So nhan vien co thuong >= 1200000: " + demThuong);

           
            for (int i = 0; i < ds.Length - 1; i++)
            {
                for (int j = i + 1; j < ds.Length; j++)
                {
                    int ssPhong = string.Compare(ds[i].Phongban, ds[j].Phongban);
                    if (ssPhong > 0 || (ssPhong == 0 && string.Compare(ds[i].MaNV, ds[j].MaNV) < 0))
                    {
                        NhanVien tam = ds[i];
                        ds[i] = ds[j];
                        ds[j] = tam;
                    }
                }
            }

            Console.WriteLine("\nd. Danh sach sau khi sap xep:");
            InDS(ds);

            
            for (int i = 0; i < ds.Length; i++)
            {
                ds[i].LuongCB = (int)(ds[i].LuongCB * 1.05);
                ds[i].ThucLinh = ds[i].LuongCB + ds[i].Thuong;
            }

            Console.WriteLine("\ne. Danh sach sau khi tang luong 5%:");
            InDS(ds);
        }
    }
}
