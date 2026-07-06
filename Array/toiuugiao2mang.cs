using System;
using System.Collections.Generic;
using System.Linq;

class giao2mang2
{
    public static void Main(string[] args)
    {
        Console.ReadLine(); // n, m không thực sự cần dùng khi đã Split hết dòng
        var a = new HashSet<int>(Console.ReadLine()!.Split().Select(int.Parse));
        var b = Console.ReadLine()!.Split().Select(int.Parse);

        foreach (var x in b)
            if (a.Contains(x))
                Console.Write(x + " ");
    }
}