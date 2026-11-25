# Buoi03_Stack_Queue

- Họ tên: Vũ Xuân Bắc 
- MSV: 10125036
- Lớp: 124251

## Bài đã làm

### chương5

| Bài | Nội dung |
|---|---|
| 1 | Kiểm tra tính đúng đắn của biểu thức toán học (Dùng Stack kiểm tra ngoặc) |
| 2 | Mô phỏng lịch sử trình duyệt web cơ bản (Dùng 2 Stack: Back và Forward) |
| 3 | Mô phỏng quá trình thực thi chương trình (Function Call Stack) |
| 4 | Mô phỏng hệ thống in ấn cơ bản (Dùng Queue) |
| 5 | Mô phỏng đường truyền dữ liệu cơ bản (Dùng Queue) |
| 6 | Mô phỏng quản lý hàng đợi tại Trung tâm Dịch vụ/Ngân hàng cơ bản (Dùng Queue) |
| 7 | Mô phỏng lịch sử trình duyệt Web nâng cao có Menu (Visit, Back, Forward) |
| 8 | Kiểm tra chuỗi ngoặc () đúng |
| 9 | Mô phỏng hệ thống in ấn (FIFO) có Menu quản lý chờ và in |
| 10 | Mô phỏng đường truyền dữ liệu trong mạng có Menu gửi và xử lý |
| 11 | Mô phỏng hàng đợi quản lý Dịch vụ Khách hàng ngân hàng có Menu |
| 12 | Tính giá trị của biểu thức toán học hậu tố (Postfix) |
| 13 | Kiểm tra tính hợp lệ của biểu thức trung tố toán học |
| 14 | Tính giá trị biểu thức trung tố toán học (Chuyển Infix sang Postfix bằng Ký pháp Ba Lan và tính kết quả) |

## Lệnh chạy

### chương5

```bash
dotnet run 1
dotnet run 2
dotnet run 3
dotnet run 4
dotnet run 5
dotnet run 6
dotnet run 7
dotnet run 8
dotnet run 9
dotnet run 10
dotnet run 11
dotnet run 12
dotnet run 13
dotnet run 14
```

## Kết quả chạy

### chương5

### bài1

```csharp
using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B1C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 1: KIỂM TRA TÍNH ĐÚNG ĐẮN CỦA BIỂU THỨC ---");
            string expression = hamhotro.DocChuoi("Nhập biểu thức kiểm tra", "{[()]}");
            Stack<char> stack = new Stack<char>();
            bool isValid = true;

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        isValid = false;
                        break;
                    }
                    char open = stack.Pop();
                    if ((c == ')' && open != '(') ||
                        (c == ']' && open != '[') ||
                        (c == '}' && open != '{'))
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            if (stack.Count > 0) isValid = false;

            if (isValid)
                Console.WriteLine("-> Kết quả: Biểu thức đúng cấu trúc ngoặc!");
            else
                Console.WriteLine("-> Kết quả: Biểu thức sai cấu trúc ngoặc!");
        }
    }
}
```

#### kết quả

```text
Chọn nhanh bài: 1
--- BÀI 1: KIỂM TRA TÍNH ĐÚNG ĐẮN CỦA BIỂU THỨC ---
Nhập biểu thức kiểm tra (Enter = "{[()]}"): 
-> Kết quả: Biểu thức đúng cấu trúc ngoặc!
```

### bài2

