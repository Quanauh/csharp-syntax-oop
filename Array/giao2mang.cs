using System;
namespace giao2mang
{
    class giao2mang
    {
        public static void Main(string[] args)
        {
            string[] s=Console.ReadLine()!.Split();
            int n=int.Parse(s[0]);
            int m=int.Parse(s[1]);
            bool[] a=new bool[1001];
            bool[] b=new bool[1001];
            string[] arr1=Console.ReadLine()!.Split();
            for(int i = 0; i < n; i++)
            {
                int x=int.Parse(arr1[i]);
                a[x]=true;
            }
            string[] arr2=Console.ReadLine()!.Split();
            for(int i = 0; i < m; i++)
            {
                int x=int.Parse(arr2[i]);
                b[x]=true;
            }
            for(int i = 0; i < 1000; i++)
            {
                if(a[i]&&b[i]) Console.Write(i+" ");
            }
        }
    }
}