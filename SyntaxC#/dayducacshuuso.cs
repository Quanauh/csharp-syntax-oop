using System;
namespace dayducacshuuso
{
public class Program
{
    public static void Main(String[] args)
    {
     int t=int.Parse(Console.ReadLine()!);
            while (t-- > 0)
            {
                bool [] a= new bool[10];
                int n=int.Parse(Console.ReadLine()!);
                if (n == 0)
                {
                    Console.WriteLine("Impossible");
                    continue;
                }
                int k=1;

                while (true)
                {
                int tmp=n*k;
                    while (tmp > 0)
                    {
                        int cs=tmp%10;
                        a[cs]=true;
                        tmp/=10;
                    }    
                    int dem=0;
               for(int i=0;i<10;i++){
                   if(a[i]==true) dem++;
               }
               if(dem==10)break;
               k++;
                }
                Console.WriteLine(n*k);
            }   
    }
}
}