using System;
namespace accessModifier
{
    class Car
    {
        public string model = "Mustang";
        
    }
    class Person
    {
       
        public string Name //A property
        {
            get; set;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car Rav = new Car();
            Console.WriteLine(Rav.model);

            Person Student = new Person();
            Student.Name = "Zedekiah Ambogo";
            Console.WriteLine(Student.Name);

        }
        

    }
}