using System;
using InheritanceDemo;
using gettersetter;
namespace C__Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ////assign a variable to areadline
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);

            ////instance of class
            //RandomDemo randomDemo = new RandomDemo();
            //randomDemo.GenerateRandomNumbers();

            ////instance of Hypotenuse
            //HypotenuseExample hypotenuseExample = new HypotenuseExample();
            //hypotenuseExample.FindHypotenuse();

            ////instance of StringMethods
            //StringMethods stringMethods = new StringMethods();
            //stringMethods.StringMethodsDemo();

            ////instance of WhileLoop
            //WhileLoopExamples whileLoopExamples = new WhileLoopExamples();
            //whileLoopExamples.WhileLoopExample();

            ////instance of Exceptions
            //ExceptionsDemo exceptionsDemo = new ExceptionsDemo();
            //exceptionsDemo.ExceptionsDemoMethod();

            ////instance of in Animal
            //Animal animal = new Animal();
            //animal.Eat();
            //animal.Sleep();

            ////instance of in Dog
            //Dog dog = new Dog();
            //dog.Bark();
            //dog.Run();
            //dog.Eat();
            //dog.Sleep();


            //instance of ToStringDemo
            ToStringDemo toStringDemo = new ToStringDemo();
            toStringDemo.DemoMethod();

            //instance of PolymorphismDemo
            PolymorphismDemo polymorphismDemo = new PolymorphismDemo();
            polymorphismDemo.PolymorphismDemoMethod();

            //instance of ListDemo  
            ListsDemo listDemo = new ListsDemo();
            listDemo.ListsDemoMethod();

            //instance of GetterSetter
            GetterSetter getterSetter = new GetterSetter();
            getterSetter.Speed = 100;
            Console.WriteLine("Speed of the car is " + getterSetter.Speed);

            //instance of EnumDemo
            EnumDemo enumDemo = new EnumDemo();
            enumDemo.DisplayDays();

            Console.ReadKey();
        }
    }
}