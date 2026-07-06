using System;
class Solienke
{
    static bool check(String s)
    {
        for(int i = 0; i < s.Length - 1; i++)
        {
            if(Math.Abs(s[i]-s[i+1]) != 1) return false;
        }
        return true;
    }
    static void Main(String[] args)
    {
        int t=int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            String s=Console.ReadLine()!;
            if(check(s)) Console.WriteLine("YES");
            else Console.WriteLine("NO"); 
        }
    }
}