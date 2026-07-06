using System;
namespace oopkethua{
class Animal
{
    public string type="Dog";
    public string bark()
    {
        return "gau gau";
    }
}
class Dog: Animal
{
    public string name="Lulu";
}
class Oopkethua
{
    public static void Main(string[] args)
    {
        Dog a=new Dog();
        Console.WriteLine(a.name + " " + a.bark());
    }
}
}