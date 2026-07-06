using System;
class Animal
{
    public virtual void tiengkeu()
    {
        Console.WriteLine("Tieng keu cua dong vat");
    }
}
class Dog: Animal
{
    public override void tiengkeu()
    {
        Console.WriteLine("Cho keu gau gau");
    }
}
class Cat : Animal
{
    public override void tiengkeu()
    {
        Console.WriteLine("Conmeokeumeomeo");
    }
}
class Bird : Animal
{
    public override void tiengkeu()
    {
        Console.WriteLine("Con chim keu caca");
    }
}
class Oopdahinh
{
    public static void Main(string[] args)
    {
        Animal cho= new Dog();
        Animal meo= new Cat();
        Animal chim= new Bird();
        cho.tiengkeu();
        meo.tiengkeu();
        chim.tiengkeu();
        Animal[] a={cho,meo,chim};
        foreach(Animal x in a){
            x.tiengkeu();
        }
    }
}
