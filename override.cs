using System;

namespace Virtual_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Animal animal = new Animal();
            animal.Speak();
            Dog dog = new Dog();
            dog.Speak();
            Cat cat = new Cat();
            cat.Speak();
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows");
        }
    }
}
