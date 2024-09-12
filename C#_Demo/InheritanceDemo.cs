
using System;


namespace InheritanceDemo
{
    abstract class Species
    {
        public abstract void Eat();
        public abstract void Sleep();
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("I am eating");
        }

        public void Sleep()
        {
            Console.WriteLine("I am sleeping");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("I am barking");
        }

        public void Run()
        {
            Console.WriteLine("I am running");
        }


    }
}