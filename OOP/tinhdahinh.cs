using System;
namespace tinhdahinh{
class Sung
{
    public virtual void tiengsung()
    {
        Console.WriteLine("bang bang");
    }
}
class Sungtruong:Sung
{
    public override void tiengsung()
    {
        Console.WriteLine("tach tach");
    }
}
class SungLuc:Sung
{
    public override void tiengsung()
    {
        Console.WriteLine("Doang doang");
    }
}
class SungTieulien:Sung
{
    public override void tiengsung()
    {
        Console.WriteLine("ttttt");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Sung a=new Sungtruong();
        Sung b=new SungLuc();
        Sung c=new SungTieulien();
        Sung[] chuoi={a,b,c};
        foreach(Sung j in chuoi)
        {
            j.tiengsung();
        }
        object x = 123;

string? s = x as string;

Console.WriteLine(s);
    }
}
}