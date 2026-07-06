using System;

class HelloWord
{
    static void Main()
    {
        Console.Write("Nhap ten: ");
        string ten = Console.ReadLine()!;

        Console.WriteLine("Xin chao " + ten);
    }
}