using System;
namespace khaibaohcn
{
    class Rectange
    {
        double width;
        double height;
        string color;
        public Rectange(double width,double height,string color)
        {
            if (width <= 0 || height <= 0)
                throw new Exception();
            this.width=width;
            this.height=height;
            this.color=char.ToUpper(color[0])+color.Substring(1).ToLower();
        }
        public String getColor()
        {
            return this.color;
        }
        public double findArea()
        {
            return this.width*this.height;
        }
        public double findPerimeter()
        {
            return (this.width+this.height)*2;
        }
    }
    class Program
    {
        public static void Main()
        {
            string[] s=Console.ReadLine()!.Split();
            int w=int.Parse(s[0]);
            int h=int.Parse(s[1]);
            string color=s[2];
            try
            {
                Rectange a=new Rectange(w,h,color);
                Console.WriteLine($"{a.findArea()} {a.findPerimeter()} {a.getColor()}");
            }
            catch
            {
                Console.WriteLine("INVALID");
            }   
        }
    }
}