using System;
namespace donhang{
class Product
{
    public string Ma;
    public string Ten;
    public long Gia1;
    public long Gia2;

    public Product(string ma, string ten, long gia1, long gia2)
    {
        Ma = ma;
        Ten = ten;
        Gia1 = gia1;
        Gia2 = gia2;
    }
}

class Bill
{
    private string maHD;
    private string tenSP;
    private long giamGia;
    private long thanhTien;

    public Bill(string maHD, string tenSP, long giamGia, long thanhTien)
    {
        this.maHD = maHD;
        this.tenSP = tenSP;
        this.giamGia = giamGia;
        this.thanhTien = thanhTien;
    }

    public override string ToString()
    {
        return $"{maHD} {tenSP} {giamGia} {thanhTien}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()!);

        Dictionary<string, Product> mp = new Dictionary<string, Product>();

        for (int i = 0; i < n; i++)
        {
            string ma = Console.ReadLine()!;
            string ten = Console.ReadLine()!;
            long gia1 = long.Parse(Console.ReadLine()!);
            long gia2 = long.Parse(Console.ReadLine()!);

            mp[ma] = new Product(ma, ten, gia1, gia2);
        }

        int m = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= m; i++)
        {
            string[] s = Console.ReadLine()!.Split();

            string mahdau = s[0];   
            long sl = long.Parse(s[1]);

            string ma = mahdau.Substring(0, 2);
            int loai = mahdau[2] - '0';

            Product p = mp[ma];

            long gia=(loai==1)? gia=p.Gia1 : gia=p.Gia2;

            long tong = gia * sl;

            long giam = 0;

            if (sl >= 150)
                giam = tong / 2;
            else if (sl >= 100)
                giam = tong * 30 / 100;
            else if (sl >= 50)
                giam = tong * 15 / 100;

            long thanhtien = tong - giam;

            string maHD = mahdau + "-" + i.ToString("D3");

            Bill bill = new Bill(maHD, p.Ten, giam, thanhtien);

            Console.WriteLine(bill);
        }
    }
}
}