```csharp
using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B2C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 2: MÔ PHỎNG LỊCH SỬ DUYỆT WEB (CƠ BẢN) ---");
            Stack<string> backStack = new Stack<string>();
            Stack<string> forwardStack = new Stack<string>();
            string currentPage = "Trang_Chu";

            Console.WriteLine("Trang hiện tại: " + currentPage);

            Console.WriteLine("\n[Hành động] Truy cập 'Google.com'");
            backStack.Push(currentPage);
            currentPage = "Google.com";
            forwardStack.Clear();
            Console.WriteLine("Trang hiện tại: " + currentPage);

            Console.WriteLine("\n[Hành động] Truy cập 'Github.com'");
            backStack.Push(currentPage);
            currentPage = "Github.com";
            forwardStack.Clear();
            Console.WriteLine("Trang hiện tại: " + currentPage);

            Console.WriteLine("\n[Hành động] Nhấn nút 'BACK'");
            if (backStack.Count > 0)
            {
                forwardStack.Push(currentPage);
                currentPage = backStack.Pop();
            }
            Console.WriteLine("Trang hiện tại: " + currentPage);

            Console.WriteLine("\n[Hành động] Nhấn nút 'FORWARD'");
            if (forwardStack.Count > 0)
            {
                backStack.Push(currentPage);
                currentPage = forwardStack.Pop();
            }
            Console.WriteLine("Trang hiện tại: " + currentPage);
        }
    }
}
```

#### kết quả

```text
Chọn nhanh bài: 2
--- BÀI 2: MÔ PHỎNG LỊCH SỬ DUYỆT WEB (CƠ BẢN) ---
Trang hiện tại: Trang_Chu

[Hành động] Truy cập 'Google.com'
Trang hiện tại: Google.com

[Hành động] Truy cập 'Github.com'
Trang hiện tại: Github.com

[Hành động] Nhấn nút 'BACK'
Trang hiện tại: Google.com

[Hành động] Nhấn nút 'FORWARD'
Trang hiện tại: Github.com
```

### bài3

```csharp
using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B3C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 3: MÔ PHỎNG QUÁ TRÌNH THỰC THI (CALL STACK) ---");
            Stack<string> callStack = new Stack<string>();

            Console.WriteLine("Bắt đầu thực thi Main()");
            callStack.Push("Main()");

            Console.WriteLine("Main() gọi HamA()");
            callStack.Push("HamA()");

            Console.WriteLine("HamA() gọi HamB()");
            callStack.Push("HamB()");

            Console.WriteLine("\nDanh sách các hàm đang chờ trong Call Stack:");
            foreach (var func in callStack)
            {
                Console.WriteLine("   | " + func + " |");
            }
            Console.WriteLine("   +----------+");

            Console.WriteLine("\nHàmB() thực thi xong, quay về hàm gọi...");
            callStack.Pop();

            Console.WriteLine("HàmA() thực thi xong, quay về hàm gọi...");
            callStack.Pop();

            Console.WriteLine("\nTrạng thái Call Stack còn lại:");
            foreach (var func in callStack)
            {
                Console.WriteLine("   | " + func + " |");
            }
            Console.WriteLine("   +----------+");
        }
    }
}
```

#### kết quả

```text
Chọn nhanh bài: 3
--- BÀI 3: MÔ PHỎNG QUÁ TRÌNH THỰC THI (CALL STACK) ---
Bắt đầu thực thi Main()
Main() gọi HamA()
HamA() gọi HamB()

Danh sách các hàm đang chờ trong Call Stack:
   | HamB() |
   | HamA() |
   | Main() |
   +----------+

HàmB() thực thi xong, quay về hàm gọi...
HàmA() thực thi xong, quay về hàm gọi...

Trạng thái Call Stack còn lại:
   | Main() |
   +----------+
```

### bài4

```csharp
using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B4C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 4: MÔ PHỎNG HỆ THỐNG IN ẤN (CƠ BẢN) ---");
            Queue<string> printQueue = new Queue<string>();

            Console.WriteLine("Thêm tài liệu vào hàng đợi: BaoCao.pdf");
            printQueue.Enqueue("BaoCao.pdf");

            Console.WriteLine("Thêm tài liệu vào hàng đợi: HinhAnh.png");
            printQueue.Enqueue("HinhAnh.png");

            Console.WriteLine("Thêm tài liệu vào hàng đợi: BaiTap.docx");
            printQueue.Enqueue("BaiTap.docx");

            Console.WriteLine("\nBắt đầu in theo nguyên lý FIFO (First In First Out):");
            while (printQueue.Count > 0)
            {
                string doc = printQueue.Dequeue();
                Console.WriteLine(" -> Đang in: " + doc + " ... Hoàn thành!");
            }
        }
    }
}
```

