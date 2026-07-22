Console.Write("Nhap so tai khoan: ");
string stk = Console.ReadLine()!;

if (string.IsNullOrWhiteSpace(stk))
{
    Console.WriteLine("So tai khoan khong duoc de trong.");
    return;
}

if (stk.Contains(' '))
{
    Console.WriteLine("So tai khoan khong duoc chua khoang trang.");
    return;
}