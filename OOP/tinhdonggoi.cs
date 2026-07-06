using System;
class SinhVien
{
    private string maSV;
    private string tenSV;
    private double diem;
    public SinhVien(string maSV,string tenSV,double diem)
    {
        this.maSV=maSV;
        this.tenSV=tenSV;
        this.diem=diem;
    }
    public double getDiem()
    {
        return this.diem;
    }
}
class Tinhdonggoi
{
    public static void Main(string[] args)
    {
        string ma=Console.ReadLine()!;
        string ten=Console.ReadLine()!;
        double diem=double.Parse(Console.ReadLine()!);
        SinhVien a=new SinhVien(ma,ten,diem);
        Console.WriteLine(a.getDiem());
    }
}