#### kết quả

```text
Chọn nhanh bài: 4
--- BÀI 4: MÔ PHỎNG HỆ THỐNG IN ẤN (CƠ BẢN) ---
Thêm tài liệu vào hàng đợi: BaoCao.pdf
Thêm tài liệu vào hàng đợi: HinhAnh.png
Thêm tài liệu vào hàng đợi: BaiTap.docx

Bắt đầu in theo nguyên lý FIFO (First In First Out):
 -> Đang in: BaoCao.pdf ... Hoàn thành!
 -> Đang in: HinhAnh.png ... Hoàn thành!
 -> Đang in: BaiTap.docx ... Hoàn thành!
```

### bài5

```csharp
using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B5C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 5: MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU (CƠ BẢN) ---");
            Queue<string> networkQueue = new Queue<string>();

            Console.WriteLine("Gửi gói tin: Packet_1");
            networkQueue.Enqueue("Packet_1");

            Console.WriteLine("Gửi gói tin: Packet_2");
            networkQueue.Enqueue("Packet_2");

            Console.WriteLine("Gửi gói tin: Packet_3");
            networkQueue.Enqueue("Packet_3");

            Console.WriteLine("\nBộ đệm mạng xử lý và truyền gói tin đến đích:");
            while (networkQueue.Count > 0)
            {
                string packet = networkQueue.Dequeue();
                Console.WriteLine(" -> Đang truyền gói tin: " + packet + " ... Thành công!");
            }
        }
    }
}
```

#### kết quả

```text
Chọn nhanh bài: 5
--- BÀI 5: MÔ PHỎNG ĐƯỜNG TRUYỀN DỮ LIỆU (CƠ BẢN) ---
Gửi gói tin: Packet_1
Gửi gói tin: Packet_2
Gửi gói tin: Packet_3

Bộ đệm mạng xử lý và truyền gói tin đến đích:
 -> Đang truyền gói tin: Packet_1 ... Thành công!
 -> Đang truyền gói tin: Packet_2 ... Thành công!
 -> Đang truyền gói tin: Packet_3 ... Thành công!
```

### bài6

```csharp
using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B6C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 6: QUẢN LÝ HÀNG ĐỢI DỊCH VỤ / NGÂN HÀNG (CƠ BẢN) ---");
            Queue<string> customers = new Queue<string>();

            Console.WriteLine("Khách hàng Nguyễn Văn A vào hàng đợi.");
            customers.Enqueue("Nguyễn Văn A");

            Console.WriteLine("Khách hàng Trần Thị B vào hàng đợi.");
            customers.Enqueue("Trần Thị B");

            Console.WriteLine("Khách hàng Lê Văn C vào hàng đợi.");
            customers.Enqueue("Lê Văn C");

            Console.WriteLine("\nBắt đầu gọi phục vụ theo lượt xếp hàng:");
            while (customers.Count > 0)
            {
                string client = customers.Dequeue();
                Console.WriteLine(" -> Mời khách hàng: " + client + " vào quầy phục vụ... Xong!");
            }
        }
    }
}
```

#### kết quả

```text
Chọn nhanh bài: 6
--- BÀI 6: QUẢN LÝ HÀNG ĐỢI DỊCH VỤ / NGÂN HÀNG (CƠ BẢN) ---
Khách hàng Nguyễn Văn A vào hàng đợi.
Khách hàng Trần Thị B vào hàng đợi.
Khách hàng Lê Văn C vào hàng đợi.

Bắt đầu gọi phục vụ theo lượt xếp hàng:
 -> Mời khách hàng: Nguyễn Văn A vào quầy phục vụ... Xong!
 -> Mời khách hàng: Trần Thị B vào quầy phục vụ... Xong!
 -> Mời khách hàng: Lê Văn C vào quầy phục vụ... Xong!
```

### bài7

