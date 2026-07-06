using System;
namespace Program
{
    public class Program
    {   
        static bool snt(long n)
        {
            if(n<2) return false;
            for(long i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n%i==0) return false;
            }
            return true;
        }
        public static void Main(String[] args)
        {
            int t=int.Parse(Console.ReadLine()!);
            while (t-- > 0)
            {
                long n=long.Parse(Console.ReadLine()!);
                long ans=0;
                for(long i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        while (n % i == 0)
                        {
                            ans=i;
                            n/=i;
                        }
                    }
                }
                if(snt(n)&&n>ans) ans=n;
                Console.WriteLine(ans);
            }
        }
    }
}