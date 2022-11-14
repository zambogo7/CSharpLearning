using System;
namespace Constructor
{
    class Car
    {
        public string model;
        public string color;
        public int age;

        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            age = modelYear;
        }
    }
    class Student
    {
        public string studentName;

        public Student(string name)
        {
            studentName = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1999);
            Console.WriteLine($"My new car is {Ford.model} of color: {Ford.color} which i bought {Ford.age} ");

            Student mathComp = new Student("Zedekiah Ambogo");
            Console.WriteLine(mathComp.studentName);



        }
    }
}