```csharp
using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B7C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 7: LỊCH SỬ TRÌNH DUYỆT WEB NÂNG CAO ---");
            Stack<string> backStack = new Stack<string>();
            Stack<string> forwardStack = new Stack<string>();
            string currentPage = "homepage.com";

            while (true)
            {
                Console.WriteLine("\n=== MÔ PHỎNG TRÌNH DUYỆT ===");
                Console.WriteLine("1. Truy cập trang mới (Visit)");
                Console.WriteLine("2. Quay lại (Back)");
                Console.WriteLine("3. Tiến lên (Forward)");
                Console.WriteLine("4. Hiển thị trang hiện tại");
                Console.WriteLine("0. Quay lại Menu chính");
                int chon = hamhotro.DocSo("Chọn chức năng", 4);

                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        string url = hamhotro.DocChuoi("Nhập địa chỉ URL trang mới", "youtube.com");
                        backStack.Push(currentPage);
                        currentPage = url;
                        forwardStack.Clear();
                        Console.WriteLine(" -> Đang truy cập: " + currentPage);
                        break;
                    case 2:
                        if (backStack.Count > 0)
                        {
                            forwardStack.Push(currentPage);
                            currentPage = backStack.Pop();
                            Console.WriteLine(" -> Quay lại thành công: " + currentPage);
                        }
                        else Console.WriteLine(" -> Lỗi: Không thể BACK (Lịch sử rỗng)!");
                        break;
                    case 3:
                        if (forwardStack.Count > 0)
                        {
                            backStack.Push(currentPage);
                            currentPage = forwardStack.Pop();
                            Console.WriteLine(" -> Tiến lên thành công: " + currentPage);
                        }
                        else Console.WriteLine(" -> Lỗi: Không thể FORWARD!");
                        break;
                    case 4:
                        Console.WriteLine(" -> Trang hiện tại: " + currentPage);
                        break;
                    default:
                        Console.WriteLine(" -> Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
    }
}
```

#### kết quả

```text
Chọn nhanh bài: 7
--- BÀI 7: LỊCH SỬ TRÌNH DUYỆT WEB NÂNG CAO ---

=== MÔ PHỎNG TRÌNH DUYỆT ===
1. Truy cập trang mới (Visit)
2. Quay lại (Back)
3. Tiến lên (Forward)
4. Hiển thị trang hiện tại
0. Quay lại Menu chính
Chọn chức năng (Enter = 4): 1
Nhập địa chỉ URL trang mới (Enter = "youtube.com"): 
 -> Đang truy cập: youtube.com
```

### bài8

```csharp
using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B8C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 8: KIỂM TRA CHUỖI NGOẶC () ĐÚNG ---");
            string s = hamhotro.DocChuoi("Nhập chuỗi ngoặc tròn", "(())()");
            Stack<char> stack = new Stack<char>();
            bool isValid = true;

            foreach (char c in s)
            {
                if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                    {
                        isValid = false;
                        break;
                    }
                    stack.Pop();
                }
            }

            if (stack.Count > 0) isValid = false;

            if (isValid)
                Console.WriteLine("-> Kết quả: Xâu đúng cấu trúc ngoặc tròn!");
            else
                Console.WriteLine("-> Kết quả: Xâu sai cấu trúc ngoặc tròn!");
        }
    }
}
```

#### kết quả

```text
Chọn nhanh bài: 8
--- BÀI 8: KIỂM TRA CHUỖI NGOẶC () ĐÚNG ---
Nhập chuỗi ngoặc tròn (Enter = "(())()"): 
-> Kết quả: Xâu đúng cấu trúc ngoặc tròn!
```

### bài9

