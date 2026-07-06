using System;
namespace xephang
{
    class Xephang
    {
        public static void Main(string[] args)
        {
            
        int n=int.Parse(Console.ReadLine()!);
        List<(long t,long d)> a= new List<(long,long)>();
        for(int i=0;i<n;i++){
          long[] s=Array.ConvertAll(Console.ReadLine()!.Split(),long.Parse);
          a.Add((s[0],s[1]));  
        }
        a.Sort((x,y)=>x.t.CompareTo(y.t));
        long time=0;
        foreach(var x in a)
            {
                if(time<x.t)time=x.t;
                time+=x.d;
            }
            Console.WriteLine(time);
    }
    }
}