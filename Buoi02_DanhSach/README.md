# Buoi02_DanhSach

- Họ tên: Vũ Xuân Bắc
- MSV: 10125036
- Lớp: 124251

## Bài đã làm

### chương4

| Bài | Nội dung                                                                                                 |
| --- | -------------------------------------------------------------------------------------------------------- |
| 1   | Nhập mảng n số nguyên dương, hiển thị danh sách và chèn phần tử x vào vị trí k                           |
| 2   | Quản lý danh sách nhân viên: thực lĩnh, lương thấp nhất, đếm thưởng, sắp xếp, tăng lương                 |
| 3   | Nhập ma trận vuông: tính tổng, tìm số dương nhỏ nhất, chéo phụ, chéo chính tăng dần                      |
| 4   | DSLKD số nguyên dương (pHead): đếm số bằng x, tìm số dương nhỏ nhất, xóa phần tử x đầu tiên              |
| 5   | DSLKD số nguyên l: tìm số lớn nhất, tính tổng, đếm SNT, đếm âm/0/dương, đếm số bằng x, số dương nhỏ nhất |
| 7   | Quản lý nhiệt độ: nhập nhiệt độ n ngày, tìm cao nhất, thấp nhất và tính trung bình                       |
| 8   | Thống kê từ: nhập văn bản, tách từ và dùng Dictionary đếm số lần xuất hiện của mỗi từ                    |
| 9   | Xử lý số nguyên: kiểm tra SNT, số chẵn, số hoàn hảo và phân loại thống kê                                |
| 10  | Ma trận xoắn ốc: nhập ma trận vuông và in theo thứ tự xoắn ốc                                            |
| 11  | Ma trận đặc biệt: kiểm tra xem ma trận có phải ma trận đơn vị hay ma trận đối xứng không                 |
| 12  | Game Minesweeper: tạo bảng Minesweeper và thống kê vị trí có mìn                                         |
| 13  | Đảo ngược danh sách liên kết đơn không dùng đệ quy                                                       |
| 14  | Gộp hai danh sách liên kết đơn đã được sắp xếp thành một danh sách sắp xếp mới                           |
| 15  | Phát hiện chu trình trong danh sách liên kết đơn (Thuật toán Floyd's Rùa và Thỏ)                         |
| 16  | Hệ thống lịch sử duyệt Web mô phỏng nút Back/Forward sử dụng danh sách kép                               |
| 17  | Playlist nhạc mô phỏng nút Next/Previous sử dụng danh sách kép                                           |
| 18  | Hệ thống đặt hàng quản lý đơn hàng chuyển trạng thái sử dụng danh sách kép                               |

## Lệnh chạy

### chương4

```bash
dotnet run 1
dotnet run 2
dotnet run 3
dotnet run 4
dotnet run 5
dotnet run 7
dotnet run 8
dotnet run 9
dotnet run 10
dotnet run 11
dotnet run 12
dotnet run 13
dotnet run 14
dotnet run 15
dotnet run 16
dotnet run 17
dotnet run 18
```

## Kết quả chạy

### chương4

### bài1

```csharp
using System;

namespace Buoi02_DanhSach
{
    static class B1C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI TẬP 1: MẢNG SỐ NGUYÊN DƯƠNG ---");

            int n = hamhotro.DocSo("Nhap so phan tu n", 5);
            if (n <= 0) return;

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = hamhotro.DocSo("Nhap a[" + i + "]", (i + 1) * 3);
            }

            Console.Write("Danh sach phan tu: ");
            hamhotro.InMang(a);

            int x = hamhotro.DocSo("Nhap phan tu x can chen", 99);
            int k = hamhotro.DocSo("Nhap vi tri k can chen", 2);

            if (k < 0 || k > n)
            {
                Console.WriteLine("Vi tri chen khong hop le!");
                return;
            }

            int[] tmp = new int[n + 1];
            for (int i = 0; i < k; i++)
                tmp[i] = a[i];

            tmp[k] = x;

            for (int i = k; i < n; i++)
                tmp[i + 1] = a[i];

            a = tmp;

            Console.Write("Mang sau khi chen: ");
            hamhotro.InMang(a);
        }
    }
}
```

#### kết quả

```text
Chọn bài: 1
--- BÀI TẬP 1: MẢNG SỐ NGUYÊN DƯƠNG ---
Nhap so phan tu n (Enter = 5):
Nhap a[0] (Enter = 3):
Nhap a[1] (Enter = 6):
Nhap a[2] (Enter = 9):
Nhap a[3] (Enter = 12):
Nhap a[4] (Enter = 15):
Danh sach phan tu: 3 6 9 12 15
Nhap phan tu x can chen (Enter = 99):
Nhap vi tri k can chen (Enter = 2):
Mang sau khi chen: 3 6 99 9 12 15
```

### bài2

```csharp
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
```

#### kết quả

```text
Chọn bài: 2
--- BÀI TẬP 2: DANH SÁCH NHÂN VIÊN ---
Danh sach nhan vien ban dau:
NV03 | Tran Van B | Ke toan | LuongCB: 8000000 | Thuong: 1500000 | ThucLinh: 9500000
NV01 | Nguyen Van A | Kinh doanh | LuongCB: 7500000 | Thuong: 1000000 | ThucLinh: 8500000
NV02 | Le Van C | Ke toan | LuongCB: 7500000 | Thuong: 2000000 | ThucLinh: 9500000

a. Tong thuc linh: 27500000

b. Nhan vien co luong CB thap nhat (7500000):
   NV01 - Nguyen Van A
   NV02 - Le Van C

c. So nhan vien co thuong >= 1200000: 2

d. Danh sach sau khi sap xep:
NV03 | Tran Van B | Ke toan | LuongCB: 8000000 | Thuong: 1500000 | ThucLinh: 9500000
NV02 | Le Van C | Ke toan | LuongCB: 7500000 | Thuong: 2000000 | ThucLinh: 9500000
NV01 | Nguyen Van A | Kinh doanh | LuongCB: 7500000 | Thuong: 1000000 | ThucLinh: 8500000

e. Danh sach sau khi tang luong 5%:
NV03 | Tran Van B | Ke toan | LuongCB: 8400000 | Thuong: 1500000 | ThucLinh: 9900000
NV02 | Le Van C | Ke toan | LuongCB: 7875000 | Thuong: 2000000 | ThucLinh: 9875000
NV01 | Nguyen Van A | Kinh doanh | LuongCB: 7875000 | Thuong: 1000000 | ThucLinh: 8875000
```

### bài3

```csharp
using System;

namespace Buoi02_DanhSach
{
    static class B3C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI TẬP 3: MA TRẬN VUÔNG ---");
            int n = hamhotro.DocSo("Nhap cap ma tran vuong n", 3);
            if (n <= 0) return;

            int[,] a = new int[n, n];
            int dem = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = hamhotro.DocSo("Nhap a[" + i + "," + j + "]", dem++);
                }
            }

            Console.WriteLine("\nMa tran vua nhap:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int tong = 0;
            int minDuong = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tong += a[i, j];
                    if (a[i, j] > 0 && a[i, j] < minDuong)
                        minDuong = a[i, j];
                }
            }

            Console.WriteLine("\na. Tong cac phan tu: " + tong);
            if (minDuong == int.MaxValue)
                Console.WriteLine("b. Khong co so duong!");
            else
                Console.WriteLine("b. Gia tri duong nho nhat: " + minDuong);

            int tongCheoPhu = 0;
            for (int i = 0; i < n; i++)
            {
                tongCheoPhu += a[i, n - 1 - i];
            }
            Console.WriteLine("c. Tong duong cheo phu: " + tongCheoPhu);

            bool tangDan = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i, i] >= a[i + 1, i + 1])
                {
                    tangDan = false;
                    break;
                }
            }

            if (tangDan)
                Console.WriteLine("d. Duong cheo chinh tang dan");
            else
                Console.WriteLine("d. Duong cheo chinh khong tang dan");
        }
    }
}
```

#### kết quả

```text
Chọn bài: 3
--- BÀI TẬP 3: MA TRẬN VUÔNG ---
Nhap cap ma tran vuong n (Enter = 3):
Nhap a[0,0] (Enter = 1):
Nhap a[0,1] (Enter = 2):
Nhap a[0,2] (Enter = 3):
Nhap a[1,0] (Enter = 4):
Nhap a[1,1] (Enter = 5):
Nhap a[1,2] (Enter = 6):
Nhap a[2,0] (Enter = 7):
Nhap a[2,1] (Enter = 8):
Nhap a[2,2] (Enter = 9):

Ma tran vua nhap:
1	2	3
4	5	6
7	8	9

a. Tong cac phan tu: 45
b. Gia tri duong nho nhat: 1
c. Tong duong cheo phu: 15
d. Duong cheo chinh tang dan
```

### bài4

```csharp
using System;

namespace Buoi02_DanhSach
{
    static class B4C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI TẬP 4: DSLKD SỐ NGUYÊN DƯƠNG ---");
            Node pHead = null;
            int[] mau = { 5, 12, 5, 3, 9 };
            int n = hamhotro.DocSo("Nhap so phan tu DSLKD", 5);

            for (int i = 0; i < n; i++)
            {
                int gtMacDinh = i < mau.Length ? mau[i] : i + 1;
                int val = hamhotro.DocSo("Nhap phan tu thu " + (i + 1), gtMacDinh);
                pHead = hamhotro.ThemCuoi(pHead, val);
            }

            Console.Write("Danh sach lien ket don: ");
            hamhotro.InDSLK(pHead);

            int x = hamhotro.DocSo("a. Nhap x can dem", 5);
            int demX = 0;
            int minDuong = int.MaxValue;

            Node p = pHead;
            while (p != null)
            {
                if (p.Data == x)
                    demX++;
                if (p.Data > 0 && p.Data < minDuong)
                    minDuong = p.Data;
                p = p.Next;
            }

            Console.WriteLine("-> So phan tu bang " + x + ": " + demX);
            if (minDuong == int.MaxValue)
                Console.WriteLine("b. Khong co so duong!");
            else
                Console.WriteLine("b. Phan tu duong nho nhat: " + minDuong);

            int xXoa = hamhotro.DocSo("c. Nhap x can xoa dau tien", 5);
            pHead = hamhotro.XoaDauTien(pHead, xXoa);

            Console.Write("Danh sach sau khi xoa: ");
            hamhotro.InDSLK(pHead);
        }
    }
}
```

#### kết quả

```text
Chọn bài: 4
--- BÀI TẬP 4: DSLKD SỐ NGUYÊN DƯƠNG ---
Nhap so phan tu DSLKD (Enter = 5):
Nhap phan tu thu 1 (Enter = 5):
Nhap phan tu thu 2 (Enter = 12):
Nhap phan tu thu 3 (Enter = 5):
Nhap phan tu thu 4 (Enter = 3):
Nhap phan tu thu 5 (Enter = 9):
Danh sach lien ket don: 5 -> 12 -> 5 -> 3 -> 9
a. Nhap x can dem (Enter = 5):
-> So phan tu bang 5: 2
b. Phan tu duong nho nhat: 3
c. Nhap x can xoa dau tien (Enter = 5):
Danh sach sau khi xoa: 12 -> 5 -> 3 -> 9
```

### bài5

```csharp
using System;

namespace Buoi02_DanhSach
{
    static class B5C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI TẬP 5: DSLKD SỐ NGUYÊN l ---");
            Node l = null;
            int[] mau = { -2, 7, 0, 11, -5, 7 };
            int n = hamhotro.DocSo("Nhap so phan tu danh sach l", 6);

            for (int i = 0; i < n; i++)
            {
                int gtMacDinh = i < mau.Length ? mau[i] : i;
                int val = hamhotro.DocSo("Nhap l[" + i + "]", gtMacDinh);
                l = hamhotro.ThemCuoi(l, val);
            }

            Console.Write("Danh sach l: ");
            hamhotro.InDSLK(l);

            if (l == null) return;

            int max = l.Data;
            int tong = 0;
            int demSNT = 0;
            int demAm = 0, dem0 = 0, demDuong = 0;
            int minDuong = int.MaxValue;

            Node p = l;
            while (p != null)
            {
                if (p.Data > max) max = p.Data;
                tong += p.Data;
                if (hamhotro.KiemTraNguyenTo(p.Data)) demSNT++;

                if (p.Data < 0) demAm++;
                else if (p.Data == 0) dem0++;
                else demDuong++;

                if (p.Data > 0 && p.Data < minDuong)
                    minDuong = p.Data;

                p = p.Next;
            }

            Console.WriteLine("\na. Phan tu lon nhat: " + max);
            Console.WriteLine("b. Tong cac phan tu: " + tong);
            Console.WriteLine("c. So luong so nguyen to: " + demSNT);
            Console.WriteLine("d. So am: " + demAm + ", So bang 0: " + dem0 + ", So duong: " + demDuong);

            int x = hamhotro.DocSo("e. Nhap x can tim", 7);
            int demX = 0;
            p = l;
            while (p != null)
            {
                if (p.Data == x) demX++;
                p = p.Next;
            }
            Console.WriteLine("-> So phan tu bang " + x + ": " + demX);

            if (minDuong == int.MaxValue)
                Console.WriteLine("f. Khong co so duong!");
            else
                Console.WriteLine("f. Phan tu duong nho nhat: " + minDuong);
        }
    }
}
```

#### kết quả

```text
Chọn bài: 5
--- BÀI TẬP 5: DSLKD SỐ NGUYÊN l ---
Nhap so phan tu danh sach l (Enter = 6):
Nhap l[0] (Enter = -2):
Nhap l[1] (Enter = 7):
Nhap l[2] (Enter = 0):
Nhap l[3] (Enter = 11):
Nhap l[4] (Enter = -5):
Nhap l[5] (Enter = 7):
Danh sach l: -2 -> 7 -> 0 -> 11 -> -5 -> 7

a. Phan tu lon nhat: 11
b. Tong cac phan tu: 18
c. So luong so nguyen to: 3
d. So am: 2, So bang 0: 1, So duong: 3
e. Nhap x can tim (Enter = 7):
-> So phan tu bang 7: 2
f. Phan tu duong nho nhat: 7
```

### bài7

```csharp
using System;

namespace Buoi02_DanhSach
{
    static class B7C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 7: QUẢN LÝ NHIỆT ĐỘ ---");
            int n = hamhotro.DocSo("Nhap so ngay", 7);
            int[] temp = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                temp[i] = hamhotro.DocSo($"Nhiet do ngay {i + 1}", 25 + i % 3);
                sum += temp[i];
            }

            int max = temp[0], min = temp[0];
            foreach (int t in temp)
            {
                if (t > max) max = t;
                if (t < min) min = t;
            }

            Console.WriteLine($"Nhiet do cao nhat: {max}°C");
            Console.WriteLine($"Nhiet do thap nhat: {min}°C");
            Console.WriteLine($"Nhiet do trung binh tuan: {(double)sum / n:F2}°C");
        }
    }
}
```

#### kết quả

```text
Chọn bài: 7
--- BÀI 7: QUẢN LÝ NHIỆT ĐỘ ---
Nhap so ngay (Enter = 7):
Nhiet do cao nhat: 27°C
Nhiet do thap nhat: 25°C
Nhiet do trung binh tuan: 25.86°C
```

### bài8

```csharp
using System;
using System.Collections.Generic;

namespace Buoi02_DanhSach
{
    static class B8C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 8: THỐNG KÊ TỪ ---");
            Console.Write("Nhap chuoi van ban: ");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) input = "apple orange apple banana orange apple";

            string[] words = input.ToLower().Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (count.ContainsKey(word)) count[word]++;
                else count[word] = 1;
            }

            Console.WriteLine("\nTan suat xuat hien cua moi tu:");
            foreach (var pair in count)
            {
                Console.WriteLine($"   {pair.Key}: {pair.Value} lan");
            }
        }
    }
}
```

#### kết quả

```text
Chọn bài: 8
--- BÀI 8: THỐNG KÊ TỪ ---
Nhap chuoi van ban:
Tan suat xuat hien cua moi tu:
   apple: 3 lan
   orange: 2 lan
   banana: 1 lan
```

### bài9

```csharp
using System;
using System.Collections.Generic;

namespace Buoi02_DanhSach
{
    static class B9C4
    {
        static bool KiemTraHoanHao(int n)
        {
            if (n < 2) return false;
            int sum = 1;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if (i * i != n) sum += n / i;
                }
            }
            return sum == n;
        }

        public static void Run()
        {
            Console.WriteLine("--- BÀI 9: XỬ LÝ SỐ NGUYÊN ---");
            int n = hamhotro.DocSo("Nhap so phan tu", 5);
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(hamhotro.DocSo($"Nhap phan tu [{i}]", (i + 1) * 2 + 1));
            }

            Console.Write("Phan loai va thong ke:\n");
            foreach (int x in numbers)
            {
                string snt = hamhotro.KiemTraNguyenTo(x) ? "la SNT" : "khong la SNT";
                string chanle = x % 2 == 0 ? "so chan" : "so le";
                string hoanhao = KiemTraHoanHao(x) ? "la so hoan hao" : "khong la so hoan hao";
                Console.WriteLine($"   {x}: {chanle}, {snt}, {hoanhao}");
            }
        }
    }
}
```

#### kết quả

```text
Chọn bài: 9
--- BÀI 9: XỬ LÝ SỐ NGUYÊN ---
Nhap so phan tu (Enter = 5):
Phan loai va thong ke:
   3: so le, la SNT, khong la so hoan hao
   5: so le, la SNT, khong la so hoan hao
   7: so le, la SNT, khong la so hoan hao
```

### bài10

```csharp
using System;

namespace Buoi02_DanhSach
{
    static class B10C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 10: MA TRẬN XOẮN ỐC ---");
            int n = hamhotro.DocSo("Nhap cap ma tran n", 3);
            int[,] matrix = new int[n, n];
            int value = 1;
            int top = 0, bottom = n - 1, left = 0, right = n - 1;

            while (value <= n * n)
            {
                for (int i = left; i <= right; i++) matrix[top, i] = value++;
                top++;
                for (int i = top; i <= bottom; i++) matrix[i, right] = value++;
                right--;
                for (int i = right; i >= left; i--) matrix[bottom, i] = value++;
                bottom--;
                for (int i = bottom; i >= top; i--) matrix[i, left] = value++;
                left++;
            }

            Console.WriteLine("\nMa tran xoan oc:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }
    }
}
```

#### kết quả

```text
Chọn bài: 10
--- BÀI 10: MA TRẬN XOẮN ỐC ---
Nhap cap ma tran n (Enter = 3):
Ma tran xoan oc:
1	2	3
8	9	4
7	6	5
```

### bài11

```csharp
using System;

namespace Buoi02_DanhSach
{
    static class B11C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 11: KIỂM TRA MA TRẬN ĐẶC BIỆT ---");
            int n = hamhotro.DocSo("Nhap cap n", 3);
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = hamhotro.DocSo($"Nhap [{i},{j}]", i == j ? 1 : 0);

            bool isDonVi = true;
            bool isDoiXung = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && matrix[i, j] != 1) isDonVi = false;
                    if (i != j && matrix[i, j] != 0) isDonVi = false;
                    if (matrix[i, j] != matrix[j, i]) isDoiXung = false;
                }
            }

            Console.WriteLine(isDonVi ? "-> Day la ma tran don vi!" : "-> Khong phai ma tran don vi.");
            Console.WriteLine(isDoiXung ? "-> Day la ma tran doi xung!" : "-> Khong phai ma tran doi xung.");
        }
    }
}
```

#### kết quả

```text
Chọn bài: 11
--- BÀI 11: KIỂM TRA MA TRẬN ĐẶC BIỆT ---
Nhap cap n (Enter = 3):
-> Day la ma tran don vi!
-> Day la ma tran doi xung!
```

### bài12

```csharp
using System;

namespace Buoi02_DanhSach
{
    static class B12C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 12: GAME MINESWEEPER ---");
            int rows = hamhotro.DocSo("Nhap so dong", 3);
            int cols = hamhotro.DocSo("Nhap so cot", 3);
            int[,] board = new int[rows, cols];

            if (rows > 1 && cols > 2)
            {
                board[0, 1] = 99;
                board[1, 2] = 99;
            }

            Console.WriteLine("\nBan co mìn (X la co mìn):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i, j] == 99) Console.Write("X\t");
                    else Console.Write("0\t");
                }
                Console.WriteLine();
            }
        }
    }
}
```

#### kết quả

```text
Chọn bài: 12
--- BÀI 12: GAME MINESWEEPER ---
Nhap so dong (Enter = 3):
Nhap so cot (Enter = 3):
Ban co mìn (X la co mìn):
0	X	0
0	0	X
0	0	0
```

### bài13

```csharp
using System;

namespace Buoi02_DanhSach
{
    static class B13C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 13: ĐẢO NGƯỢC DANH SÁCH LIÊN KẾT ---");
            Node head = null;
            head = hamhotro.ThemCuoi(head, 1);
            head = hamhotro.ThemCuoi(head, 2);
            head = hamhotro.ThemCuoi(head, 3);

            Console.Write("Danh sach ban dau: ");
            hamhotro.InDSLK(head);

            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;

            Console.Write("Danh sach sau khi dao nguoc: ");
            hamhotro.InDSLK(head);
        }
    }
}
```

#### kết quả

```text
Chọn bài: 13
--- BÀI 13: ĐẢO NGƯỢC DANH SÁCH LIÊN KẾT ---
Danh sach ban dau: 1 -> 2 -> 3
Danh sach sau khi dao nguoc: 3 -> 2 -> 1
```

### bài14

```csharp
using System;

namespace Buoi02_DanhSach
{
    static class B14C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 14: GỘP HAI DANH SÁCH ĐÃ SẮP XẾP ---");
            Node l1 = null, l2 = null;
            l1 = hamhotro.ThemCuoi(l1, 1); l1 = hamhotro.ThemCuoi(l1, 3);
            l2 = hamhotro.ThemCuoi(l2, 2); l2 = hamhotro.ThemCuoi(l2, 4);

            Console.Write("DS1: "); hamhotro.InDSLK(l1);
            Console.Write("DS2: "); hamhotro.InDSLK(l2);

            Node gop = Gop(l1, l2);
            Console.Write("DS sau khi gop tang dan: ");
            hamhotro.InDSLK(gop);
        }

        static Node Gop(Node a, Node b)
        {
            if (a == null) return b;
            if (b == null) return a;
            if (a.Data <= b.Data)
            {
                a.Next = Gop(a.Next, b);
                return a;
            }
            else
            {
                b.Next = Gop(a, b.Next);
                return b;
            }
        }
    }
}
```

#### kết quả

```text
Chọn bài: 14
--- BÀI 14: GỘP HAI DANH SÁCH ĐÃ SẮP XẾP ---
DS1: 1 -> 3
DS2: 2 -> 4
DS sau khi gop tang dan: 1 -> 2 -> 3 -> 4
```

### bài15

```csharp
using System;

namespace Buoi02_DanhSach
{
    static class B15C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 15: PHÁT HIỆN CHU TRÌNH (RÙA VÀ THỎ) ---");
            Node head = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            head.Next = n2;
            n2.Next = n3;
            n3.Next = n2; // Tạo chu trình

            Node rua = head, tho = head;
            bool coChuTrinh = false;

            while (tho != null && tho.Next != null)
            {
                rua = rua.Next;
                tho = tho.Next.Next;
                if (rua == tho)
                {
                    coChuTrinh = true;
                    break;
                }
            }

            Console.WriteLine(coChuTrinh ? "-> Phat hien chu trinh trong danh sach!" : "-> Danh sach an toan, khong co chu trinh.");
        }
    }
}
```

#### kết quả

```text
Chọn bài: 15
--- BÀI 15: PHÁT HIỆN CHU TRÌNH (RÙA VÀ THỎ) ---
-> Phat hien chu trinh trong danh sach!
```

### bài16

```csharp
using System;

namespace Buoi02_DanhSach
{
    static class B16C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 16: LỊCH SỬ DUYỆT WEB DANH SÁCH KÉP ---");
            NodeKep trang1 = new NodeKep("Google.com");
            NodeKep trang2 = new NodeKep("Github.com");
            trang1.Next = trang2;
            trang2.Prev = trang1;

            NodeKep current = trang2;
            Console.WriteLine("Trang hien tai: " + current.Data);
            if (current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Nhan nut BACK -> " + current.Data);
            }
        }
    }
}
```

#### kết quả

```text
Chọn bài: 16
--- BÀI 16: LỊCH SỬ DUYỆT WEB DANH SÁCH KÉP ---
Trang hien tai: Github.com
Nhan nut BACK -> Google.com
```

### bài17

```csharp
using System;

namespace Buoi02_DanhSach
{
    static class B17C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 17: PLAYLIST NHẠC DANH SÁCH KÉP ---");
            NodeKep bai1 = new NodeKep("Bai_Hat_A");
            NodeKep bai2 = new NodeKep("Bai_Hat_B");
            bai1.Next = bai2;
            bai2.Prev = bai1;

            NodeKep current = bai1;
            Console.WriteLine("Dang phat: " + current.Data);
            if (current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Nhan NEXT -> Dang phat: " + current.Data);
            }
        }
    }
}
```

#### kết quả

```text
Chọn bài: 17
--- BÀI 17: PLAYLIST NHẠC DANH SÁCH KÉP ---
Dang phat: Bai_Hat_A
Nhan NEXT -> Dang phat: Bai_Hat_B
```

### bài18

```csharp
using System;

namespace Buoi02_DanhSach
{
    static class B18C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 18: QUẢN LÝ ĐƠN HÀNG DANH SÁCH KÉP ---");
            NodeKep don1 = new NodeKep("Don_Hang_01: Cho xu ly");
            NodeKep don2 = new NodeKep("Don_Hang_01: Dang giao");
            don1.Next = don2;
            don2.Prev = don1;

            NodeKep current = don1;
            Console.WriteLine("Trang thai hien tai: " + current.Data);
            if (current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Chuyen trang thai tiep theo -> " + current.Data);
            }
        }
    }
}
```

#### kết quả

```text
Chọn bài: 18
--- BÀI 18: QUẢN LÝ ĐƠN HÀNG DANH SÁCH KÉP ---
Trang thai hien tai: Don_Hang_01: Cho xu ly
Chuyen trang thai tiep theo -> Don_Hang_01: Dang giao
```
