using System;
class SP
{
    public string Ma;
    public string Tensp;
    public long Dongia1;
    public long Dongia2;
    public SP(string Ma,string Tensp,long Dongia1,long Dongia2)
    {
        this.Ma=Ma;
        this.Tensp=Tensp;
        this.Dongia1=Dongia1;
        this.Dongia2=Dongia2;
    }
}
class HD
{
    string maHD;
    string Tensp;
    long tiengiam;
    long tientra;
    public HD(string maHD,string Tensp,long tiengiam,long tientra)
    {
        this.maHD=maHD;
        this.Tensp=Tensp;
        this.tiengiam=tiengiam;
        this.tientra=tientra;
    }
    public override string ToString()
    {
        return $"{maHD} {Tensp} {tiengiam} {tientra}";
    }
}
class Donhangg
{      
    public static void Main(string[] args){
    int t=int.Parse(Console.ReadLine()!);
    Dictionary<string,SP> mp=new Dictionary<string, SP>();
    for(int i=0;i<t;i++){
        string Ma=Console.ReadLine()!;
        string Tensp=Console.ReadLine()!;
        long Dongia1=long.Parse(Console.ReadLine()!);
        long Dongia2=long.Parse(Console.ReadLine()!);
        mp[Ma]=new SP(Ma,Tensp,Dongia1,Dongia2);
    }
    int n=int.Parse(Console.ReadLine()!);
    for(int i = 1; i <= n; i++)
        {
            string[] s=Console.ReadLine()!.Split();
            string mahddau=s[0];
            string ma=s[0].Substring(0,2);
            long sl=long.Parse(s[1]);
            int loai=s[0][2]-'0';
            SP p=mp[ma];
            long gia;
            if (loai == 1)
            {
                gia=p.Dongia1;
            }
            else gia=p.Dongia2;
            long tiengiam=0;
            long tong=sl*gia;
            if(sl>=150) tiengiam=50*tong/100;
            else if(sl>=100) tiengiam=30*tong/100;
            else if(sl>=50) tiengiam=15*tong/100;
            long tientra = tong-tiengiam;
            string masp=s[0]+"-"+i.ToString("D3");
            HD a=new HD(masp,p.Tensp,tiengiam,tientra);
            Console.WriteLine(a);   
        }
    }
}