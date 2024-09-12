
using System;


namespace C__Demo
{
    public class ToStringDemo
    {
        public void DemoMethod()

        //ToString() method is used to return a string representation of an object.
        {
            //instance of car
            Car car = new Car("Toyota", "Camry", 2022);
            Console.WriteLine(car.ToString());
        }
    }
    class Car
    {
        string make;
        string model;
        int year;

        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public override string ToString()
        {
            return $"Make: {make}, Model: {model}, Year: {year}";
        }

    }
}