using System;
namespace Inheritance
{
    class Vehicle
    {
        public string Brand = "Ford";
        public void honk()
        {
            Console.WriteLine("tuut! tuut!");
        }
    }
    class Car : Vehicle
    {
        public string modelName = "Mustang";
    }
    class Program 
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine($"{myCar.Brand} {myCar.modelName}");
        }
    }
}