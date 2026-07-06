using System;
    class Mangdoixung2
    {           
        static void Main(String[] args)
        {
            int t=int.Parse(Console.ReadLine()!);
            while (t-- > 0)
            {
                int n=int.Parse(Console.ReadLine()!);
                int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int ok=1;
            for(int i = 0; i < n; i++)
            {
                if(a[i]!=a[n-i-1]) ok=0;
            }
                if(ok==1) Console.WriteLine("YES");
                else Console.WriteLine("NO");
        }
            }
        }
    
