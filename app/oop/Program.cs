using System;
using System;
namespace Myapplication
{
    
    class Car
    {
      public  string model;sd
      public string color;
      public  int year;
      public void fullThrottle()
      {
            Console.WriteLine("The cars of color  is going as fast as it can!");

      }
    
    }
    class Program
    {
           static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);

            Car myObj = new Car();
            myObj.fullThrottle();
        }
        
    }
}