```csharp
using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B9C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 9: HỆ THỐNG IN ẤN (FIFO NÂNG CAO) ---");
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("\n=== MENU IN ẤN ===");
                Console.WriteLine("1. Thêm yêu cầu in mới");
                Console.WriteLine("2. Thực hiện in tài liệu");
                Console.WriteLine("3. Hiển thị danh sách đang chờ in");
                Console.WriteLine("0. Quay lại Menu chính");
                int chon = hamhotro.DocSo("Chọn", 1);

                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        string file = hamhotro.DocChuoi("Nhập tên tài liệu in", "Tailieu.pdf");
                        queue.Enqueue(file);
                        Console.WriteLine($" -> Đã thêm '{file}' vào danh sách chờ.");
                        break;
                    case 2:
                        if (queue.Count > 0)
                        {
                            Console.WriteLine(" -> ĐANG IN: " + queue.Dequeue() + " ... Hoàn thành 100%!");
                        }
                        else Console.WriteLine(" -> Không có yêu cầu in nào trong hàng đợi!");
                        break;
                    case 3:
                        Console.Write(" -> Tài liệu chờ in: ");
                        if (queue.Count == 0) Console.Write("(Rỗng)");
                        foreach (var f in queue) Console.Write(f + " | ");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
```

#### kết quả

```text
Chọn nhanh bài: 9
--- BÀI 9: HỆ THỐNG IN ẤN (FIFO NÂNG CAO) ---

=== MENU IN ẤN ===
1. Thêm yêu cầu in mới
2. Thực hiện in tài liệu
3. Hiển thị danh sách đang chờ in
0. Quay lại Menu chính
Chọn (Enter = 1): 
Nhập tên tài liệu in (Enter = "Tailieu.pdf"): 
 -> Đã thêm 'Tailieu.pdf' vào danh sách chờ.
```

### bài10

```csharp
using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B10C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 10: ĐƯỜNG TRUYỀN DỮ LIỆU MẠNG NÂNG CAO ---");
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("\n=== BỘ ĐỆM ĐƯỜNG TRUYỀN MẠNG ===");
                Console.WriteLine("1. Gửi gói tin mạng mới");
                Console.WriteLine("2. Tiếp nhận và xử lý gói tin");
                Console.WriteLine("3. Hiển thị các gói tin đang chờ truyền");
                Console.WriteLine("0. Quay lại Menu chính");
                int chon = hamhotro.DocSo("Chọn", 1);

                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        string packet = hamhotro.DocChuoi("Nhập tên gói tin mạng", "Packet_A");
                        queue.Enqueue(packet);
                        Console.WriteLine($" -> Đã đưa gói tin '{packet}' vào hàng đợi.");
                        break;
                    case 2:
                        if (queue.Count > 0)
                        {
                            Console.WriteLine(" -> ĐANG TRUYỀN: " + queue.Dequeue() + " ... Thành công!");
                        }
                        else Console.WriteLine(" -> Bộ đệm rỗng, không có gói tin để truyền!");
                        break;
                    case 3:
                        Console.Write(" -> Các gói tin đang xếp hàng: ");
                        if (queue.Count == 0) Console.Write("(Trống)");
                        foreach (var p in queue) Console.Write(p + " | ");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
```

#### kết quả

```text
Chọn nhanh bài: 10
--- BÀI 10: ĐƯỜNG TRUYỀN DỮ LIỆU MẠNG NÂNG CAO ---

=== BỘ ĐỆM ĐƯỜNG TRUYỀN MẠNG ===
1. Gửi gói tin mạng mới
2. Tiếp nhận và xử lý gói tin
3. Hiển thị các gói tin đang chờ truyền
0. Quay lại Menu chính
Chọn (Enter = 1): 
Nhập tên gói tin mạng (Enter = "Packet_A"): 
 -> Đã đưa gói tin 'Packet_A' vào hàng đợi.
```

### bài11

```csharp
using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B11C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 11: QUẢN LÝ DỊCH VỤ KHÁCH HÀNG NGÂN HÀNG ---");
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("\n=== QUẦY GIAO DỊCH NGÂN HÀNG ===");
                Console.WriteLine("1. Khách hàng mới lấy số (Xếp hàng)");
                Console.WriteLine("2. Mời số tiếp theo vào quầy (Phục vụ)");
                Console.WriteLine("3. Hiển thị các khách hàng đang chờ");
                Console.WriteLine("0. Quay lại Menu chính");
                int chon = hamhotro.DocSo("Chọn", 1);

                if (chon == 0) break;
                switch (chon)
                {
                    case 1:
                        string name = hamhotro.DocChuoi("Nhập tên khách hàng", "Vũ Văn Long");
                        queue.Enqueue(name);
                        Console.WriteLine($" -> Khách hàng '{name}' đã nhận số thứ tự thành công.");
                        break;
                    case 2:
                        if (queue.Count > 0)
                        {
                            Console.WriteLine(" -> ĐANG PHỤC VỤ khách hàng: " + queue.Dequeue() + " ... Giao dịch hoàn tất!");
                        }
                        else Console.WriteLine(" -> Hiện không có khách hàng nào đang đợi!");
                        break;
                    case 3:
                        Console.Write(" -> Danh sách khách hàng xếp hàng: ");
                        if (queue.Count == 0) Console.Write("(Trống)");
                        foreach (var k in queue) Console.Write(k + " | ");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
```

