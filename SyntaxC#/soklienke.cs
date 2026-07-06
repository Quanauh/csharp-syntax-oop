using System;
class Soklienke
{
    static bool check(String s)
    {
        int dem=0;
        for(int i = 0; i <s.Length-1; i++)
        {
            dem+=s[i]-'0';
            if(Math.Abs(s[i]-s[i+1])!=2) return false;
        }
        dem+=s[s.Length-1]-'0';
        if(dem%10!=0) return false;
        return true;
    }
    static void Main(String[] args)
    {
        int t=int.Parse(Console.ReadLine()!);
        while(t-->0)
        {
            String s=Console.ReadLine()!;
            if(check(s)) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}