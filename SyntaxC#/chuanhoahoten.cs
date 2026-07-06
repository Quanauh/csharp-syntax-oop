using System;
namespace chuanhoa
{
    class Chuanhoa
    {
        public static void Main(String[] args)
        {
            int t=int.Parse(Console.ReadLine()!);
            while(t-->0){
            string[] a=Console.ReadLine()!.Trim().ToLower().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < a.Length; i++)
            {
                a[i]=char.ToUpper(a[i][0])+a[i].Substring(1);
            }
            Console.WriteLine(string.Join(" ",a));
        }
    }

    }
}