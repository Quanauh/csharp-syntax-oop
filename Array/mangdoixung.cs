using System;
    class Mangdoixung
    {           
        static void Main(String[] args)
        {
            int t=int.Parse(Console.ReadLine()!);
            while (t-- > 0)
            {
                int n=int.Parse(Console.ReadLine()!);
                int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            static bool check(int[] a,int n){
            for(int i = 0; i < n; i++)
            {
                if(a[i]!=a[n-i-1]) return false;
            }
            return true;
            }
                if(check(a,n)) Console.WriteLine("YES");
                else Console.WriteLine("NO");
        }
            }
        }
    