#### kết quả

```text
Chọn nhanh bài: 11
--- BÀI 11: QUẢN LÝ DỊCH VỤ KHÁCH HÀNG NGÂN HÀNG ---

=== QUẦY GIAO DỊCH NGÂN HÀNG ===
1. Khách hàng mới lấy số (Xếp hàng)
2. Mời số tiếp theo vào quầy (Phục vụ)
3. Hiển thị các khách hàng đang chờ
0. Quay lại Menu chính
Chọn (Enter = 1): 
Nhập tên khách hàng (Enter = "Vũ Văn Long"): 
 -> Khách hàng 'Vũ Văn Long' đã nhận số thứ tự thành công.
```

### bài12

```csharp
using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B12C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 12: TÍNH GIÁ TRỊ BIỂU THỨC HẬU TỐ ---");
            Console.WriteLine("(Lưu ý: Các toán tử và toán hạng phải cách nhau bằng khoảng trắng. Ví dụ: 3 4 2 * +)");
            string postfix = hamhotro.DocChuoi("Nhập biểu thức hậu tố", "3 4 2 * +");
            
            try
            {
                string[] tokens = postfix.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Stack<double> stack = new Stack<double>();

                foreach (string token in tokens)
                {
                    double val;
                    if (double.TryParse(token, out val))
                    {
                        stack.Push(val);
                    }
                    else
                    {
                        double b = stack.Pop();
                        double a = stack.Pop();
                        switch (token)
                        {
                            case "+": stack.Push(a + b); break;
                            case "-": stack.Push(a - b); break;
                            case "*": stack.Push(a * b); break;
                            case "/": stack.Push(a / b); break;
                            default: throw new InvalidOperationException("Toán tử không hợp lệ!");
                        }
                    }
                }
                Console.WriteLine("-> Kết quả tính toán hậu tố: " + stack.Pop());
            }
            catch (Exception)
            {
                Console.WriteLine(" -> Lỗi: Biểu thức hậu tố sai cấu trúc hoặc thiếu khoảng trắng!");
            }
        }
    }
}
```

#### kết quả

```text
Chọn nhanh bài: 12
--- BÀI 12: TÍNH GIÁ TRỊ BIỂU THỨC HẬU TỐ ---
(Lưu ý: Các toán tử và toán hạng phải cách nhau bằng khoảng trắng. Ví dụ: 3 4 2 * +)
Nhập biểu thức hậu tố (Enter = "3 4 2 * +"): 
-> Kết quả tính toán hậu tố: 11
```

### bài13

```csharp
using System;
using System.Collections.Generic;

namespace Buoi03_Stack_Queue
{
    static class B13C5
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 13: KIỂM TRA TÍNH HỢP LỆ TRUNG TỐ ---");
            string infix = hamhotro.DocChuoi("Nhập biểu thức trung tố", "[(3+4)*2]");
            Stack<char> stack = new Stack<char>();
            bool isValid = true;

            foreach (char c in infix)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        isValid = false;
                        break;
                    }
                    char open = stack.Pop();
                    if ((c == ')' && open != '(') ||
                        (c == ']' && open != '[') ||
                        (c == '}' && open != '{'))
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            if (stack.Count > 0) isValid = false;

            if (isValid)
                Console.WriteLine(" -> Kết quả: Biểu thức trung tố HỢP LỆ!");
            else
                Console.WriteLine(" -> Kết quả: Biểu thức trung tố KHÔNG HỢP LỆ!");
        }
    }
}
```

