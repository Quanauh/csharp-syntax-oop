using System;
namespace MyApp
{
    public class Program
    {
        static void Main(String[] args)
        {
           String s=Console.ReadLine()!;
            int dem=0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]=='4' || s[i]=='7') dem++;
            }
            if(dem==4 || dem==7) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}