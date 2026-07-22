# Table of Contents
[1. Giới thiệu](#1-giới-thiệu)

[2. Tổng quan về C#](#2-tổng-quan-về-c)

[3. Syntax cơ bản trong C#](#3-syntax-cơ-bản-trong-c)

[4. Cấu trúc điều khiển trong C#](#4-cấu-trúc-điều-khiển-trong-c)

[5. Hàm và mảng trong C#](#5-hàm-và-mảng-trong-c)

[6. Lập trình hướng đối tượng (OOP)](#6-lập-trình-hướng-đối-tượng-oop)

[7. Bốn tính chất của OOP](#7-bốn-tính-chất-của-oop)

[8. Ví dụ chương trình OOP trong C#](#8-ví-dụ-chương-trình-oop-trong-c)

[9. Ưu điểm của C# và OOP](#9-ưu-điểm-của-c-và-oop)

[10. Kết luận](#10-kết-luận)

[11. Trả lời các câu hỏi hướng dẫn](#11-trả-lời-các-câu-hỏi-hướng-dẫn)

[12. Oracle database trong C#](#12-oracle-database-trong-c)
# BÁO CÁO  
# TÌM HIỂU VỀ SYNTAX C# VÀ LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG (OOP)
## 1. Giới thiệu
C# là một trong những ngôn ngữ lập trình hiện đại được phát triển bởi Microsoft trên nền tảng .NET.  
Với cú pháp rõ ràng, dễ học và hỗ trợ mạnh lập trình hướng đối tượng (OOP), C# hiện nay được sử dụng rộng rãi trong việc phát triển:
- Ứng dụng desktop
- Website
- API Backend
- Game Unity
- Hệ thống doanh nghiệp
Báo cáo này trình bày những kiến thức cơ bản về syntax C# và các khái niệm quan trọng trong lập trình hướng đối tượng.

---

# 2. Tổng quan về C#

## 2.1 C# là gì?

C# (C Sharp) là ngôn ngữ lập trình hướng đối tượng được Microsoft phát triển vào năm 2000.

Đặc điểm:
- Hiện đại
- Dễ học
- Bảo mật cao
- Hỗ trợ đa nền tảng
- Tích hợp mạnh với .NET

---

## 2.2 Ứng dụng của C#

C# được sử dụng để xây dựng:

- Console Application
- Windows Forms
- WPF
- ASP.NET Web
- API Backend
- Game Unity
- Phần mềm quản lý doanh nghiệp

---

# 3. Syntax cơ bản trong C#

## 3.1 Cấu trúc chương trình C#

Ví dụ chương trình đầu tiên:

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World");
    }
}
```

### Giải thích

- `using System`: sử dụng thư viện System
- `class Program`: khai báo lớp
- `Main()`: hàm chính của chương trình
- `Console.WriteLine()`: in dữ liệu ra màn hình

---

## 3.2 Biến và kiểu dữ liệu

Ví dụ:

```csharp
int age = 20;
double score = 8.5;
char grade = 'A';
string name = "Huân";
bool check = true;
```

### Một số kiểu dữ liệu phổ biến

| Kiểu dữ liệu | Ý nghĩa |
|---|---|
| int | Số nguyên |
| double | Số thực |
| char | Ký tự |
| string | Chuỗi |
| bool | Đúng/Sai |

---

## 3.3 Nhập xuất dữ liệu

```csharp
Console.Write("Nhap ten: ");
string ten = Console.ReadLine();

Console.WriteLine("Xin chao " + ten);
```

---

# 4. Cấu trúc điều khiển trong C#

## 4.1 Câu lệnh điều kiện

### if - else

```csharp
int x = 10;

if(x > 0)
{
    Console.WriteLine("So duong");
}
else
{
    Console.WriteLine("So am");
}
```

---

## 4.2 Switch Case

Ví dụ

```csharp
int day = 2;

switch(day)
{
    case 1:
        Console.WriteLine("Thu hai");
        break;

    case 2:
        Console.WriteLine("Thu ba");
        break;
}
```

---

## 4.3 Vòng lặp

### for

```csharp
for(int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

### while

```csharp
int i = 1;

while(i <= 5)
{
    Console.WriteLine(i);
    i++;
}
```

---

# 5. Hàm và mảng trong C#

## 5.2 Mảng (Array)

Mảng là tập hợp nhiều phần tử có cùng kiểu dữ liệu và được lưu liên tiếp trong bộ nhớ.

Ví dụ:

```csharp
int[] a = {1, 2, 3, 4, 5};

foreach(int x in a)
{
    Console.WriteLine(x);
}
```

### Tính chất của mảng

- Các phần tử cùng kiểu dữ liệu
- Kích thước cố định sau khi khởi tạo
- Truy cập phần tử bằng chỉ số index
- Index bắt đầu từ 0

Ví dụ:

```csharp
Console.WriteLine(a[0]);
```

### Mảng có thể null

```csharp
int[] a = null;
```

Mảng null khác với mảng rỗng:

```csharp
int[] a = new int[0];
```

---

## 5.3 List

`List` là cấu trúc dữ liệu động trong C# dùng để lưu danh sách phần tử.

Ví dụ:

```csharp
List<int> ds = new List<int>();

ds.Add(10);
ds.Add(20);
```

### Một số hàm phổ biến

```csharp
ds.Add(30);      // thêm phần tử
ds.Remove(20);   // xóa phần tử
ds.Count;        // số lượng phần tử
```

### Tính chất của List

- Kích thước động
- Có thể thêm/xóa phần tử
- Truy cập bằng index giống mảng
- Chỉ lưu một kiểu dữ liệu

Ví dụ:

```csharp
Console.WriteLine(ds[0]);
```

### So sánh Array và List

| Array | List |
|---|---|
| Kích thước cố định | Kích thước động |
| Tốc độ nhanh hơn | Linh hoạt hơn |
| Khó thêm/xóa | Dễ thêm/xóa |

---

## 5.4 Dictionary

`Dictionary` là cấu trúc dữ liệu lưu theo dạng:

```text
Key -> Value
```

Mỗi key là duy nhất và dùng để truy xuất dữ liệu nhanh.

Ví dụ:

```csharp
Dictionary<string, int> diem = new Dictionary<string, int>();

diem["An"] = 8;
diem["Binh"] = 9;

Console.WriteLine(diem["An"]);
```

### Tính chất của Dictionary

- Lưu dữ liệu theo cặp `key-value`
- Key không được trùng nhau, nếu key trùng, value trước sẽ bị value sau ghi đè
- Tìm kiếm dữ liệu nhanh
- Không lưu theo thứ tự index như mảng

### Một số hàm phổ biến

```csharp
diem.Add("Cuong", 10);

diem.Remove("An");

Console.WriteLine(diem.ContainsKey("Binh"));
```

### Duyệt Dictionary

```csharp
foreach(var item in diem)
{
    Console.WriteLine(item.Key + " " + item.Value);
}
```

## 5.5 HashSet

`HashSet` là cấu trúc dữ liệu dùng để lưu các phần tử không trùng lặp.

HashSet sử dụng cơ chế hashing nên:
- thêm phần tử nhanh
- tìm kiếm nhanh
- xóa nhanh

### Ví dụ:

```csharp
using System.Collections.Generic;

HashSet<int> set = new HashSet<int>();

set.Add(1);
set.Add(2);
set.Add(2);
set.Add(3);

foreach(int x in set)
{
    Console.WriteLine(x);
}
```

Kết quả:

```text
1
2
3
```

Phần tử `2` chỉ xuất hiện một lần vì HashSet không cho phép dữ liệu trùng nhau.

## Tính chất của HashSet

- Không cho phép phần tử trùng
- Không có index như mảng hoặc List
- Tìm kiếm nhanh với độ phức tạp trung bình O(1)
- Không đảm bảo thứ tự phần tử

## Một số hàm phổ biến

```csharp
set.Add(5);          // thêm phần tử

set.Remove(2);       // xóa phần tử

set.Contains(3);     // kiểm tra tồn tại

set.Count;           // số lượng phần tử

set.Clear();         // xóa toàn bộ
```

## So sánh HashSet và List

| HashSet | List |
|---|---|
| Không cho phép trùng | Cho phép trùng |
| Tìm kiếm nhanh hơn | Tìm kiếm chậm hơn |
| Không có index | Có index |

## Ví dụ ứng dụng

Loại bỏ phần tử trùng trong mảng:

```csharp
int[] a = {1,2,2,3,4,4,5};

HashSet<int> set = new HashSet<int>(a);

foreach(int x in set)
{
    Console.WriteLine(x);
}
```
---

# 6. Lập trình hướng đối tượng (OOP)

## 6.1 Khái niệm

Lập trình hướng đối tượng (Object-Oriented Programming) là phương pháp lập trình dựa trên đối tượng.

Mỗi đối tượng gồm:
- Thuộc tính
- Phương thức

Ví dụ:

```csharp
class SinhVien
{
    public string Ten;
    public int Tuoi;

    public void HienThi()
    {
        Console.WriteLine(Ten);
    }
}
```

---

## 6.2 Class và Object

- Class: khuôn mẫu tạo đối tượng
- Object: đối tượng được tạo từ class

Ví dụ:

```csharp
SinhVien sv = new SinhVien();
```
Trong đó: 

`SinhVien` là class

`sv` là Object

## 6.3 Acces Modifiers
Access Modifier là các từ khóa dùng để quy định phạm vi truy cập của:
- biến
- thuộc tính
- method
- class

Trong C#, có 4 access modifier phổ biến:

| Modifier | Phạm vi truy cập |
|---|---|
| public | Truy cập được ở mọi nơi |
| private | Chỉ truy cập trong cùng class |
| protected | Truy cập trong class cha và class con |
| internal | Truy cập trong cùng project/assembly |

---

## 6.3.1 Public

`public` cho phép truy cập từ bất kỳ đâu.

Ví dụ:

```csharp
class SinhVien
{
    public string ten = "Nguyen Van A";
}

class Program
{
    static void Main()
    {
        SinhVien sv = new SinhVien();

        Console.WriteLine(sv.ten);
    }
}
```

### Ý nghĩa

- Có thể sử dụng ở mọi nơi
- Thường dùng cho method hoặc thuộc tính cần truy cập bên ngoài

---

## 6.3.2 Private

`private` chỉ cho phép truy cập bên trong chính class đó.

Ví dụ:

```csharp
class SinhVien
{
    private double diem = 8.5;

    public void HienThi()
    {
        Console.WriteLine(diem);
    }
}
```

### Ý nghĩa

- Bảo vệ dữ liệu
- Không cho truy cập trực tiếp từ bên ngoài
- Thể hiện tính đóng gói (Encapsulation)

---

## 6.3.3 Protected

`protected` cho phép:
- class hiện tại truy cập
- class kế thừa truy cập

Ví dụ:

```csharp
class Nguoi
{
    protected string hoTen = "Nguyen Van A";
}

class SinhVien : Nguoi
{
    public void HienThi()
    {
        Console.WriteLine(hoTen);
    }
}
```

### Ý nghĩa

- Hỗ trợ kế thừa
- Cho phép class con sử dụng dữ liệu của class cha

---

## 6.3.4 Internal

`internal` chỉ cho phép truy cập trong cùng project (assembly).

Ví dụ:

```csharp
internal class SinhVien
{
    public string ten = "Nguyen Van A";
}
```

### Ý nghĩa

- Dùng khi chỉ muốn sử dụng class trong cùng project
- Không cho project khác truy cập

---

## So sánh các Modifier

| Modifier | Cùng class | Class con | Cùng project | Bên ngoài project |
|---|---|---|---|---|
| public | ✓ | ✓ | ✓ | ✓ |
| private | ✓ | ✗ | ✗ | ✗ |
| protected | ✓ | ✓ | ✗ | ✗ |
| internal | ✓ | ✓ | ✓ | ✗ |
---
# 7. Bốn tính chất của OOP


## 7.1 Đóng gói (Encapsulation)

Là việc che giấu dữ liệu bên trong đối tượng.

[Ví dụ đóng gói trong OOP](OOP/tinhdonggoi.cs)

### Ý nghĩa

- Bảo vệ dữ liệu
- Hạn chế truy cập trực tiếp
- Tăng tính bảo mật

---

## 7.2 Kế thừa (Inheritance)

Cho phép lớp con sử dụng lại thuộc tính và phương thức của lớp cha.

[Ví dụ kế thừa trong OOP](OOP/oopkethua.cs)
---

## 7.3 Đa hình (Polymorphism)

Một phương thức có nhiều cách thực hiện khác nhau.

[Ví dụ đa hình trong OOP](OOP/oopdahinh.cs)

---

## 7.4 Trừu tượng (Abstraction)

Ẩn đi các chi tiết phức tạp và chỉ hiển thị chức năng cần thiết.

[Ví dụ trừu tượng trong OOP](OOP/ooptrutuong.cs)

---

# 8. Ví dụ chương trình OOP trong C#

[Bài tập hóa đơn quần áo](OOP/hoadonqao.cs)

---

# 9. Ưu điểm của C# và OOP

## 9.1 Ưu điểm của C#

- Dễ học
- Cú pháp rõ ràng
- Thư viện mạnh
- Hỗ trợ đa nền tảng
- Tích hợp tốt với .NET

---

## 9.2 Ưu điểm của OOP

- Dễ quản lý code
- Dễ mở rộng
- Dễ bảo trì
- Tái sử dụng mã nguồn tốt

---

# 10. Kết luận

Qua quá trình tìm hiểu, có thể thấy C# là ngôn ngữ lập trình hiện đại, mạnh mẽ và phù hợp với nhiều lĩnh vực phát triển phần mềm.

Bên cạnh đó, lập trình hướng đối tượng giúp chương trình:
- Có cấu trúc rõ ràng
- Dễ quản lý
- Dễ mở rộng
- Dễ bảo trì

Việc nắm vững syntax C# và OOP là nền tảng quan trọng cho quá trình học tập và làm việc trong lĩnh vực công nghệ thông tin.

# 11. Trả lời các câu hỏi hướng dẫn
## 11.1. Trong 1 project C# muốn để nhiều file .cs mà vẫn có thể chạy từng file ta làm thế nào

Cách 1: Thay vì chạy ```dotnet run``` thì chạy lệnh 
```bash 
dotnet run --file tenfile.cs
```
Cách 2: Sử dụng 
```bash
dotnet run -p:StartupObject= “tên class chứa Main()”
```
Với cách thứ 2 cần phải phân biệt class chứa Main() của từng file.
Nếu class chứa Main() của 2 file bị trùng thì cần phải đưa vào namespace khác nhau. Sau đó chạy 
```bash
dotnet run -p:StartupObject= “tên namespace.tên class chứa Main()”
```
Ví dụ
```bash
dotnet run -p:StartupObject= “oopkethua.Oopkethua”
```
khi muốn chạy file [oopkethua](OOP/oopkethua.cs)

## 11.2. Một mảng có thể null không. Khi nào một mảng có thể null

Trả lời:

Trong C#, một mảng có thể mang giá trị ```null```

Mảng có thể null khi:
-Khai báo mảng null.
Ví dụ 
```csharp
int[] a = null;
```
-Được gán lại thành null
```csharp
int[] a = new int[5]; 
a = null;
```
-Gặp 1 hàm trả về null
```csharp
static int[] GetData() 
{ 
    return null; 
    }
```
Phân biệt null và mảng rỗng 
-Mảng null là mảng chưa có "mảng" thật, chưa cấp phát bộ nhớ cho phần tử, truy cập phần tử sẽ gây lỗi.
-Mảng rỗng có mảng thật,các phần tử đc gán giá trị bằng 0, truy cập không bị lỗi.
-Phần tử trong mảng với kiểu dữ liệu string có thể null, với kiểu dữ liệu int các phần tử ko gán được null.
Muốn phần tử int nhận null thì phải ép kiểu 
Ví dụ 
```csharp
int?[] a = new int?[3];

a[0] = null;
a[1] = 5;
```
## 11.3.Tối ưu bài toán giao2mang
[toiuugiao2mang](Array/toiuugiao2mang.cs)

Ở cách làm cũ, bài toán giao 2 mảng được thực hiện với độ phức tạp là O(n+m+1001)

Sau khi tối ưu bằng cách sử dụng Hashset, độ phức tạp rút gọn còn O(n+m)
## 11.4. Bài toàn mangdoixung không muốn có hàm check riêng

Có 2 hướng giải quyết:

C1: Chuyển hàm check vào trong Main()

[code đã sửa](Array/mangdoixung.cs)

C2: Thêm biến check đặt giá trị bằng 1 nếu mảng ko thỏa mãn gán biến bằng 0

Khi hết vòng lặp kiểm tra biến check

[cách 2](Array/mangdoixung2.cs)

## 11.5. Các modifier khác ngoài private và public

[6.3 Access Modifiers](#63-acces-modifiers)

## 11.6. Tìm hiểu về dictionary

[5.4 Dictionary](#54-dictionary)

## 11.7. Các cách để hàm nhập vào Console.Readline()! không cần dấu ! mà không bị warning

Cách 1: Dùng ?? để gán giá trị mặc định khi null

```csharp
string s = Console.ReadLine() ?? "";
```

Với cách này, giá trị của string s sẽ được gán giá trị mặc định là null nếu không nhập vào.


# Oracle trong C# (Oracle.ManagedDataAccess)

## 12. Oracle Database trong C#

Tổng hợp các lớp và phương thức thường dùng khi làm việc với Oracle Database trong C#.

---

## 12.1. OracleConnection

Dùng để kết nối với Oracle Database.

### Các phương thức thường dùng

| Phương thức | Chức năng |
|-------------|-----------|
| `Open()` | Mở kết nối đến Oracle Database |
| `Close()` | Đóng kết nối |
| `BeginTransaction()` | Bắt đầu một Transaction |
| `CreateCommand()` | Tạo một `OracleCommand` gắn với Connection |
| `Dispose()` | Giải phóng tài nguyên |

### Các thuộc tính thường dùng

| Thuộc tính | Chức năng |
|------------|-----------|
| `State` | Trạng thái kết nối (`Open`, `Closed`) |
| `ConnectionString` | Chuỗi kết nối tới Oracle |

---

## 12.2. OracleCommand

Dùng để thực thi câu lệnh SQL hoặc PL/SQL.

### Các phương thức thường dùng

| Phương thức | Chức năng |
|-------------|-----------|
| `ExecuteNonQuery()` | Thực hiện INSERT, UPDATE, DELETE, CREATE, DROP,... |
| `ExecuteReader()` | Thực hiện SELECT và trả về nhiều dòng dữ liệu |
| `ExecuteScalar()` | Thực hiện SELECT và trả về một giá trị duy nhất |
| `Dispose()` | Giải phóng tài nguyên |

### Các thuộc tính thường dùng

| Thuộc tính | Chức năng |
|------------|-----------|
| `CommandText` | Nội dung câu lệnh SQL |
| `Connection` | Connection đang sử dụng |
| `Transaction` | Transaction đang sử dụng |
| `Parameters` | Danh sách tham số truyền vào SQL |
| `CommandType` | Kiểu câu lệnh (`Text`, `StoredProcedure`) |
| `BindByName` | Ghép tham số theo tên thay vì theo vị trí |

---

## 12.3. OracleParameter

Dùng để truyền tham số vào câu lệnh SQL nhằm tránh SQL Injection.

### Các phương thức thường dùng

| Phương thức | Chức năng |
|-------------|-----------|
| `Parameters.Add()` | Thêm tham số |
| `Parameters.Clear()` | Xóa toàn bộ tham số |

### Lưu ý

- Trong câu lệnh SQL:

```sql
WHERE SoTK = :stk
```

- Khi thêm tham số:

```csharp
cmd.Parameters.Add("stk", value);
```

**Không thêm dấu `:` khi gọi `Add()`.**

---

## 12.4. OracleDataReader

Dùng để đọc dữ liệu trả về từ câu lệnh `SELECT`.

### Các phương thức thường dùng

| Phương thức | Chức năng |
|-------------|-----------|
| `Read()` | Đọc sang dòng tiếp theo |
| `GetString()` | Lấy dữ liệu kiểu `string` |
| `GetInt32()` | Lấy dữ liệu kiểu `int` |
| `GetDecimal()` | Lấy dữ liệu kiểu `decimal` |
| `GetDateTime()` | Lấy dữ liệu kiểu `DateTime` |
| `IsDBNull()` | Kiểm tra giá trị NULL |
| `Close()` | Đóng DataReader |

---

## 12.5. OracleTransaction

Dùng để quản lý Transaction trong Oracle.

### Các phương thức thường dùng

| Phương thức | Chức năng |
|-------------|-----------|
| `Commit()` | Lưu toàn bộ thay đổi |
| `Rollback()` | Hủy toàn bộ thay đổi |
| `Dispose()` | Giải phóng Transaction |

### Các thuộc tính thường dùng

| Thuộc tính | Chức năng |
|------------|-----------|
| `Connection` | Connection đang sử dụng |
| `IsolationLevel` | Mức cô lập của Transaction |

---

## 12.6. using

Nên sử dụng `using` khi làm việc với Oracle.

Ví dụ:

- `OracleConnection`
- `OracleCommand`
- `OracleDataReader`
- `OracleTransaction`

`using` sẽ tự động gọi `Dispose()` khi đối tượng ra khỏi phạm vi sử dụng.

---

## 12.7. Thứ tự làm việc với Oracle

```text
OracleConnection
      │
      ▼
Open()
      │
      ▼
OracleCommand
      │
      ▼
Parameters.Add()
      │
      ▼
Execute...
      │
      ▼
OracleDataReader (nếu SELECT)
      │
      ▼
Commit()/Rollback() (nếu dùng Transaction)
      │
      ▼
Close()/Dispose()
```

---

## 12.8. Khi nào dùng từng phương thức?

| Phương thức | Khi sử dụng |
|-------------|-------------|
| `Open()` | Mở kết nối Database |
| `Close()` | Đóng kết nối |
| `ExecuteNonQuery()` | INSERT, UPDATE, DELETE |
| `ExecuteReader()` | SELECT nhiều dòng |
| `ExecuteScalar()` | SELECT một giá trị |
| `Commit()` | Lưu Transaction |
| `Rollback()` | Hủy Transaction |
| `Read()` | Đọc từng dòng dữ liệu |
| `Parameters.Add()` | Truyền tham số |

---

## 12.9. Những lưu ý quan trọng

- Luôn sử dụng `Parameters.Add()` thay vì nối chuỗi SQL.
- Không thêm dấu `:` khi gọi `Parameters.Add()`.
- Luôn dùng `using` để tự động giải phóng tài nguyên.
- Chỉ mở kết nối khi cần và đóng ngay sau khi sử dụng.
- Khi dùng Transaction, nhớ gán:

```csharp
cmd.Transaction = tran;
```

trước khi thực thi câu lệnh.

- Nếu đọc dữ liệu bằng `OracleDataReader`, nên đóng Reader sau khi sử dụng.
- Kiểm tra số dòng bị ảnh hưởng sau `ExecuteNonQuery()` nếu cần xác nhận thao tác thành công.
- Với các thao tác liên quan nhiều câu lệnh (ví dụ chuyển tiền), luôn sử dụng `OracleTransaction`.

---

## 12.10. Tóm tắt các lớp quan trọng

| Lớp | Mục đích |
|------|----------|
| `OracleConnection` | Kết nối Oracle Database |
| `OracleCommand` | Thực thi câu lệnh SQL |
| `OracleParameter` | Truyền tham số cho SQL |
| `OracleDataReader` | Đọc dữ liệu từ SELECT |
| `OracleTransaction` | Quản lý Transaction |
---

## 12.11. OracleDbType

`OracleDbType` dùng để chỉ định kiểu dữ liệu của tham số khi truyền vào SQL hoặc Stored Procedure.

### Một số kiểu dữ liệu thường dùng

| OracleDbType | Kiểu dữ liệu C# | Oracle |
|--------------|-----------------|---------|
| `Varchar2` | `string` | VARCHAR2 |
| `Char` | `string` | CHAR |
| `Int32` | `int` | NUMBER |
| `Decimal` | `decimal` | NUMBER |
| `Double` | `double` | BINARY_DOUBLE |
| `Date` | `DateTime` | DATE |
| `TimeStamp` | `DateTime` | TIMESTAMP |
| `Blob` | `byte[]` | BLOB |
| `Clob` | `string` | CLOB |

### Khi nào cần dùng?

Thông thường:

```csharp
cmd.Parameters.Add("stk", "123456");
```

là đủ.

Nếu muốn chỉ rõ kiểu dữ liệu:

```csharp
cmd.Parameters.Add("stk", OracleDbType.Varchar2).Value = "123456";
```

---

## 12.12. Stored Procedure

Stored Procedure là tập hợp các câu lệnh SQL được lưu trực tiếp trong Oracle Database.

### Thực thi Stored Procedure

```csharp
OracleCommand cmd = new OracleCommand("TenProcedure", conn);

cmd.CommandType = CommandType.StoredProcedure;
```

Sau đó thêm các Parameters rồi gọi:

```csharp
cmd.ExecuteNonQuery();
```

---

## 12.13. Sequence

Sequence dùng để sinh số tự động.

Ví dụ

```sql
CREATE SEQUENCE seq_khach_hang
START WITH 1
INCREMENT BY 1;
```

Lấy giá trị tiếp theo

```sql
seq_khach_hang.NEXTVAL
```

Lấy giá trị hiện tại

```sql
seq_khach_hang.CURRVAL
```

Thường dùng để sinh khóa chính.

---

## 12.14. Trigger

Trigger là đoạn PL/SQL tự động chạy khi có:

- INSERT
- UPDATE
- DELETE

Ví dụ

```sql
CREATE OR REPLACE TRIGGER trg_khach_hang
BEFORE INSERT ON KHACH_HANG
FOR EACH ROW
BEGIN
    :NEW.MaKH := seq_khach_hang.NEXTVAL;
END;
```

Nhờ Trigger, C# không cần truyền `MaKH`.

---

## 12.15. Transaction

Transaction giúp đảm bảo nhiều thao tác được thực hiện như một giao dịch.

### Các phương thức

| Hàm | Chức năng |
|------|-----------|
| `BeginTransaction()` | Bắt đầu Transaction |
| `Commit()` | Lưu thay đổi |
| `Rollback()` | Hủy thay đổi |

Ví dụ sử dụng

```
Bắt đầu Transaction
        │
        ▼
SQL 1
        │
        ▼
SQL 2
        │
        ▼
Commit()
```

Nếu có lỗi

```
Bắt đầu Transaction
        │
        ▼
SQL 1
        │
        ▼
SQL 2 (Lỗi)
        │
        ▼
Rollback()
```

---

## 12.16. SQL Injection

Không nên

```csharp
string sql =
"SELECT * FROM KHACH_HANG WHERE SoTK='" + stk + "'";
```

Nên

```csharp
string sql =
"SELECT * FROM KHACH_HANG WHERE SoTK=:stk";

cmd.Parameters.Add("stk", stk);
```

Luôn sử dụng `Parameters.Add()` để tránh SQL Injection.

---

## 12.17. using

Các đối tượng nên đặt trong `using`

- OracleConnection
- OracleCommand
- OracleDataReader
- OracleTransaction

Lợi ích

- Tự động gọi `Dispose()`
- Không rò rỉ tài nguyên
- Đóng Connection đúng lúc

---

## 12.18. Thứ tự làm việc chuẩn

```
OracleConnection
        │
        ▼
Open()
        │
        ▼
OracleCommand
        │
        ▼
Parameters.Add()
        │
        ▼
Execute...
        │
        ▼
OracleDataReader
        │
        ▼
Commit()/Rollback()
        │
        ▼
Dispose()
```

---

## 12.19. Cheat Sheet

| Muốn làm gì? | Hàm |
|--------------|-----|
| Mở kết nối | `Open()` |
| Đóng kết nối | `Close()` |
| INSERT | `ExecuteNonQuery()` |
| UPDATE | `ExecuteNonQuery()` |
| DELETE | `ExecuteNonQuery()` |
| SELECT nhiều dòng | `ExecuteReader()` |
| SELECT 1 giá trị | `ExecuteScalar()` |
| Thêm Parameter | `Parameters.Add()` |
| Đọc dữ liệu | `Read()` |
| Kiểm tra NULL | `IsDBNull()` |
| Transaction | `BeginTransaction()` |
| Lưu Transaction | `Commit()` |
| Hủy Transaction | `Rollback()` |