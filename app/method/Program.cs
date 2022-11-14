using System;
namespace Method
{
    class Method
    {
        static void Main(String[] args)
        {
            myMethod();
            nameAge("Zedekiah", 23);
            Console.WriteLine(add(3,4));

        }
        static void myMethod()
        {
            Console.WriteLine("I love coding");
        }
        static void nameAge(string fname, int age)
        {
            Console.WriteLine(fname + " Ambogo is " + age + " years old");
        }
        static int add(int x, int y)
        {
            return x + y;
        }
    }
}