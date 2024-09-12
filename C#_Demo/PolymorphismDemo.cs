
using System;


namespace C__Demo
{

    class PolymorphismDemo
    {
        public void PolymorphismDemoMethod()
        {

            //polymorphism - object can be identified by more than one type

            Bicycle bicycle = new Bicycle();
            Car1 car = new Car1();
            Boat boat = new Boat();

            Vehicle[] vehicles = { bicycle, car, boat };
            foreach (Vehicle v in vehicles)
            {
                v.Go();
            }

        }
    }

    class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }

        //go method
        public virtual void Go()
        {
        }
    }

    class Bicycle : Vehicle
    {
        public int Wheels { get; set; }
        public bool IsElectric { get; set; }

        public override void Go()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Car1 : Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override void Go()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Boat : Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int NumberOfEngines { get; set; }

        public override void Go()
        {
            Console.WriteLine("Boat is moving");
        }
    }
}