using System;
class SanPham
{
    public string ma;
    public string ten;
    public long Gia1;
    public long Gia2;
    public SanPham(string ma,string ten,long Gia1, long Gia2)
    {
        this.ma=ma;
        this.ten=ten;
        this.Gia1=Gia1;
        this.Gia2=Gia2;
    }
}
class HoaDon
{
    string maHD;
    string tenSP;
    long giamgia;
    public long thanhtien;
    public HoaDon(string maHD,string tenSP,long giamgia,long thanhtien)
    {
        this.maHD=maHD;
        this.tenSP=tenSP;
        this.giamgia=giamgia;
        this.thanhtien=thanhtien;
    }
    public override string ToString()
    {
        return $"{maHD} {tenSP} {giamgia} {thanhtien}";
    }
}
class Hoadonqao
{
    public static void Main(string[] args)
    {
        int t=int.Parse(Console.ReadLine()!);
        Dictionary <string,SanPham> mp=new Dictionary <string,SanPham>();
        for(int i = 0; i < t; i++)
        {
            string ma=Console.ReadLine()!;
            string ten=Console.ReadLine()!;
            long Gia1=long.Parse(Console.ReadLine()!);
            long Gia2=long.Parse(Console.ReadLine()!);
            mp[ma]=new SanPham(ma,ten,Gia1,Gia2);
        }
        int n=int.Parse(Console.ReadLine()!);
        List<HoaDon> a= new List<HoaDon>();
        for(int i = 1; i <= n; i++)
        {
            string[] s=Console.ReadLine()!.Split();
            string ma=s[0].Substring(0,2);
            int loai=s[0][2]-'0';
            int sl=int.Parse(s[1]);
            SanPham p=mp[ma];
            long gia = (loai==1)? gia=p.Gia1:gia=p.Gia2;
            long tong=gia*sl;
            long giamgia=0;
            if(sl>=150) giamgia=tong*50/100;
            else if(sl>=100) giamgia=tong*30/100;
            else if(sl>=50) giamgia=tong*15/100;
            long thanhtien=tong-giamgia;
            string maHD=s[0]+"-"+i.ToString("D3");
            HoaDon q=new HoaDon(maHD,p.ten,giamgia,thanhtien);
            a.Add(q);
        }
        a.Sort((x,y)=>y.thanhtien.CompareTo(x.thanhtien));
        foreach(HoaDon x in a)
        {
            Console.WriteLine(x);
        }
    }
}