#### kết quả

```text
Chọn nhanh bài: 13
--- BÀI 13: KIỂM TRA TÍNH HỢP LỆ TRUNG TỐ ---
Nhập biểu thức trung tố (Enter = "[(3+4)*2]"): 
 -> Kết quả: Biểu thức trung tố HỢP LỆ!
```

### bài14

```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi03_Stack_Queue
{
    static class B14C5
    {
        static bool IsOperand(string s)
        {
            double num;
            return double.TryParse(s, out num);
        }

        static int Pri(string op)
        {
            if (op == "+" || op == "-") return 1;
            if (op == "*" || op == "/") return 2;
            return 0;
        }

        static string HauTo(string infixExpression)
        {
            Stack<string> St = new Stack<string>();
            StringBuilder E1 = new StringBuilder();
            string[] tokens = infixExpression.Split(' ');

            foreach (string s in tokens)
            {
                if (string.IsNullOrWhiteSpace(s)) continue;

                if (s == "(")
                {
                    St.Push(s);
                }
                else if (s == ")")
                {
                    while (St.Count > 0 && St.Peek() != "(")
                    {
                        E1.Append(St.Pop()).Append(" ");
                    }
                    if (St.Count > 0) St.Pop(); 
                }
                else if (IsOperand(s))
                {
                    E1.Append(s).Append(" ");
                }
                else 
                {
                    while (St.Count > 0 && Pri(St.Peek()) >= Pri(s))
                    {
                        E1.Append(St.Pop()).Append(" ");
                    }
                    St.Push(s);
                }
            }

            while (St.Count > 0)
            {
                E1.Append(St.Pop()).Append(" ");
            }

            return E1.ToString().Trim();
        }

        
        static double TinhHauTo(string postfix)
        {
            string[] tokens = postfix.Split(' ');
            Stack<double> stack = new Stack<double>();

            foreach (string token in tokens)
            {
                if (string.IsNullOrWhiteSpace(token)) continue;

                double val;
                if (double.TryParse(token, out val))
                {
                    stack.Push(val);
                }
                else
                {
                    double b = stack.Pop();
                    double a = stack.Pop();
                    switch (token)
                    {
                        case "+": stack.Push(a + b); break;
                        case "-": stack.Push(a - b); break;
                        case "*": stack.Push(a * b); break;
                        case "/": stack.Push(a / b); break;
                    }
                }
            }
            return stack.Pop();
        }

        public static void Run()
        {
            Console.WriteLine("--- BÀI 14: TÍNH GIÁ TRỊ BIỂU THỨC TRUNG TỐ ---");
            Console.WriteLine("(Lưu ý: Các phần tử toán tử và toán hạng cách nhau bằng khoảng trắng. Ví dụ: 3 + 4 * 2)");
            string infix = hamhotro.DocChuoi("Nhập biểu thức trung tố", "3 + 4 * 2");

            try
            {
                string postfix = HauTo(infix);
                Console.WriteLine("-> Biểu thức hậu tố (Postfix): " + postfix);

                double ketQua = TinhHauTo(postfix);
                Console.WriteLine("-> Kết quả tính toán biểu thức: " + ketQua);
            }
            catch (Exception)
            {
                Console.WriteLine("Biểu thức không hợp lệ! Vui lòng kiểm tra lại khoảng trắng giữa các phần tử.");
            }
        }
    }
}
```

#### kết quả

```text
Chọn nhanh bài: 14
--- BÀI 14: TÍNH GIÁ TRỊ BIỂU THỨC TRUNG TỐ ---
(Lưu ý: Các phần tử toán tử và toán hạng cách nhau bằng khoảng trắng. Ví dụ: 3 + 4 * 2)
Nhập biểu thức trung tố (Enter = "3 + 4 * 2"): 
-> Biểu thức hậu tố (Postfix): 3 4 2 * +
-> Kết quả tính toán biểu thức: 11
```
