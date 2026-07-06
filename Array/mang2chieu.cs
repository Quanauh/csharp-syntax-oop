using System;
class Mang2chieu
{
    public static void Main(string[] args)
    {
        int[] s=Array.ConvertAll(Console.ReadLine()!.Split(),int.Parse);
        int [,] a=new int[s[0],s[1]];
        for(int i = 0; i < s[0]; i++)
        {
            int[] aa=Array.ConvertAll(Console.ReadLine()!.Split(),int.Parse);
            for(int j = 0; j < s[1]; j++)
            {
                a[i,j]=aa[j];
            }
        }
        for(int i = 0; i < s[0]; i++)
        {
            for(int j = 0; j < s[1]; j++)
            {
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}