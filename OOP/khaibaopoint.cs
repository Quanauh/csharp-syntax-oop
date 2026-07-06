using System;
namespace khaibaopoint
{
    class Point
    {
        private double x;
        private double y;
        public Point(double x,double y)
        {
            this.x=x;
            this.y=y;
        }
        public double getX()
        {
            return this.x;
        } 
        public double getY()
        {
            return this.y;
        }
        public double distance(Point a)
        {
            return Math.Sqrt((this.x-a.x)*(this.x-a.x)+(this.y-a.y)*(this.y-a.y));
        }
    }
class Program
{
    public static void Main(string[] args)
    {
        int t=int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int[] a=Array.ConvertAll(Console.ReadLine()!.Split(),int.Parse);
            Point m= new Point(a[0],a[1]);
            Point n=new Point(a[2],a[3]);
            Console.Write($"{m.distance(n):F4}");
        }
    }
}
}