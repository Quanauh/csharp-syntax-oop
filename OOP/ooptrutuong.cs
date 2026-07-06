using System;
namespace ooptruutuong{
  interface Animal
{
   void tiengkeu();
}
class Dog : Animal
{
    public void tiengkeu()
    {
     Console.WriteLine("Cho keu gau gau"); 
    }
}
class Cat: Animal
{
    public void tiengkeu()
    {
      Console.WriteLine("Meo keu meo meo");
    }
}
class Program
{
  public static void Main(string[] args)
  {
    string s = Console.ReadLine() ?? "";
    Animal a=new Dog();
    Animal d=new Cat();
    Cat c=new Cat();
    a.tiengkeu();
    c.tiengkeu();
  }
} 
}
